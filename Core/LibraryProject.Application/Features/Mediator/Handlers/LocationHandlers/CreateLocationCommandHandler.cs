using LibraryProject.Application.Features.Mediator.Commands.LocationCommands;
using LibraryProject.Application.Interfaces;
using LibraryProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Handlers.LocationHandlers
{
	public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommand>
	{
		private readonly IRepository<Location> _repository;

		public CreateLocationCommandHandler(IRepository<Location> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateLocationCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new Location
			{
				LocationAddress = request.LocationAddress,
				LocationName = request.LocationName,
				LocationMail = request.LocationMail,
				LocationPhone = request.LocationPhone
			});
		}
	}
}
