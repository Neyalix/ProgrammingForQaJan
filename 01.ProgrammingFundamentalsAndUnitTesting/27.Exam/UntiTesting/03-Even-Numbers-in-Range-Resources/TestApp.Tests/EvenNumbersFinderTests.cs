using NUnit.Framework;

namespace TestApp.Tests
{
    [TestFixture]
    public class EvenNumbersFinderTests
    {
        [Test]
        public void Test_FindEvenNumbers_StartGreaterThanEnd_ReturnsErrorMessage()
        {
            //Arrange
            int[] input = new int[] {10, 1};
            string expected = "Start number should not be greater than end number.";
            //Act
            string actual = EvenNumbersFinder.FindEvenNumbers(input[0], input[1]);
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_FindEvenNumbers_NoEvenNumbersInRange_ReturnsEmptyString()
        {
            //Arrange
            int[] input = new int[] { 23, 23 };
            string expected = string.Empty;

            //Act
            string actual = EvenNumbersFinder.FindEvenNumbers(input[0], input[1]);
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_FindEvenNumbers_SingleEvenNumberInRange_ReturnsThatNumber()
        {
            //Arrange
            int[] input = new int[] { 21, 23 };
            string expected = "22";
            //Act
            string actual = EvenNumbersFinder.FindEvenNumbers(input[0], input[1]);
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_FindEvenNumbers_MultipleEvenNumbersInRange_ReturnsEvenNumbers()
        {
            //Arrange
            int[] input = new int[] { 17, 23 };
            string expected = "18 20 22";
            //Act
            string actual = EvenNumbersFinder.FindEvenNumbers(input[0], input[1]);
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_FindEvenNumbers_ZeroInRange_ReturnsZero()
        {
            //Arrange
            int[] input = new int[] { 0, 0 };
            string expected = "0";
            //Act
            string actual = EvenNumbersFinder.FindEvenNumbers(input[0], input[1]);
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
