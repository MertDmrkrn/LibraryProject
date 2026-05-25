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
	public class GetGenreByIdQueryHandler : IRequestHandler<GetGenreByIdQuery, GetGenreByIdQueryResult>
	{
		private readonly IRepository<Genre> _repository;

		public GetGenreByIdQueryHandler(IRepository<Genre> repository)
		{
			_repository = repository;
		}

		public async Task<GetGenreByIdQueryResult> Handle(GetGenreByIdQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			return new GetGenreByIdQueryResult
			{
				GenreID = values.GenreID,
				GenreDescription = values.GenreDescription,
				GenreName = values.GenreName,
				GenreImgUrl = values.GenreImgUrl
			};
		}
	}
}
