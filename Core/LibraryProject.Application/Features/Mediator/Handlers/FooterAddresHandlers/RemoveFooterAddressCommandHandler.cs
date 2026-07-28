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
	public class RemoveFooterAddressCommandHandler : IRequestHandler<RemoveFooterAddressCommand>
	{
		private readonly IRepository<FooterAddress> _repository;

		public RemoveFooterAddressCommandHandler(IRepository<FooterAddress> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveFooterAddressCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			await _repository.RemoveAsync(values);
		}
	}
}
