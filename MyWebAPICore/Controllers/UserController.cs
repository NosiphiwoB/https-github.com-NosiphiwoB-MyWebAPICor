using Microsoft.AspNetCore.Mvc;

using MyWebAPICore.models;

namespace MyWebAPICore.Controllers
{
     [ApiController]
    [Route("[controller]")]

    public class UserController
    {
        public static List<Product> products = new List<Product>();



        [HttpGet(Name = "Product")]
        public List<Product> GetProduct()
        {
            return products;
        }

        [HttpPut(Name = "Product")]
        public List<Product> EditProduct()
        {
            return products;
        }

        

        [HttpPost()]
        public void PostProduct(Product product)
        {
            products.Add(product);
        }
        
    }
}