using Retail.COMMON;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Retail.BL
{
    public abstract class RoleBase
    {
        public bool IsNew { get { return false; } set { IsNew = value; } }
        public bool HasChange { get { return false; } set { HasChange = value; } }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public string Gender { get; set; }


        public string FullName
        {
            get {
                return StringManipulation.GetFullName(FirstName,LastName);
            }

        }

    

        public bool ValidateProperties() {
            bool IsValid = true;

            if(string.IsNullOrWhiteSpace(FirstName)) IsValid=false;
            if (string.IsNullOrWhiteSpace(LastName)) IsValid = false;
            if (string.IsNullOrWhiteSpace(HomeAddress)) IsValid = false;
            if (string.IsNullOrWhiteSpace(Gender)) IsValid = false;
            if (string.IsNullOrWhiteSpace(FirstName)) IsValid = false;
            if (string.IsNullOrWhiteSpace(Email) || StringManipulation.ValidateEmail(Email)) IsValid = false;

            return IsValid;
        }
    }
}
