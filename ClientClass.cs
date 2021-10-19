namespace Coursework_1
{
    public class Client
    {
        public string FirstName { get; set; }
        public string LastdName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Client(string FirstName, string LastName,
            string Email, string Adress, string PhoneNumber)
        {
            this.FirstName = FirstName;
            this.LastdName = LastName;
            this.Email = Email;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
        }
        public Client()
        {
            FirstName = "Alex";
            LastdName = "See";
            Email = "global@gmail.com";
            Address = "Froebel Colege";
            PhoneNumber = "23456789";
        }
        public override string ToString()
        {
            return "FirstName: " + FirstName + "\n" +
                "LastName: " + LastdName + "\n" +
                "Email: " + Email + "\n" +
                "Address: " + Address + "\n" +
                "PhoneNumber: " + PhoneNumber;
        }
    }
}