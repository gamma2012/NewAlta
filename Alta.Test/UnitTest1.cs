using Alta.Controllers;
using Alta.DTOs;
using System;
using Xunit;

namespace Alta.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            AltaWSController controller = new AltaWSController();
            CreateLineInventoryDTO newdata = new CreateLineInventoryDTO();

            //Act
            var result = controller.CreateLineInventoryInIFD(newdata);

            //Assert
            Assert.NotNull(result);

        }
    }
}
