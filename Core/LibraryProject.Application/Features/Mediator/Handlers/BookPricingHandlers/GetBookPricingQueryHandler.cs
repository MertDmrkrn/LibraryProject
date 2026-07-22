using LibraryProject.Application.Features.Mediator.Queries.BookPricingQueries;
using LibraryProject.Application.Features.Mediator.Results.BookPricingResults;
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
	public class GetBookPricingQueryHandler : IRequestHandler<GetBookPricingQuery, List<GetBookPricingQueryResult>>
	{
		private readonly IRepository<BookPricing> _repository;

		public GetBookPricingQueryHandler(IRepository<BookPricing> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetBookPricingQueryResult>> Handle(GetBookPricingQuery request, CancellationToken cancellationToken)
		{

			var values = await _repository.GetAllAsync();
			return values.Select(x => new GetBookPricingQueryResult
			{
				BookID = x.BookID,
				Amount = x.Amount,
				BookPricingID = x.BookPricingID
			}).ToList();
		}
	}
}
