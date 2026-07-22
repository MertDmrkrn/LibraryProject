using LibraryProject.Application.Features.Mediator.Queries.BookPricingQueries;
using LibraryProject.Application.Features.Mediator.Results.BookPricingResults;
using LibraryProject.Application.Features.Mediator.Results.BookResults;
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
	public class GetBookPricingByIdQueryHandler : IRequestHandler<GetBookPricingByIdQuery, GetBookPricingByIdQueryResult>
	{
		private readonly IRepository<BookPricing> _repository;

		public GetBookPricingByIdQueryHandler(IRepository<BookPricing> repository)
		{
			_repository = repository;
		}

		public async Task<GetBookPricingByIdQueryResult> Handle(GetBookPricingByIdQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			return new GetBookPricingByIdQueryResult
			{
				Amount = values.Amount,
				BookID = values.BookID,
				BookPricingID = values.BookPricingID
			};
		}
	}
}
