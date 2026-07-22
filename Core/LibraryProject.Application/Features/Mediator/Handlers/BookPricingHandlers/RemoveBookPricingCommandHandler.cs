using LibraryProject.Application.Features.Mediator.Commands.BookCommands;
using LibraryProject.Application.Features.Mediator.Commands.BookPricingCommands;
using LibraryProject.Application.Interfaces;
using LibraryProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Handlers.BookPricingHandlers
{
	public class RemoveBookPricingCommandHandler : IRequestHandler<RemoveBookPricingCommand>
	{
		private readonly IRepository<BookPricing> _repository;

		public RemoveBookPricingCommandHandler(IRepository<BookPricing> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveBookPricingCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			await _repository.RemoveAsync(values);
		}
	}
}
