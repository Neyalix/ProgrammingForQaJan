using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        // Arrange
        int[] input = null;


        // Act

        // Assert
        Assert.Throws<ArgumentNullException>(() => LongestIncreasingSubsequence.GetLis(input));
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        // Arrange
        int[] array = Array.Empty<int>();
        string expected = "";
        // Act
        string actual = LongestIncreasingSubsequence.GetLis(array);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        // Arrange
        int[] singleElement = new int[] { 1 };
        string expected = "1";
        // Act
        string actual = LongestIncreasingSubsequence.GetLis(singleElement);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        // Arrange
        int[] arr = { 10, 5, 4, 25, 14, 33, 50, 60 };
        string expected = "10 25 33 50 60";
        // Act
        string actual = LongestIncreasingSubsequence.GetLis(arr);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        // Arrange
        int[] arr = { 5, 6, 10, 25, 33, 50, 60 };
        string expected = "5 6 10 25 33 50 60";
        // Act
        string actual = LongestIncreasingSubsequence.GetLis(arr);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }
}
