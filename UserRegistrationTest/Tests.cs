namespace UserRegistrationTest
{
    using System;
    using NUnit.Framework;
    using UserRegistration;

    public class Tests
    {
      public readonly UserRegistrationMain UserRegistration = new UserRegistrationMain();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenProperFirstName_ShouldReturnTrue()
        {
            bool result = this.UserRegistration.FirstNameValidator("Parag");
            Assert.True(result);
        }

        [Test]
        public void GivenLessThanThreeCharacter_ShouldReturnFalse()
        {
            bool result = this.UserRegistration.FirstNameValidator("Pa");
            Assert.False(result);
        }

        [Test]
        public void GivenNumbersInFirstName_ShouldReturnFalse()
        {
            bool result = this.UserRegistration.FirstNameValidator("Pa324");
            Assert.False(result);
        }
    }
}