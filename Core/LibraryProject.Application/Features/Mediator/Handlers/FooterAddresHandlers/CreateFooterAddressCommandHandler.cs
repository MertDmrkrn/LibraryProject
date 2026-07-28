using LibraryProject.Application.Features.Mediator.Commands.FooterAddressCommands;
using LibraryProject.Application.Interfaces;
using LibraryProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Handlers.FooterAddresHandlers
{
	public class CreateFooterAddressCommandHandler : IRequestHandler<CreateFooterAddressCommand>
	{
		private readonly IRepository<FooterAddress> _repository;

		public CreateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateFooterAddressCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new FooterAddress
			{
				Address = request.Address,
				Description = request.Description,
				Mail = request.Mail,
				Phone = request.Phone
			});
		}
	}
}
