using System;
using System.Text.RegularExpressions;

namespace Retail.COMMON
{
    public static class StringManipulation
    {
        public static string GetFullName(string FirstName, string LastName){
            if (!string.IsNullOrWhiteSpace(FirstName) || !string.IsNullOrWhiteSpace(LastName))
            {
                string trimmedFirstName = FirstName.Trim();
                string firstLetterOfTheFirstName = trimmedFirstName[0].ToString().ToUpper();
                string remainingCharactersOfTheFirstName = trimmedFirstName.Substring(1, trimmedFirstName.Length - 1);
                string firstName = firstLetterOfTheFirstName + remainingCharactersOfTheFirstName;

                string trimmedLastName = LastName.Trim();
                string firstLetterOfTheLastName = trimmedLastName[0].ToString().ToUpper();
                string remainingCharactersOfTheLastName = trimmedLastName.Substring(1, trimmedLastName.Length - 1);
                string lastName = firstLetterOfTheLastName + remainingCharactersOfTheLastName;

                return firstName + " " + lastName;
            }
            else
            {
                return "";
            }
        }

        public static bool ValidateEmail(string email) {
            bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            return isEmail;
        }
    }
}
