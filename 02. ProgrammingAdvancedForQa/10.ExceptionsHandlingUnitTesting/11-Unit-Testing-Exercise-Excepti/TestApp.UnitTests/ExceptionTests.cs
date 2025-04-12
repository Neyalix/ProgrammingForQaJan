using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new();
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "Hello";
        string expected = "olleH";

        // Act
        string actual = _exceptions.ArgumentNullReverse(input);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;

        // Act & Assert
        Assert.That(() => _exceptions .ArgumentNullReverse(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        // Arrange
        decimal discount = 10;
        decimal totalPrice = 100;
        decimal expected = 90;

        // Act
        decimal actual = _exceptions.ArgumentCalculateDiscount(totalPrice, discount);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal discount = -5;
        decimal totalPrice = 100;

        // Act & Assert
        Assert.That(() => _exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = 110.0m;

        // Act & Assert
        //Assert.That(() => _exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
        Assert.Throws<ArgumentException>(() => _exceptions.ArgumentCalculateDiscount(totalPrice, discount));
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        // Arramge
        int[] array = { 10, 20, 30, 40, 50 };
        int index = 2;
        int expected = 30;
        // Act
        int actual = _exceptions.IndexOutOfRangeGetElement(array, index);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = -2;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.That(() => _exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = 5;

        // Act & Assert
        Assert.That(() => _exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        // Arrange
        bool input = true;
        string expected = "User logged in.";
        // Act
        string actual = _exceptions.InvalidOperationPerformSecureOperation(input);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        // Arrange
        bool input = false;
        string expected = "User must be logged in to perform this operation.";
        // Act & Assert

        var ex  = Assert.Throws<InvalidOperationException>(() => _exceptions.InvalidOperationPerformSecureOperation(input));

        Assert.That(ex.Message, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        // Arrange
        string inpit = "5";
        int expected = 5;
        // Act
        int actual = _exceptions.FormatExceptionParseInt(inpit);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));

    }

    [TestCase("dog")]
    [TestCase("5.5")]
    [TestCase("5b")]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException(string input)
    {
        // Act & Assert
        Assert.That(() => _exceptions.FormatExceptionParseInt(input), Throws.TypeOf<FormatException>());
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int>()
        {
            ["one"] = 1,
            ["two"] = 2,
            ["three"] = 3
        };
        string key = "two";
        int expected = 2;

        // Act
        int actual = _exceptions.KeyNotFoundFindValueByKey(input, key);
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        // Arrange
        Dictionary<string, int> input = new Dictionary<string, int>()
        {
            ["one"] = 1,
            ["two"] = 2,
            ["three"] = 3
        };
        string key = "four";
        string expected = "The specified key was not found in the dictionary.";
        // Act & Arrange

        var ex = Assert.Throws<KeyNotFoundException>(() => _exceptions.KeyNotFoundFindValueByKey(input, key));

        Assert.That(ex.Message, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        int a = 5;
        int b = 6;
        int expected = 11;

        int actual = _exceptions.OverflowAddNumbers(a, b);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        int a = int.MaxValue;
        int b = 6;

        string expected = "Arithmetic overflow occurred during addition.";

        Assert.That(() => _exceptions.OverflowAddNumbers(a, b), Throws.TypeOf<OverflowException>());

        try
        {
            _exceptions.OverflowAddNumbers(a, b);

        }
        catch (OverflowException ex)
        {

            Assert.That(ex.Message, Is.EqualTo(expected));
        }
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        int a = int.MinValue;
        int b = -1;

        string expected = "Arithmetic overflow occurred during addition.";

        Assert.That(() => _exceptions.OverflowAddNumbers(a, b), Throws.TypeOf<OverflowException>());

        try
        {
            _exceptions.OverflowAddNumbers(a, b);

        }
        catch (OverflowException ex)
        {

            Assert.That(ex.Message, Is.EqualTo(expected));
        }
    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        int a = 9;
        int b = 3;
        int expected = 3;

        int actual = _exceptions.DivideByZeroDivideNumbers(a, b);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        int a = 9;
        int b = 0;
       string expected = "Division by zero is not allowed.";

        Assert.That(() => _exceptions.DivideByZeroDivideNumbers(a, b), Throws.TypeOf<DivideByZeroException>());

        try
        {
            _exceptions.DivideByZeroDivideNumbers(a, b);
        }
        catch (DivideByZeroException ex)
        {

            Assert.That(ex.Message, Is.EqualTo(expected));
        }
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        int[] input = new int[] { 10, 20, 30, 40, 50 };
        int index = 2;
        int expected = 150;

        int actual = _exceptions.SumCollectionElements(input, index);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        int[] input = null;
        int index = 6;
        string expected = "Collection cannot be null.";

        Assert.That(() => _exceptions.SumCollectionElements(input, index), Throws.TypeOf<ArgumentNullException>());

        try
        {
            _exceptions.SumCollectionElements(input, index);
        }
        catch (ArgumentNullException ex)
        {

            Assert.That(ex.Message.StartsWith(expected));
        }

    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        int[] input = new int[] { 10, 20, 30, 40, 50 };
        int index = 6;

        string expected = "Index has to be within bounds.";

        Assert.That(() => _exceptions.SumCollectionElements(input, index), Throws.TypeOf<IndexOutOfRangeException>());

        try
        {
            _exceptions.SumCollectionElements(input, index);
        }
        catch (IndexOutOfRangeException ex)
        {

            Assert.That(ex.Message, Is.EqualTo(expected));
        }
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        // TODO: finish test
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        // TODO: finish test
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        // TODO: finish test
    }
}
