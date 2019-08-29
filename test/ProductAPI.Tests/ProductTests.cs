using NUnit.Framework;
using ProductAPI.Models;
using System.Collections.Generic;

namespace ProductAPI.Tests
{
    public class ProductTests
    {
        [Test]
        public void Test1()
        {
            var product = new Product();
            Assert.IsNull(product.Description);
        }

        [Test]
        public void Test2()
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

        [Test]
        public void Test3()
        {
            // arrange
            var product_list = new List<Product>{
                new Product {
                    ProductID = 1,
                    Name = "My First Product",
                    Description = "No description"
                },
                new Product {
                    ProductID = 2,
                    Name="My Second Product",
                    Description="No description"
                }
            };
            var expected = "My Second Product";

            // act
            var actual = product_list[1].Name;

            // assert
            Assert.AreEqual(expected,actual);
        }
    }
}