using BikeEShop.Domain;
using System;
using Xunit;

namespace BikeEShop.Tests
{
    public class TestClassTest
    {
        [Fact]
        public void Hello_Returns_False_String()
        {
            //Arrange
            var t = new TestClass();
            //Act
            var result = t.Hello;
            //Assert
            Assert.NotEqual("helloo", result);
            
        }
    }
}
