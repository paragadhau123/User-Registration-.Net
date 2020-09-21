namespace UserRegistration
{
    using System;
    using System.Text.RegularExpressions;

    public class UserRegistrationMain
    {
        public readonly string NAMEPATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public readonly string EMAILPATTERN = "^[a-zA-Z0-9]+([.][a-zA-Z0-9]+)?@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2})?$";
        public readonly string PHONE_PATTERN = "^[1-9][0-9]+[ ]{1}+[1-9][0-9]{9}$";
        public bool FirstNameValidator(string firstName)
        {
            return Regex.Match(firstName, this.NAMEPATTERN).Success;
        }

        public bool LastNameValidator(string lastName)
        {
            return Regex.Match(lastName, this.NAMEPATTERN).Success;
        }

        public bool EmailValidator(string email)
        {
            return Regex.Match(email, this.EMAILPATTERN).Success;
        }

        public bool Mobile(string mobile)
        {
            return Regex.Match(mobile, PHONE_PATTERN).Success;
        }
    }
}
