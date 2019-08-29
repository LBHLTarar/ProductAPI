using NUnit.Framework;
using ProductAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Tests
{
    public class ProductControllerTests
    {
        [Test]
        public void StatusCode200()
        {
            var controller = new ProductController();
            OkObjectResult products = (OkObjectResult)controller.GetAll();
            var status = products as OkObjectResult;
            Assert.AreEqual(200,status.StatusCode);
        }
    }
}