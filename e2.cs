using System;
namespace Ex{
    public class FloatNumbersWhileAdd{
        private double sum;
        private double sum_pay;
        private double total_wTip;

        public void Start(){ //main start program form here
            WriteProgramInfo();
            ReadInputAndSumNumbers();
            ShowTotal();
            ShowGrandTotal();
            Tip();
        }
        private void WriteProgramInfo(){
            Console.WriteLine("Price of the item: ");
            Console.WriteLine("Enter 0 to Finish\n");
        }
        private void ReadInputAndSumNumbers(){
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
        private double ReadInput(){
            Console.Write("Price of item: ");
            double num = double.Parse(Console.ReadLine());
            return num;
        }
        private void ShowTotal(){
            Console.Write("\nThe Subtotal (without servive charge) is : " + sum + " $");
        }
        private void ShowGrandTotal(){
            Console.WriteLine("\n\nEnter number of people: ");
            int people = Convert.ToInt32(Console.ReadLine());
            if (people >= 1 && people <= 3)
            {
                sum_pay = sum + 0.05 * sum;
            }
            if (people >= 4 && people <= 10)
            {
                sum_pay = sum + 0.10 * sum;
            }
            if (people > 10)
            {
                sum_pay = sum + 0.20 * sum;
            }
            Console.WriteLine("\nThe TOTAL amount is : $$ " + sum_pay);
        }
        private void Tip()
        {
            Console.WriteLine("How much tip do you give?\n");
            int tip = Convert.ToInt32(Console.ReadLine()); //this is coins or notes, not %.
            total_wTip = tip + sum_pay;
            Console.WriteLine("Your payment with ss and tip is: " + total_wTip);
        }
    }
    class Program{
        static void Main(){
            Console.WriteLine("Costa\n@ UOR\n\n#######################################");
            FloatNumbersWhileAdd fnwa = new FloatNumbersWhileAdd();
            fnwa.Start();
        }
    }
}