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
	public class CreateBookPricingCommandHandler : IRequestHandler<CreateBookPricingCommand>
	{
		private readonly IRepository<BookPricing> _repository;

		public CreateBookPricingCommandHandler(IRepository<BookPricing> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateBookPricingCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new BookPricing
			{
				Amount = request.Amount,
				BookID = request.BookID
			});
		}
	}
}
