namespace UserRegistrationTest
{
    using NUnit.Framework;
    using System;
    using UserRegistration;
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
       
        [Test]
        public void GivenProperFirstName_ShouldReturnTrue()
        {
            UserRegistrationMain userRegistration = new UserRegistrationMain();
            Boolean result = userRegistration.FirstNameValidator("Parag");
            Assert.True(result);
        }
    }
}