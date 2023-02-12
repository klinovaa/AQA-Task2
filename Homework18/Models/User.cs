namespace Homework18.Models
{
    public class User
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public User(int age, string name)
        {
            Age = age;
            Name = name;
        }
    }
}
