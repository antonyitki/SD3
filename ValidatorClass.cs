using System.Text.RegularExpressions;
namespace Coursework_1
{
    public static class Validator
    {
        public static bool FieldIsEmpty(string Value)
        {
            if (string.IsNullOrEmpty(Value))
                return true;
            return false;
        }
        public static bool PhoneNumberIsValid(string PhoneNumber)
        {
            if (PhoneNumber.Length == 10)
                return true;
            return false;
        }
        public static bool EmailIsValid(string Email)
        {
            if (Regex.IsMatch(Email, "^[^@]+@[^@]+\\.[^@]+$"))
                return true;
            return false;
        }
    }
}