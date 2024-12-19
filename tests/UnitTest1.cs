using WebApplication1;
using WebApplication1.Controllers;

namespace tests
{
    public class UnitTest1
    {
        private readonly ProductsController _productsController;
        [Fact]
        public void Test1()
        {
            //Arrange
            var id = 1;

            //Act
            FakeData context = new FakeData();
            var controller = new ProductsController(context);
            var result = controller.Get(id);

            //Assert
            Assert.IsType<Product>(result);
        }
    }
}