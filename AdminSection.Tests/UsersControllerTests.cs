using AdminSection.Controllers;
using AdminSection.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace AdminSection.Tests
{
    public class UsersControllerTests
    {
        [Fact]
        public void IndexReturnsAViewResultWithAListOfUsers()
        {
            // Arrange
            //var mock = new Mock<ApplicationContext>();
            //mock.Setup(repo => repo.Users).Returns(GetTestUsers());
            var options = new DbContextOptionsBuilder<ApplicationContext>()
              .UseInMemoryDatabase(databaseName: "Add_writes_to_database")
              .Options;

            using (var context = new ApplicationContext(options))
            {
                context.Users.Add(new User() { Id = "1", UserName = "TestUser1" });
                context.Users.Add(new User() { Id = "2", UserName = "TestUser2" });
                context.SaveChanges();

            }
            using (var context = new ApplicationContext(options))
            {
                var controller = new UsersController(context, null);
                // Act
                var result = controller.Index();
                // Assert
                var viewResult = Assert.IsType<ViewResult>(result);
                var model = Assert.IsAssignableFrom<IEnumerable<User>>(viewResult.Model);
                Assert.Equal(2, model.Count());
            }
        }     
    }
}
