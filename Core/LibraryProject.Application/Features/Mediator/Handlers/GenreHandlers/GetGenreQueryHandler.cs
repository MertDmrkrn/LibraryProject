using LibraryProject.Application.Features.Mediator.Queries.GenreQueries;
using LibraryProject.Application.Features.Mediator.Results.GenreResults;
using LibraryProject.Application.Interfaces;
using LibraryProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Handlers.GenreHandlers
{
	public class GetGenreQueryHandler : IRequestHandler<GetGenreQuery, List<GetGenreQueryResult>>
	{
		private readonly IRepository<Genre> _repository;

		public GetGenreQueryHandler(IRepository<Genre> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetGenreQueryResult>> Handle(GetGenreQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();
			return values.Select(x => new GetGenreQueryResult
			{
				GenreID = x.GenreID,
				GenreName = x.GenreName,
				GenreDescription = x.GenreDescription,
				GenreImgUrl = x.GenreImgUrl
			}).ToList();
		}
	}
}
