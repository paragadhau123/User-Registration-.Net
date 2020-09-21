using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
   public class UserRegistrationMain
    {
        private String NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";

        public Boolean FirstNameValidator(String firstName)
        {
            return Regex.Match(firstName, NAME_PATTERN).Success;
        }
    }
}
