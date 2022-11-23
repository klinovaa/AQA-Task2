
namespace DaryaKlinavaSaysHello
{
    public class Homework8
    {
        public static void ShowMassiveElement()
        {
            try
            {
                int[] massive = { 8, 7, 1, 4, 2 };

                Console.WriteLine("Input index of element in massive:");
                string? inputedValue = Console.ReadLine();
                string? checkedValue = inputedValue.Equals(string.Empty) ? null : inputedValue;
                int inputtedNumber = Int32.Parse(checkedValue);

                int massiveElement = massive[inputtedNumber];
                Console.WriteLine($"Massive element that has index {inputedValue} has value {massiveElement}");
            }
            catch (IndexOutOfRangeException ex1)
            {
                Console.WriteLine("IndexOutOfRangeException has occurred");
                Console.WriteLine(ex1.Message);
            }
            catch (FormatException ex2)
            {
                Console.WriteLine("FormatException has occurred");
                Console.WriteLine(ex2.Message);
            }
            catch (ArgumentNullException ex3)
            {
                Console.WriteLine("ArgumentNullException has occurred");
                Console.WriteLine(ex3.Message);
            }
            catch (OverflowException ex4)
            {
                Console.WriteLine("OverflowException has occurred");
                Console.WriteLine(ex4.Message);
            }
            catch (Exception ex5)
            {
                Console.WriteLine("Some exception has occurred");
                Console.WriteLine(ex5.Message);
            }
        }
    }
}
