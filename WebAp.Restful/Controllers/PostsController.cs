using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebAp.Restful.Contracts;

namespace WebAp.Restful.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostsController : Controller
    {
        private readonly IPostService _postService;
        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            var result = await _postService.GetAll();
            return Ok(result);    
        }
    }
}
