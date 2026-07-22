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
	public class UpdateBookPricingCommandHandler : IRequestHandler<UpdateBookPricingCommand>
	{
		private readonly IRepository<BookPricing> _repository;

		public UpdateBookPricingCommandHandler(IRepository<BookPricing> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateBookPricingCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.BookPricingID);
			values.Amount = request.Amount;
			values.BookID = request.BookID;
			await _repository.UpdateAsync(values);
		}
	}
}
