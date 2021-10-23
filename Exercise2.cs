using System;
namespace Cofe
{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter numbers lenght: ");
            int lenght = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int input = 0;

            for (int i = 0; i < lenght; ++i)
            {
                Console.WriteLine("Enter a number: ");
                input = Convert.ToInt32(Console.ReadLine());

                if (input >= 0)
                {
                    sum = sum + input;
                }
            }
            Console.WriteLine("The sum of the positive numbers is: " + sum);









        }
    }

    class ServiceCharge {
        //3 if statement


    }


    class tip{



    }


}
