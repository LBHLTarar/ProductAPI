// using System;
using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        public ActionResult GetAll()
        {
            var productList= new List<Product>{
                new Product {
                    ProductID = 1,
                    Name = "My First Awesome Product",
                    Description = "This product doesn't have a description yet :P"
                },
                new Product {
                    ProductID = 2,
                    Name="My Second Awesome Product",
                    Description="This product doesn't have a description either :D"
                }
            };

            return Ok(productList);
        }
    }
}
