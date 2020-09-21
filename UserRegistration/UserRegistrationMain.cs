namespace UserRegistration
{
    using System;
    using System.Text.RegularExpressions;

    public class UserRegistrationMain
    {
        public readonly string NAMEPATTERN = "^[A-Z]{1}[a-z]{2,}$";

        public bool FirstNameValidator(string firstName)
        {
            return Regex.Match(firstName, this.NAMEPATTERN).Success;
        }
        public bool LastNameValidator(string lastName)
        {
            return Regex.Match(lastName, this.NAMEPATTERN).Success;
        }
    }
}
