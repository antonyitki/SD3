using System;
namespace Ex
{
    public class FloatNumbersWhileAdd{
        private double sum;
        public void Start()
        {
            WriteProgramInfo();
            ReadInputAndSumNumbers();
            ShowTotal();
            ShowGrandTotal();
        }
        private void WriteProgramInfo()
        {
            Console.WriteLine("Price of the item: ");
            Console.WriteLine("Write 0 to Finish\n");
        }
        private void ReadInputAndSumNumbers()
        {
            bool done = false;
            while (!done)
            {
                double number = ReadInput();
                if (number != 0)
                {
                    sum += number;
                }
                else
                {
                    done = true;
                }
            }
        }
        private double ReadInput()
        {
            Console.Write("Price: ");
            double num = double.Parse(Console.ReadLine());
            return num;
        }
        private void ShowTotal()
        {
            Console.Write("\nThe Subtotal is : $ " + sum);
        }
        private void ShowGrandTotal()
        {
            Console.WriteLine("\n\nEnter number of people: ");
            int people = Convert.ToInt32(Console.ReadLine());
            if(people >= 1 && people <= 3)
            {
                sum = 1.05 * sum;
            }
            if (people >=4  && people <= 10)
            {
                sum = 1.10 * sum;
            }
            if (people > 10)
            {
                sum = 1.20 * sum;
            }


            Console.Write("\nThe TOTAL amount is : $ " + sum * people);
        }

    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Costa\n@ UOR\n\n#######################################");
            FloatNumbersWhileAdd fnwa = new FloatNumbersWhileAdd();
            fnwa.Start();

            

        }
    }

}