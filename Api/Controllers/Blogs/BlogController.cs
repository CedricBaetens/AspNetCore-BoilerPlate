using System.Threading.Tasks;
using Application.Blogs.Commands;
using Application.Blogs.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Blogs
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BlogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new GetBlogsQuery());
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> Create()
        {
            var result = await _mediator.Send(new CreateBlogCommand());
            if (result.Failed)
                return BadRequest();
            return Ok(result);
        }
    }
}