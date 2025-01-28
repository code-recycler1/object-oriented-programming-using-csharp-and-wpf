using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingExercises_Models;

namespace UnitTestingExercises_UnitTests
{
    [TestClass]
    public class TrainTests
    {
        // Acceleration Tests
        [TestMethod]
        public void Accelerate_DoorsClosed_SpeedIncreases()
        {
            // Arrange
            Train train = new Train();
            train.CloseDoors();

            // Act
            bool result = train.Accelerate(50);

            // Assert
            Assert.IsTrue(result, "Acceleration should succeed if doors are closed.");
            Assert.AreEqual(50, train.Speed, "Speed should increase by 50.");
        }

        [TestMethod]
        public void Accelerate_DoorsOpen_SpeedUnchanged()
        {
            // Arrange
            Train train = new Train();

            // Act
            bool result = train.Accelerate(50);

            // Assert
            Assert.IsFalse(result, "Acceleration should fail if doors are open.");
            Assert.AreEqual(0, train.Speed, "Speed should remain unchanged.");
        }

        [TestMethod]
        public void Accelerate_ExceedsMaxSpeed_SpeedCappedAt120()
        {
            // Arrange
            Train train = new Train();
            train.CloseDoors();

            // Act
            train.Accelerate(200);

            // Assert
            Assert.AreEqual(120, train.Speed, "Speed should not exceed 120.");
        }

        // Braking Tests
        [TestMethod]
        public void Decelerate_SpeedReduces()
        {
            // Arrange
            Train train = new Train();
            train.CloseDoors();
            train.Accelerate(50);

            // Act
            train.Decelerate(20);

            // Assert
            Assert.AreEqual(30, train.Speed, "Speed should decrease by 20.");
        }

        [TestMethod]
        public void Decelerate_SpeedBelowZero_CappedAtZero()
        {
            // Arrange
            Train train = new Train();
            train.CloseDoors();
            train.Accelerate(50);

            // Act
            train.Decelerate(100);

            // Assert
            Assert.AreEqual(0, train.Speed, "Speed should not go below 0.");
        }

        // Disembarking Tests
        [TestMethod]
        public void Disembark_DoorsOpen_PassengersDecrease()
        {
            // Arrange
            Train train = new Train();
            train.Embark(10);

            // Act
            bool result = train.Disembark(5);

            // Assert
            Assert.IsTrue(result, "Disembarking should succeed if doors are open.");
            Assert.AreEqual(5, train.Passengers, "Passengers should decrease by 5.");
        }

        [TestMethod]
        public void Disembark_DoorsClosed_PassengersUnchanged()
        {
            // Arrange
            Train train = new Train();
            train.Embark(10);
            train.CloseDoors();

            // Act
            bool result = train.Disembark(5);

            // Assert
            Assert.IsFalse(result, "Disembarking should fail if doors are closed.");
            Assert.AreEqual(10, train.Passengers, "Passengers should remain unchanged.");
        }

        // Boarding Tests
        [TestMethod]
        public void Embark_DoorsOpen_PassengersIncrease()
        {
            // Arrange
            Train train = new Train();

            // Act
            bool result = train.Embark(5);

            // Assert
            Assert.IsTrue(result, "Boarding should succeed if doors are open.");
            Assert.AreEqual(5, train.Passengers, "Passengers should increase by 5.");
        }

        [TestMethod]
        public void Embark_DoorsClosed_PassengersUnchanged()
        {
            // Arrange
            Train train = new Train();
            train.CloseDoors();

            // Act
            bool result = train.Embark(5);

            // Assert
            Assert.IsFalse(result, "Boarding should fail if doors are closed.");
            Assert.AreEqual(0, train.Passengers, "Passengers should remain unchanged.");
        }

        // Closing Doors Tests
        [TestMethod]
        public void CloseDoors_WhenCalled_DoorsClosed()
        {
            // Arrange
            Train train = new Train();

            // Act
            train.CloseDoors();

            // Assert
            Assert.IsFalse(train.DoorsOpen, "Doors should be closed.");
        }

        // Stopping Tests
        [TestMethod]
        public void Stop_WhenCalled_SpeedZeroAndDoorsOpen()
        {
            // Arrange
            Train train = new Train();
            train.CloseDoors();
            train.Accelerate(50);

            // Act
            train.Stop();

            // Assert
            Assert.AreEqual(0, train.Speed, "Speed should be 0.");
            Assert.IsTrue(train.DoorsOpen, "Doors should be open.");
        }
    }
}