using LibraryProject.Application.Features.Mediator.Results.BookPricingResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Queries.BookPricingQueries
{
	public class GetBookPricingQuery : IRequest<List<GetBookPricingQueryResult>>
	{
	}
}
