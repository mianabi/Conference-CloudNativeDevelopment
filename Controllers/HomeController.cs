using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Conference.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController(IConfiguration configuration) : ControllerBase
    {
        private readonly IConfiguration _configuration = configuration;

        [HttpGet]
        public async Task<string> Get()
        {
            return _configuration["EnvironmentValue"];
        }
    }
}
