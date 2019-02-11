using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogAttributeTesting.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProfileController : ControllerBase
    {
        // GET api/profile
        [HttpGet]
        public ActionResult<string> GetProfile()
        {
            return "Closed endpoint only authenticated users can call";
        }
    }
}
