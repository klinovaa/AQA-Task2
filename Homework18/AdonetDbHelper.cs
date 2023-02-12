using Microsoft.Data.SqlClient;
using System.Data;

namespace Homework18
{
    public class AdonetDbHelper
    {
        private static string _connectionString => ConfigurationHelper.LocalDBConnectionString;

        public static void AddNewEntryToUsers(string name, int age)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                var sqlQuery = $"INSERT INTO Users (name, age) VALUES ('{name}', {age})";
                
                var sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
        }

        public static string GetLastEntryValueFromUsers(string columnName)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                var sqlQuery = "SELECT * FROM Users WHERE id = (SELECT max(id) FROM Users)";

                var sqlDataAdapter = new SqlDataAdapter(sqlQuery, sqlConnection);
                var dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet);

                var table = dataSet.Tables[0];
                var neededValue = table.Rows[0][columnName].ToString();

                return neededValue;
            }
        }
    }
}
