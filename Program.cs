using System;

namespace Coursework_1{
    class Program{
        static void Main(string[] args){

            //Validate and store all client input values 
            string FirstName = String.Empty;
            while (Validator.FieldIsEmpty(FirstName))
            {
                Console.WriteLine("Enter the student first name: ");
                FirstName = Console.ReadLine();
            }

            string LastName = String.Empty;
            while (Validator.FieldIsEmpty(LastName))
            {
                Console.WriteLine("Please enter the student last name: ");
                LastName = Console.ReadLine();
            }

            string IDStudent = String.Empty;
            while (Validator.FieldIsEmpty(IDStudent) || !Validator.IDStudentValid(IDStudent))
            {
                Console.WriteLine("Enter the student ID: ");
                IDStudent = Console.ReadLine();
            }

            string Email = String.Empty;
            while (Validator.FieldIsEmpty(Email) || !Validator.EmailIsValid(Email))
            {
                Console.WriteLine("Please enter the student email: ");
                Email = Console.ReadLine();
            }

            string Address = String.Empty;
            while (Validator.FieldIsEmpty(Address))
            {
                Console.WriteLine("Enter the student address: ");
                Address = Console.ReadLine();
            }

            string PhoneNumber = String.Empty;
            while (Validator.FieldIsEmpty(PhoneNumber) || !Validator.PhoneNumberIsValid(PhoneNumber))
            {
                Console.WriteLine("Please enter the student phone number: ");
                PhoneNumber = Console.ReadLine();
            }

            //At this point we have all the required information, we can create our object! 
            Student NewStudent = new Student(FirstName,
                                          LastName,
                                          IDStudent,
                                          Email,
                                          Address,
                                          PhoneNumber);
            Console.WriteLine("\n\n###############################################");
            //Display the client with the ToString method 
            Console.Write(NewStudent.ToString());
        }  
    }
}

