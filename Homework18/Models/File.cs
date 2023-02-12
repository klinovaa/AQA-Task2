namespace Homework18.Models
{
    public class File
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public byte[] ImageData { get; set; }
        public File(string title, string filename, byte[] imageData)
        {
            Title = title;
            FileName = filename;
            ImageData = imageData;
        }
    }
}
