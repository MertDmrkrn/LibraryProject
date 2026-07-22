using LibraryProject.Application.Features.Mediator.Results.BookPricingResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Queries.BookPricingQueries
{
	public class GetBookPricingByIdQuery : IRequest<GetBookPricingByIdQueryResult>
	{
		public int Id { get; set; }

		public GetBookPricingByIdQuery(int id)
		{
			Id = id;
		}
	}
}
