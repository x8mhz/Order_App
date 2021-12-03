using OrderApp.Models;
using System;
using Xunit;

namespace OrderApp.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            // Arrange
            User user = new User("x8mhz", "xfabricio@hotmail.com", "12344");

            // Act
            var login = user.Login(user.Email, user.Password);

            // Assert
            Assert.True(login == true);
        }
    }
}
