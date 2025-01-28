using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingExercises_Models;

namespace UnitTestingExercises_UnitTests
{
    [TestClass]
    public class SwimmingPoolTests
    {
        // CalculateVolume Tests
        [TestMethod]
        public void CalculateVolume_ValidDimensions_ReturnsCorrectVolume()
        {
            // Arrange
            SwimmingPool pool = new SwimmingPool();
            pool.Depth = 2.5;
            pool.Length = 10;
            pool.Width = 5;
            pool.EdgeDistance = 0.2;

            // Act
            double volume = pool.CalculateVolume();

            // Assert
            Assert.AreEqual(115000, volume, "Volume should be 115,000 liters.");
        }

        // EdgeDistance Tests
        [TestMethod]
        public void EdgeDistance_SetLessThanDepth_RetainsValue()
        {
            // Arrange
            SwimmingPool pool = new SwimmingPool();
            pool.Depth = 2.5;

            // Act
            pool.EdgeDistance = 0.2;

            // Assert
            Assert.AreEqual(0.2, pool.EdgeDistance, "Edge distance should retain the provided value.");
        }

        [TestMethod]
        public void EdgeDistance_SetGreaterThanDepth_ResetsToZero()
        {
            // Arrange
            SwimmingPool pool = new SwimmingPool();
            pool.Depth = 2.5;

            // Act
            pool.EdgeDistance = 3;

            // Assert
            Assert.AreEqual(0, pool.EdgeDistance, "Edge distance should reset to 0 if it exceeds the depth.");
        }

        // Depth, Width, Length Tests
        [TestMethod]
        public void Depth_SetNegativeValue_ResetsToZero()
        {
            // Arrange
            SwimmingPool pool = new SwimmingPool();

            // Act
            pool.Depth = -1;

            // Assert
            Assert.AreEqual(0, pool.Depth, "Depth should reset to 0 if a negative value is provided.");
        }
    }
}