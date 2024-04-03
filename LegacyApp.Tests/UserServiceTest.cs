using System;
using JetBrains.Annotations;
using LegacyApp;
using Xunit;

namespace LegacyApp.Tests;

[TestSubject(typeof(UserService))]
public class UserServiceTest
{
    [Fact]
    public void AddUser_Should_Return_False_When_FirstName_Is_Missing()
    {
        //Arrange - tworzymy zaleznosci do testowania
        var userService = new UserService();
        //Act - wywolujemy testowana funkcjonalnosc
        var addResult = userService.AddUser("", "Doe", "johndoe@gmail.com",
            DateTime.Parse("1982-03-21"), 1);
        //Assert - sprawdzamy wynik
        //Assert.Equal(false, addResult);
        Assert.False(addResult);
    }

    [Fact]
    public void AddUser_Should_Return_False_When_Email_Is_Not_Correct()
    {
        //Arrange - tworzymy zaleznosci do testowania
        var userService = new UserService();
        //Act - wywolujemy testowana funkcjonalnosc
        var addResult = userService.AddUser("John", "Doe", "johndoegmailcom",
            DateTime.Parse("1982-03-21"), 1);
        //Assert - sprawdzamy wynik
        //Assert.Equal(false, addResult);
        Assert.False(addResult);
    }

    [Fact]
    public void AddUser_Should_Return_False_When_Under_Age()
    {
        //Arrange - tworzymy zaleznosci do testowania
        var userService = new UserService();
        //Act - wywolujemy testowana funkcjonalnosc
        var addResult = userService.AddUser("John", "Doe", "johndoe@gmail.com",
            DateTime.Parse("2015-03-21"), 1);
        //Assert - sprawdzamy wynik
        //Assert.Equal(false, addResult);
        Assert.False(addResult);
    }


    [Fact]
    public void AddUser_Should_Throw_ArgumentException_When_ClientId_Doesnt_Exist()
    {
        //Arrange - tworzymy zaleznosci do testowania
        var userService = new UserService();

        //Act and Assert
        Assert.Throws<ArgumentException>(() =>
        {
            userService.AddUser("John", "Doe", "johndoe@gmail.com",
                DateTime.Parse("1982-03-21"), 7);
        });
    }
    
    
    [Fact]
    public void AddUser_Should_Return_True_When_Doesnt_Have_Credit_Limit_And_Is_Higher_Than_500()
    {
        //Arrange - tworzymy zaleznosci do testowania
        var userService = new UserService();
        //Act - wywolujemy testowana funkcjonalnosc
        var addResult = userService.AddUser("John", "Doe", "johndoe@gmail.com",
            DateTime.Parse("1982-03-21"), 1);
        //Assert - sprawdzamy wynik
        //Assert.Equal(false, addResult);
        Assert.True(addResult);
    }
}