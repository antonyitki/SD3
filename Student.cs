using System;

namespace Coursework_1{
    public class Person { //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IDStudent { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public virtual string Greeting() => ("Initial Hello");
    }
    public class Student : Person { //Student class derides from Person class
        public Student(string FirstName, string LastName, string IDStudent, string Email, string Address, string PhoneNumber) {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IDStudent = IDStudent;
            this.Email = Email;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
        }
        public override string Greeting(){
            base.Greeting();
            return ("\nStudent is saying HI!\n\n");
        }
        public override string ToString() //call from Main
        {
            return "FirstName: " + FirstName + "\n" +
                "LastName: " + LastName + "\n" +
                "ID: " + IDStudent + "\n" +
                "Email: " + Email + "\n" +
                "Address: " + Address + "\n" +
                "PhoneNumber: " + PhoneNumber + 
                "\n#######Greeing:#######" + "\n"+
                Greeting(); //this.Greeting();    
        }
    }
}
