using System.Security.Cryptography;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        //Arrange
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Product Inventory:");
        sb.AppendLine($"Laptop - Price: $1200.99 - Quantity: 3");

        string expected = sb.ToString().Trim();
        //Act
        _inventory.AddProduct("Laptop", 1200.993, 3);
        string actual = _inventory.DisplayInventory();


        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        //Arrange
        string expected = "Product Inventory:";
        //Act
        string actual = _inventory.DisplayInventory();
        //Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        //Arrange
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Product Inventory:");
        sb.AppendLine($"Laptop - Price: $1200.99 - Quantity: 3");
        sb.AppendLine($"Desktop - Price: $3200.59 - Quantity: 5");
        sb.AppendLine($"Phone - Price: $999.99 - Quantity: 10");

        string expected = sb.ToString().Trim();

        //Act
        _inventory.AddProduct("Laptop", 1200.993, 3);
        _inventory.AddProduct("Desktop", 3200.591, 5);
        _inventory.AddProduct("Phone", 999.99333, 10);

        string actual = _inventory.DisplayInventory();
        //Assert

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // TODO: finish the test
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // TODO: finish the test
    }
}
