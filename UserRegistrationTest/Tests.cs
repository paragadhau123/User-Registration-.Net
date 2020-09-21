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

        [Test]
        public void GivenEmptyName_ShouldReturnFalse()
        {
            bool result = this.UserRegistration.FirstNameValidator("");
            Assert.False(result);
        }

        [Test]
        public void GivenProperLastName_ShouldReturnTrue()
        {
            bool result = this.UserRegistration.LastNameValidator("Adhau");
            Assert.True(result);
        }


        [Test]
        public void GivenLessThanThreeCharacterInLastName_ShouldReturnFalse()
        {
            bool result = this.UserRegistration.LastNameValidator("Adhau");
            Assert.False(result);
        }

        [Test]
        public void GivenNumbersInLastName_ShouldReturnFalse()
        {
            bool result = this.UserRegistration.LastNameValidator("Adh123");
            Assert.False(result);
        }
    }
}