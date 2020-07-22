using System;
using Xunit;
using SoftwareEssentials;
using SoftwareEssentials.Controllers;
using Microsoft.VisualStudio.TestPlatform;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc;


namespace SeTest
{
    public class ControllerTest
    {
        [Fact]
        public void Index()
        {
            //Arrange
            HomeController Controller = new HomeController();

            //Act
            ViewResult result = Controller.Index() as ViewResult;

            //Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void About()
        {
            //Arrange
            HomeController Controller = new HomeController();

            //Act
            ViewResult result = Controller.About() as ViewResult;

            //Assert
            Assert.Equal("Your application description page.");
        }
    }
}
