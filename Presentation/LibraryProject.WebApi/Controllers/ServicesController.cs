using LibraryProject.Application.Features.Mediator.Commands.ServiceCommands;
using LibraryProject.Application.Features.Mediator.Queries.ServiceQueries;
using LibraryProject.Application.Features.Mediator.Results.ServiceResults;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServicesController : ControllerBase
	{
		private readonly IMediator _mediator;

		public ServicesController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> ServiceList()
		{
			var values = await _mediator.Send(new GetServiceQuery());
			return Ok(values);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetService(int id)
		{
			var values = await _mediator.Send(new GetServiceByIdQuery(id));
			return Ok(values);
		}

		[HttpPost]
		public async Task<IActionResult> CreateService(CreateServiceCommand command)
		{
			await _mediator.Send(command);
			return Ok("Ekleme işlemi gerçekleştirildi.");
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteService(int id)
		{
			await _mediator.Send(new RemoveServiceCommand(id));
			return Ok("Silme işlemi gerçekleştirildi.");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateService(UpdateServiceCommand command)
		{
			await _mediator.Send(command);
			return Ok("Güncelleme işlemi gerçekleştirildi.");
		}
	}
}
