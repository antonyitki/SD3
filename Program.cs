using System;
using System.Text.RegularExpressions; 

namespace Coursework_1{
    public class Client{ //properties + constructors
        public string FirstName { get; set; }
        public string LastdName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Client(string FirstName, string LastName,
            string Email, string Address, string PhoneNumber){
            this.FirstName = FirstName;
            this.LastdName = LastName;
            this.Email = Email;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
        }
        public Client(){
            FirstName = null;
            LastdName = "";
            Email = " ";
            Address = null;
            PhoneNumber = null;
        }
        public override string ToString(){ //This is the output after validation
            Console.WriteLine("\n\n################################\n");
            return ("First Name: " + FirstName + "\n" +
                "Last Name: " + LastdName + "\n" +
                "Email: " + Email + "\n" +
                "Address: " + Address + "\n" +
                "Phone Number: " + PhoneNumber);
        }
    }

    public static class Validator{//validators
        public static bool FieldIsEmpty(string Value){
            if (string.IsNullOrEmpty(Value))
                return true;
            return false;
        }
        public static bool PhoneNumberIsValid(string PhoneNumber){
            if (PhoneNumber.Length == 11) //UK-07787878787
                return true;
            return false;
        }
        public static bool EmailIsValid(string Email){
            if (Regex.IsMatch(Email, "^[^@]+@[^@]+\\.[^@]+$"))
                return true;
            return false;
        }
    }

    class Program{
        static void Main(string[] args){ //Ask input, validate and store all input values 
            Console.WriteLine("Press ENTER to continue or q to exit!");
            while (Console.ReadLine() != "q")
            {
                string FirstName = String.Empty;
                while (Validator.FieldIsEmpty(FirstName))
                {
                    Console.WriteLine("First name: ");
                    FirstName = Console.ReadLine();
                }
                string LastName = String.Empty;
                while (Validator.FieldIsEmpty(LastName))
                {
                    Console.WriteLine("Last name: ");
                    LastName = Console.ReadLine();
                }
                string Email = String.Empty;
                while (Validator.FieldIsEmpty(Email) || !Validator.EmailIsValid(Email))
                {
                    Console.WriteLine("Email: ");
                    Email = Console.ReadLine();
                }
                string Address = String.Empty;
                while (Validator.FieldIsEmpty(Address))
                {
                    Console.WriteLine("Address: ");
                    Address = Console.ReadLine();
                }
                string PhoneNumber = String.Empty;
                while (Validator.FieldIsEmpty(PhoneNumber) || !Validator.PhoneNumberIsValid(PhoneNumber))
                {
                    Console.WriteLine("Please enter the client phone number: ");
                    PhoneNumber = Console.ReadLine();
                }
                Client NewClient = new Client(FirstName,  //Object creation whit all information collected.
                                              LastName,
                                              Email,
                                              Address,
                                              PhoneNumber);
                Console.Write(NewClient.ToString());
                Console.WriteLine("\n################################");
                Console.WriteLine("\nENTER or q?");
            }
        }
    }
}