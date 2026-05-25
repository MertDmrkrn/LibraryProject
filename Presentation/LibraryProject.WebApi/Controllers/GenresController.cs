using LibraryProject.Application.Features.Mediator.Commands.GenreCommands;
using LibraryProject.Application.Features.Mediator.Queries.GenreQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GenresController : ControllerBase
	{
		private readonly IMediator _mediator;

		public GenresController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> GenreList()
		{
			var values = await _mediator.Send(new GetGenreQuery());
			return Ok(values);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetGenre(int id)
		{
			var values = await _mediator.Send(new GetGenreByIdQuery(id));
			return Ok(values);
		}

		[HttpPost]
		public async Task<IActionResult> CreateGenre(CreateGenreCommand command)
		{
			await _mediator.Send(command);
			return Ok("Ekleme işlemi gerçekleştirildi.");
		}

		[HttpDelete]
		public async Task<IActionResult> RemoveGenre(int id)
		{
			await _mediator.Send(new RemoveGenreCommand(id));
			return Ok("Silme işlemi gerçekleştirildi.");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateGenre(UpdateGenreCommand command)
		{
			await _mediator.Send(command);
			return Ok("Güncelleme işlemi gerçekleştirildi.");
		}
	}
}
