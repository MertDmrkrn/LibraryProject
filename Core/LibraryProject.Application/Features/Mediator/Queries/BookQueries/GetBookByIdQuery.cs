using LibraryProject.Application.Features.Mediator.Results.BookResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Queries.BookQueries
{
	public class GetBookByIdQuery : IRequest<GetBookByIdQueryResult>
	{
		public int Id { get; set; }

		public GetBookByIdQuery(int id)
		{
			Id = id;
		}
	}
}
