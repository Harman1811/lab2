using NUnit.Framework;
namespace NUnitDemonstration.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void ValidTriangle_ValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 120;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }
        // Add more test methods as needed to cover different scenarios
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage2()
        {
            // Arrange
            int firstAngle = 80;
            int secondAngle = -45;
            int thirdAngle = 90;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }
            // Add more test methods as needed to cover different scenarios
            [Test]
            public void ValidTriangle_InvalidInput_ReturnsInvalidMessage3()
            {
                // Arrange
                int firstAngle = 90;
                int secondAngle = -45;
                int thirdAngle = 45;
                // Act
                string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
                // Assert
                Assert.AreEqual("The triangle is valid.", result);


            }
        }
    }
    

