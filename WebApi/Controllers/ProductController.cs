using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO.Pipes;
using WebApi.DatabaseContext;
using WebApi.Model;

namespace WebApi.Controllers
{

    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _dbcontext;
        public ProductController(DataContext dataContext)
        {
            _dbcontext = dataContext;
        }

        [HttpGet]
        [Route("Getproducts")]
        public async Task<IActionResult> GetProducts()
        { return Ok(_dbcontext.Products.ToList()); }


        [HttpPost]
        [Route("SaveProducts")]
        public async Task<IActionResult> SaveProduct(Product product)
        {
            product.Id = Guid.NewGuid();
            _dbcontext.Products.Add(product);
            return Ok(_dbcontext.SaveChanges());

        }
    }
}
