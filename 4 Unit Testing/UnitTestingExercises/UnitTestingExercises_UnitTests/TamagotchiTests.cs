using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingExercises_Models;

namespace UnitTestingExercises_UnitTests
{
    [TestClass]
    public class TamagotchiTests
    {
        // Feed Tests
        [TestMethod]
        public void Feed_PositiveUnits_HungerIncreases()
        {
            // Arrange
            Tamagotchi tamagotchi = new Tamagotchi("Test");

            // Act
            tamagotchi.Feed(5);

            // Assert
            Assert.AreEqual(8, tamagotchi.Hunger, "Hunger should increase by 3.");
        }

        [TestMethod]
        public void Feed_NegativeUnits_HungerIncreases()
        {
            // Arrange
            Tamagotchi tamagotchi = new Tamagotchi("Test");

            // Act
            tamagotchi.Feed(-5);

            // Assert
            Assert.AreEqual(8, tamagotchi.Hunger, "Hunger should increase by 3.");
        }

        // Pet Tests
        [TestMethod]
        public void Pet_WhenCalled_WellBeingIncreases()
        {
            // Arrange
            Tamagotchi tamagotchi = new Tamagotchi("Test");

            // Act
            tamagotchi.Pet();

            // Assert
            Assert.AreEqual(6, tamagotchi.WellBeing, "WellBeing should increase by 1.");
        }

        // Punish Tests
        [TestMethod]
        public void Punish_WhenCalled_WellBeingDecreases()
        {
            // Arrange
            Tamagotchi tamagotchi = new Tamagotchi("Test");

            // Act
            tamagotchi.Punish(5);

            // Assert
            Assert.AreEqual(0, tamagotchi.WellBeing, "WellBeing should decrease by 5.");
        }

        // Feeling Tests
        [TestMethod]
        public void Feeling_WhenCalled_ReturnsCorrectString()
        {
            // Arrange
            Tamagotchi tamagotchi = new Tamagotchi("Test");

            // Act
            string result = tamagotchi.Feeling();

            // Assert
            Assert.AreEqual("Feeling = 4 - Hunger = 5", result, "Feeling string should match expected output.");
        }
    }
}