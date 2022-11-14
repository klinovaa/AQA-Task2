using Homework7;

namespace AutomationCources.Lecture_7.Homework
{
    public class Printer : Technic, IPrinting
    {
        private int paperWidth;
        private int paperHeight;

        public Printer(string? modelName, decimal price, int paperWidth, int paperHeight)
            :base(modelName, price)
        {
            this.paperWidth = paperWidth;
            this.paperHeight = paperHeight;
        }

        public override string Description
        {
            get
            {
                return $"Price: {Price}, model:{ModelName}";
            }
        }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Press button at the top");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Press Turn Off button");
        }
    }
}
