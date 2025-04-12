using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        //Arrange
        string input = string.Empty;
        int rotations = 3;
        //Act
        string actual = StringRotator.RotateRight(input, rotations);
        //Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        //Arrange
        string input = "hero";
        int rotations = 0;
        string expected = "hero";

        //Act
        string actual = StringRotator.RotateRight(input, rotations);
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        //Arrange
        string input = "hero";
        int rotations = 2;
        string expected = "rohe";

        //Act
        string actual = StringRotator.RotateRight(input, rotations);
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        //Arrange
        string input = "hero";
        int rotations = -2;
        string expected = "rohe";

        //Act
        string actual = StringRotator.RotateRight(input, rotations);
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        //Arrange
        string input = "hop";
        int rotations = 5;
        string expected = "oph";

        //Act
        string actual = StringRotator.RotateRight(input, rotations);
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
