using LibraryProject.Application.Features.Mediator.Results.BookResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Queries.BookQueries
{
	public class GetBookQuery : IRequest<List<GetBookQueryResult>>
	{
	}
}
