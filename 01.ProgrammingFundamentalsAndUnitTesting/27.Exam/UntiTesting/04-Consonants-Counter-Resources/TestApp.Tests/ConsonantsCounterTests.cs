using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.Tests
{
    [TestFixture]
    public class ConsonantsCounterTests
    {
        [Test]
        public void Test_CountTotalConsonants_GetEmptyList_ReturnsZero()
        {
            //Arrange
            List<string> input = new List<string> {};
            int expected = 0;
            //Act
            int actual = ConsonantsCounter.CountTotalConsonants(input);
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_CountTotalConsonants_GetListWithEmptyStringValues_ReturnsZero()
        {
            //Arrange
            List<string> input = new List<string> {string.Empty};
            int expected = 0;
            //Act
            int actual = ConsonantsCounter.CountTotalConsonants(input);
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_CountTotalConsonants_MultipleStrings_ReturnsConsonantsCount()
        {
            //Arrange
            List<string> input = new List<string> {"b", "c", "d"};
            int expected = 3;

            //Act
            int actual = ConsonantsCounter.CountTotalConsonants(input);
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_CountTotalConsonants_GetStringsWithNoConsonants_ReturnsZero()
        {
            //Arrange
            List<string> input = new List<string> {"a", "o", "i"};
            int expected = 0;
            //Act
            int actual = ConsonantsCounter.CountTotalConsonants(input);
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_CountTotalConsonants_StringsWithMixedCaseConsonants_ReturnsConsonantsCount()
        {
            //Arrange
            List<string> input = new List<string> { "b", "C", "d", "F" };
            int expected = 4;

            //Act
            int actual = ConsonantsCounter.CountTotalConsonants(input);
            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }

}

