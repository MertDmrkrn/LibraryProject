using LibraryProject.Application.Features.Mediator.Commands.BlogCommands;
using LibraryProject.Application.Features.Mediator.Queries.BlogQueries;
using LibraryProject.Application.Features.Mediator.Results.BlogResults;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BlogsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public BlogsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> BlogList()
		{
			var values = await _mediator.Send(new GetBlogQuery());
			return Ok(values);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetBlog(int id)
		{
			var values = await _mediator.Send(new GetBlogByIdQuery(id));
			return Ok(values);
		}

		[HttpPost]
		public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
		{
			await _mediator.Send(command);
			return Ok("Ekleme işlemi gerçekleştirildi.");
		}

		[HttpDelete]
		public async Task<IActionResult> RemoveBlog(int id)
		{
			await _mediator.Send(new RemoveBlogCommand(id));
			return Ok("Silme işlemi gerçekleştirildi.");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
		{
			await _mediator.Send(command);
			return Ok("Güncelleme işlemi gerçekleştirildi.");
		}
	}
}
