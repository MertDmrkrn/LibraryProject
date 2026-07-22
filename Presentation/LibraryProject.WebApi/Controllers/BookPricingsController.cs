using LibraryProject.Application.Features.Mediator.Commands.BookPricingCommands;
using LibraryProject.Application.Features.Mediator.Queries.BookPricingQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookPricingsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public BookPricingsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> GetBookPricing()
		{
			var values = await _mediator.Send(new GetBookPricingQuery());
			return Ok(values);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetBookPricingById(int id)
		{
			var values = await _mediator.Send(new GetBookPricingByIdQuery(id));
			return Ok(values);
		}

		[HttpPost]
		public async Task<IActionResult> CreateBookPricing(CreateBookPricingCommand command)
		{
			await _mediator.Send(command);
			return Ok("Ekleme İşlemi Gerçekleştirildi.");	
		}

		[HttpDelete]
		public async Task<IActionResult> RemoveBookPricing(int id)
		{
			await _mediator.Send(new RemoveBookPricingCommand(id));
			return Ok("Silme İşlemi Gerçekleştirildi.");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateBookPricing(UpdateBookPricingCommand command)
		{
			await _mediator.Send(command);
			return Ok("Güncelleme İşlemi Gerçekleştirildi.");
		}
	}
}
