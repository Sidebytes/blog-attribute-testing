using BlogAttributeTesting.API.Controllers;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using Xunit;

namespace BlogAttributeTesting.Tests
{
    public class ControllerTests
    {
        [Fact]
        public void ProfileControllerHasTheAuthorizeAttribute()
        {
            // Act
            var attribute = typeof(ProfileController)
                .GetCustomAttributes(typeof(AuthorizeAttribute), false)
                .SingleOrDefault();

            // Assert
            Assert.NotNull(attribute);
        }

        [Fact]
        public void CreateNewsAtricleMethodHasTheAuthorizeAttribute()
        {
            // Act
            var attribute = typeof(NewsController)
                .GetMethod("CreateNewsArticle")
                .GetCustomAttributes(typeof(AuthorizeAttribute), false)
                .SingleOrDefault();

            // Assert
            Assert.NotNull(attribute);
        }
    }
}
