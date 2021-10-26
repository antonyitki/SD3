using System.Text.RegularExpressions; //header for regular expressions
namespace Coursework_1{
    public static class Validator{
        public static bool FieldIsEmpty(string Value){
            if (string.IsNullOrEmpty(Value))
                return true;
            return false;
        }
        public static bool PhoneNumberIsValid(string PhoneNumber){
            if (PhoneNumber.Length == 10 || PhoneNumber.Length == 11) //only 10 to 11 digits
                return true;
            return false;
        }
        public static bool EmailIsValid(string Email){
            if (Regex.IsMatch(Email, "^[^@]+@[^@]+\\.[^@]+$")) //@ and .
                return true;
            return false;
        }
        public static bool IDStudentValid(string IDStudent){
            if (IDStudent.Length == 11) //roehampton has 11 characters
                return true;
            return false;
        }
    }
}
