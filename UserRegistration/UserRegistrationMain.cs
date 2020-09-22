namespace UserRegistration
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// Main Class
    /// </summary>
    public class UserRegistrationMain
    {
        public readonly string NAMEPATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public readonly string EMAILPATTERN = "^[a-zA-Z0-9]+([.][a-zA-Z0-9]+)?@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2})?$";
        public readonly string PHONEPATTERN = "^([0-9]{2}[ ]+)?[0-9]{10}$";
        public readonly string PASSWORDPATTERN = "^([A-Z]{1,})*([(@#$*)-])*[a-zA-Z0-9]{6,}$";

        /// <summary>
        /// Method to validate first name
        /// </summary>
        /// <param name="firstName">first name to validate</param>
        /// <returns>valid or invalid.</returns>
        public bool FirstNameValidator(string firstName)
        {
            return Regex.Match(firstName, this.NAMEPATTERN).Success;
        }

        /// <summary>
        /// Method to validate last name
        /// </summary>
        /// <param name="lastName">last name to validate</param>
        /// <returns>valid or invalid.</returns>
        public bool LastNameValidator(string lastName)
        {
            return Regex.Match(lastName, this.NAMEPATTERN).Success;
        }

        /// <summary>
        /// Method to validate email
        /// </summary>
        /// <param name="email">email to validate</param>
        /// <returns>valid or invalid.</returns>
        public bool EmailValidator(string email)
        {
            return Regex.Match(email, this.EMAILPATTERN).Success;
        }

        /// <summary>
        /// Method to validate phone no
        /// </summary>
        /// <param name="mobile">phone no to validate</param>
        /// <returns>valid or invalid.</returns>
        public bool MobileValidator(string mobile)
        {
            return Regex.Match(mobile, this.PHONEPATTERN).Success;
        }

        /// <summary>
        /// Method to validate password rule 1
        /// </summary>
        /// <param name="password"> password to validate</param>
        /// <returns>valid or invalid.</returns>    
        public bool PasswordValidator(string password)
        {
            return Regex.Match(password, this.PASSWORDPATTERN).Success;
        }
    }
}
