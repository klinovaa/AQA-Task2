using Homework7;

namespace AutomationCources.Lecture_7.Homework
{
    public class Polaroid : Technic, IPrinting, IPhotagraphing
    {
        private int paperWidth;
        private int paperHeight;
        private double numberOfPixelsInCamera;

        public Polaroid(int paperWidth, int paperHeight, double numberOfPixelsInCamera, string? modelName, decimal price)
            :base(modelName, price)
        {
            this.paperWidth = paperWidth;
            this.paperHeight = paperHeight;
            this.numberOfPixelsInCamera = numberOfPixelsInCamera;
        }

        public override string Description
        {
            get
            {
                return $"Price: {Price}, model:{ModelName}, number of pixels in camera: {numberOfPixelsInCamera}";
            }
        }

        public void TakePhoto()
        {
            Console.WriteLine("Press black button at the top and photo is ready");
        }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Press right side button");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Press Turn Off button");
        }
    }
}
