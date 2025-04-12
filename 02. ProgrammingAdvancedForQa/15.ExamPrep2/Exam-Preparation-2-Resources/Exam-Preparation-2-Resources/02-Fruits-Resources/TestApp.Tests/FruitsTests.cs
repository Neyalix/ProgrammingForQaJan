using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int>
        {
            {"apple", 35 },
            {"orange", 5 },
            {"pear", 13 }
        };
        string key = "pear";
        int expected = 13;

        // ACt
        int actual = Fruits.GetFruitQuantity(input, key);
        // Assert

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int>
        {
            {"apple", 35 },
            {"orange", 5 }

        };
        string key = "Invalid name";
        int expected = 0;

        // ACt
        int actual = Fruits.GetFruitQuantity(input, key);
        // Assert

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int>{};
        string key = "Invalid name";
        int expected = 0;

        // ACt
        int actual = Fruits.GetFruitQuantity(input, key);
        // Assert

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> input = null;
        string key = "Invalid name";
        int expected = 0;

        // ACt
        int actual = Fruits.GetFruitQuantity(input, key);
        // Assert

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int>
        {
            {"apple", 35 },
            {"orange", 5 },
            {"pear", 13 }
        };
        string key = null;
        int expected = 0;

        // ACt
        int actual = Fruits.GetFruitQuantity(input, key);
        // Assert

        Assert.That(actual, Is.EqualTo(expected));
    }
}
