using System;

using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        // Arrange
        string title = "task1";
        DateTime dueDate = new DateTime(1993, 07, 16);
        string expected = "To-Do List:"
            + Environment.NewLine
            + $"[ ] task1 - Due: 07/16/1993";
        // Act
        _toDoList.AddTask(title, dueDate);
        string actual = _toDoList.DisplayTasks();
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        // Arrange
        string title = "task1";
        DateTime dueDate = new DateTime(1993, 07, 16);
        string expected = "To-Do List:"
            + Environment.NewLine
            + $"[✓] task1 - Due: 07/16/1993";
        // Act
        _toDoList.AddTask(title, dueDate);
        _toDoList.CompleteTask("TASK1");
        string actual = _toDoList.DisplayTasks();
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        // Arrange

        // Act & Assert
        Assert.That(() => _toDoList.CompleteTask("IVALID_TASK"), Throws.ArgumentException);
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        // Arrange
        string expected = "To-Do List:";
        // Act
        string actual = _toDoList.DisplayTasks();
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        // Arrange
        string expected = "To-Do List:"
            + Environment.NewLine
            + $"[ ] task1 - Due: 07/16/1993"
            + Environment.NewLine
            + $"[ ] task2 - Due: 01/07/1999";
        // Act
        _toDoList.AddTask("task1", new DateTime(1993, 07, 16));
        _toDoList.AddTask("task2", new DateTime(1999, 01, 07));
        string actual = _toDoList.DisplayTasks();
        // Assert
        Assert.That(actual, Is.EqualTo(expected));







































    }
}
