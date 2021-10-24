using System;

namespace Coursework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Validate and store all client input values 
            string FirstName = String.Empty;
            while (Validator.FieldIsEmpty(FirstName))
            {
                Console.WriteLine("Please enter the client first name: ");
                FirstName = Console.ReadLine();
            }
            string LastName = String.Empty;
            while (Validator.FieldIsEmpty(LastName))
            {
                Console.WriteLine("Please enter the client last name: ");
                LastName = Console.ReadLine();
            }
            string Email = String.Empty;
            while (Validator.FieldIsEmpty(Email) || !Validator.EmailIsValid(Email))
            {
                Console.WriteLine("Please enter the client email: ");
                Email = Console.ReadLine();
            }
            string Address = String.Empty;
            while (Validator.FieldIsEmpty(Address))
            {
                Console.WriteLine("Please enter the client address: ");
                Address = Console.ReadLine();
            }
            string PhoneNumber = String.Empty;
            while (Validator.FieldIsEmpty(PhoneNumber) || !Validator.PhoneNumberIsValid(PhoneNumber))
            {
                Console.WriteLine("Please enter the client phone number: ");
                PhoneNumber = Console.ReadLine();
            }
            //At this point we have all the required information, we can create our object! 
            Client NewClient = new Client(FirstName,
                                          LastName,
                                          Email,
                                          Address,
                                          PhoneNumber); 
            //Display the client with the ToString method 
            Console.Write(NewClient.ToString());
        }
    }
}

