using NUnit.Framework;
using ProductAPI.Models;

namespace ProductAPI.Tests
{
    public class ProductTests
    {
        // [SetUp]
        // public void Setup()
        // {
        // }

        [Test]
        public void Test1()
        {
            // arrange
            var product = new Product{
                    ProductID = 1,
                    Name = "First Product",
                    Description = "No description"
                };
            var expected = "First Product";

            // act
            var actual = product.Name;

            // assert
            Assert.AreEqual(expected,actual);
        }
    }
}