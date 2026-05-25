using LibraryProject.Application.Features.Mediator.Queries.BookQueries;
using LibraryProject.Application.Features.Mediator.Results.BookResults;
using LibraryProject.Application.Interfaces;
using LibraryProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Handlers.BookHandlers
{
	public class GetBookQueryHandler : IRequestHandler<GetBookQuery, List<GetBookQueryResult>>
	{
		private readonly IRepository<Book> _repository;

		public GetBookQueryHandler(IRepository<Book> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetBookQueryResult>> Handle(GetBookQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();
			return values.Select(x => new GetBookQueryResult
			{
				BookID = x.BookID,
				BookName = x.BookName,
				BookAuthor = x.BookAuthor,
				BookImgUrl = x.BookImgUrl,
				GenreID = x.GenreID
			}).ToList();
		}
	}
}
