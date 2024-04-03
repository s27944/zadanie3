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
}