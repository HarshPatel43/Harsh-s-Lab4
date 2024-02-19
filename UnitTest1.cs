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



        //test2
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage()
        {
            // Add another test
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 50;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);

        }

        //test3
        // Add more test methods as needed to cover different scenarios
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage2()
        {
            // Arrange
            int firstAngle = 40;
            int secondAngle = 90;
            int thirdAngle = 60;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is invalid.", result);

        }
       
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage3()
        {
            // Arrange
            int firstAngle = 00;
            int secondAngle = 90;
            int thirdAngle = 70;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);

        }
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage4()
        {
            // Arrange
            int firstAngle = -60;
            int secondAngle = -60;
            int thirdAngle = 60;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is invalid.", result);

        }
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsInvalidMessage5()
        {
            // Arrange
            int firstAngle = 0;
            int secondAngle = 90;
            int thirdAngle = 90;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);

        }
    }
}