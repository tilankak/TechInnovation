using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.DatabaseContext;
using WebApi.Model;

namespace WebApi.Controllers
{
    
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly DataContext _dbcontext;
        public OrderController(DataContext dataContext)
        {
            _dbcontext = dataContext;
        }

        [HttpGet]
        [Route("GetOrders")]
        public async Task<IActionResult> GetOrders()
        { return Ok(_dbcontext.Orders.ToList()); }


        [HttpPost]
        [Route("SaveOrders")]
        public async Task<IActionResult> SaveOrder(Order order)
        {
            order.Id = Guid.NewGuid();
            _dbcontext.Orders.Add(order);
            return Ok(_dbcontext.SaveChanges());

        }
    }
}
