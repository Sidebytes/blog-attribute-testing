using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogAttributeTesting.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        // GET api/news
        [HttpGet]
        public ActionResult<string> GetNewsArticle()
        {
            return "Open endpoint everyone can call";
        }

        // POST api/news
        [HttpPost]
        [Authorize]
        public ActionResult<string> CreateNewsArticle()
        {
            return "Closed endpoint only authenticated users can call";
        }
    }
}
