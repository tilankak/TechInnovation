using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.DatabaseContext;
using WebApi.Model;

namespace WebApi.Controllers
{
   
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _dbcontext;
        public UserController(DataContext dataContext)
        {
            _dbcontext = dataContext;
        }

        [HttpGet]
        [Route("GetUsers")]
        public async Task<IActionResult> GetUsers()
        { return Ok(_dbcontext.Users.ToList()); }


        [HttpPost]
        [Route("SaveUsers")]
        public async Task<IActionResult> SaveUser(User user)
        {
            user.Id = Guid.NewGuid();
            _dbcontext.Users.Add(user);
            return Ok(_dbcontext.SaveChanges());

        }
    }
}
