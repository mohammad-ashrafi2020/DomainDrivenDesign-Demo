using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok();
        }
    }
}
