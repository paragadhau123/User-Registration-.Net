//-----------------------------------------------------------------------
// <copyright file="Tests.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace UserRegistrationTest
{
    using NUnit.Framework;
    using UserRegistration;

    /// <summary>
    /// Test Class
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// User Registration(Main class) object
        /// </summary>
        public readonly UserRegistrationMain UserRegistration = new UserRegistrationMain();

        /// <summary>
        ///  Method SetUp
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [Test]
        public void GivenProperFirstName_ShouldReturnTrue()
        {
            bool result = this.UserRegistration.FirstNameValidator("Parag");
            Assert.True(result);
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [Test]
        public void GivenLessThanThreeCharacter_ShouldReturnFalse()
        {
            bool result = this.UserRegistration.FirstNameValidator("Pa");
            Assert.False(result);
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [Test]
        public void GivenNumbersInFirstName_ShouldReturnFalse()
        {
            bool result = this.UserRegistration.FirstNameValidator("Pa324");
            Assert.False(result);
        }

        /// <summary>
        /// Test Method to validate first name
        /// </summary>
        [Test]
        public void GivenEmptyName_ShouldReturnFalse()
        {
            bool result = this.UserRegistration.FirstNameValidator(string.Empty);
            Assert.False(result);
        }

        /// <summary>
        /// Test Method to validate last name
        /// </summary>
        [Test]
        public void GivenProperLastName_ShouldReturnTrue()
        {
            bool result = this.UserRegistration.LastNameValidator("Adhau");
            Assert.True(result);
        }

        /// <summary>
        /// Test Method to validate last name
        /// </summary>
        [Test]
        public void GivenLessThanThreeCharacterInLastName_ShouldReturnFalse()
        {
            bool result = this.UserRegistration.LastNameValidator("Ad");
            Assert.False(result);
        }

        /// <summary>
        /// Test Method to validate last name
        /// </summary>
        [Test]
        public void GivenNumbersInLastName_ShouldReturnFalse()
        {
            bool result = this.UserRegistration.LastNameValidator("Adh123");
            Assert.False(result);
        }

        /// <summary>
        /// Test Method to validate Email
        /// </summary>
        [Test]
        public void GivenProperEmail_ShouldReturnTrue()
        {
            bool result = this.UserRegistration.EmailValidator("adhauparag@gmail.co.in");
            Assert.True(result);
        }

        /// <summary>
        /// Test Method to validate Email
        /// </summary>
        [Test]
        public void GivenProperEmail_WhileRemovingSomePart_ShouldReturnTrue()
        {
            bool result = this.UserRegistration.EmailValidator("adhauparag@");
            Assert.False(result);
        }

        /// <summary>
        /// Test Method to validate Email
        /// </summary>
        [Test]
        public void GivenWrongEmail_ByRemoving_AtTheRateSign_ShouldReturnFalse()
        {
            bool result = this.UserRegistration.EmailValidator("adhauparaggmail.com");
            Assert.False(result);
        }

        /// <summary>
        /// Test Method to validate Email
        /// </summary>
        [Test]
        public void GivenWrongEmail_StartsWithDot_ShouldReturnFalse()
        {
            bool result = this.UserRegistration.EmailValidator(".adhauparag@gmail.com");
            Assert.False(result);
        }

        /// <summary>
        /// Test Method to validate Email
        /// </summary>
        [Test]
        public void GivenEmptyEmail_ShouldReturnFalse()
        {
            bool result = this.UserRegistration.EmailValidator(string.Empty);
            Assert.False(result);
        }

        /// <summary>
        /// Test Method to validate Phone Number
        /// </summary>
        [Test]
        public void GivenProperMobileNumber_ShouldReturnTrue()
        {
            bool result = this.UserRegistration.MobileValidator("91 9604445258");
            Assert.True(result);
        }

        /// <summary>
        /// Test Method to validate Phone Number
        /// </summary>
        [Test]
        public void GivenStringFormat_ShouldReturnFalse()
        {
            bool result = this.UserRegistration.MobileValidator("abdc");
            Assert.False(result);
        }

        /// <summary>
        /// Test Method to validate Phone Number
        /// </summary>
        [Test]
        public void GivenLessNumberOfDigit_ShouldReturnFalse()
        {
            bool result = this.UserRegistration.MobileValidator("96044");
            Assert.False(result);
        }

        /// <summary>
        /// Test Method to validate Password
        /// </summary>
        [Test]
        public void GivenExactEightCharacterInPassword_ShouldReturnTrue()
        {
            bool result = this.UserRegistration.PasswordValidator("Paragadhau");
            Assert.True(result);
        }

        /// <summary>
        /// Test Method to validate Password
        /// </summary>
        [Test]
        public void GivenAtLeastOneCapitalLetter_AtTheBegining_ShouldReturnTrue()
        {
            bool result = this.UserRegistration.PasswordValidator("Manishadhau");
            Assert.True(result);
        }

        /// <summary>
        /// Test Method to validate Password
        /// </summary>
        [Test]
        public void GivenAtleastoneNumberInPassword_ShouldReturnTrue()
        {
            bool result = this.UserRegistration.PasswordValidator("Adhau54423sad");
            Assert.True(result);
        }

        /// <summary>
        /// Test Method to validate Password
        /// </summary>
        [Test]
        public void GivenExactlyOneSpecialCharacter_ShouldReturnTrue()
        {
            bool result = this.UserRegistration.PasswordValidator("P@arafd12");
            Assert.True(result);
        }

        /// <summary>
        /// Test Method to validate Password
        /// </summary>
        [Test]
        public void GivenMoreThanOneSpecialCharacter_ShouldReturnFalse()
        {
            bool result = this.UserRegistration.PasswordValidator("P@araf#d12");
            Assert.False(result);
        }
    }
}