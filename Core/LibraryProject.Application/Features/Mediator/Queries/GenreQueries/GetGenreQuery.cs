using LibraryProject.Application.Features.Mediator.Results.GenreResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Queries.GenreQueries
{
	public class GetGenreQuery : IRequest<List<GetGenreQueryResult>>
	{ 
	}

}
