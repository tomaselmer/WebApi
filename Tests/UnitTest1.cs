using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Get_ReturnsExpectedValue()
        {
            // Arrange
            //var mockService = new Mock<IMyService>();
            //mockService.Setup(service => service.GetSomething()).Returns("ExpectedValue");
            //var controller = new MyApiController(mockService.Object);

            //// Act
            //var result = controller.Get();

            //// Assert
            //var okResult = Assert.IsType<OkObjectResult>(result);
            //var returnValue = Assert.IsType<string>(okResult.Value);
            //Assert.Equal("ExpectedValue", returnValue);
        }
    }
}