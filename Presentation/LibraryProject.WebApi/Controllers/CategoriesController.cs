using LibraryProject.Application.Features.Mediator.Commands.CategoryCommands;
using LibraryProject.Application.Features.Mediator.Queries.CategoryQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriesController : ControllerBase
	{
		private readonly IMediator _mediator;

		public CategoriesController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> CategoryList()
		{
			var values = await _mediator.Send(new GetCategoryQuery());
			return Ok(values);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetCategory(int id)
		{
			var values = await _mediator.Send(new GetCategoryByIdQuery(id));
			return Ok(values);
		}

		[HttpPost]
		public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
		{
			await _mediator.Send(command);
			return Ok("Ekleme işlemi gerçekleştirildi.");
		}

		[HttpDelete]
		public async Task<IActionResult> RemoveCategory(int id)
		{
			await _mediator.Send(new RemoveCategoryCommand(id));
			return Ok("Silme işlemi gerçekleştirildi.");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
		{
			await _mediator.Send(command);
			return Ok("Güncelleme işlemi gerçekleştirildi.");
		}
	}
}
