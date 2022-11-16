using Homework7;

namespace AutomationCources.Lecture_7.Homework
{
    public class MobilePhone : Technic, IPhotagraphing
    {
        private double numberOfPixelsInCamera;

        public MobilePhone(double numberOfPixelsInCamera, string? modelName, decimal price)
            : base(modelName, price)
        {
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
            Console.WriteLine("Press button on the screen and photo is ready");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Press left side button");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Press Turn Off button");
        }
    }
}
