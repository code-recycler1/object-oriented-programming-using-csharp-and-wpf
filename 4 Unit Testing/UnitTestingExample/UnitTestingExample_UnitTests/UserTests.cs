using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingExample_Models;

namespace UnitTestingExample_UnitTests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void Number_ValueIsGreaterThanZero_NumberIsEqualToValue()
        {
            // Arrange: Create a new User object
            User user = new User();

            // Act: Set the Number property to 15
            user.Number = 15;

            // Assert: Verify that the Number property is equal to 15
            Assert.AreEqual(15, user.Number);
        }

        [TestMethod]
        public void Number_ValueIsEqualToZero_NumberIsEqualToValue()
        {
            // Arrange: Create a new User object
            User user = new User();

            // Act: Set the Number property to 0
            user.Number = 0;

            // Assert: Verify that the Number property is equal to 0
            Assert.AreEqual(0, user.Number);
        }

        [TestMethod]
        public void Number_ValueIsLessThanZero_NumberIsEqualToZero()
        {
            // Arrange: Create a new User object
            User user = new User();

            // Act: Set the Number property to -14
            user.Number = -14;

            // Assert: Verify that the Number property is equal to 0
            Assert.AreEqual(0, user.Number);
        }

        [TestMethod]
        public void Clear_Clear_AllFieldsAreEmpty()
        {
            // Arrange: Create a new User object and set its properties
            User user = new User();
            user.Number = 1;
            user.LastName = "Doe";
            user.FirstName = "John";

            // Act: Call the Clear method
            user.Clear();

            // Assert: Verify that all fields are cleared
            Assert.AreEqual(0, user.Number);
            Assert.AreEqual("", user.LastName);
            Assert.AreEqual("", user.FirstName);
        }

        [TestMethod]
        public void FirstName_ValueIsNotEmpty_FirstNameIsEqualToValue()
        {
            // Arrange: Create a new User object
            User user = new User();

            // Act: Set the FirstName property to "John"
            user.FirstName = "John";

            // Assert: Verify that the FirstName property is equal to "John"
            Assert.AreEqual("John", user.FirstName);
        }
    }
}