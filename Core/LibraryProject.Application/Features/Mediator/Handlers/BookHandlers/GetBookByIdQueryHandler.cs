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
	public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, GetBookByIdQueryResult>
	{

		private readonly IRepository<Book> _repository;

		public GetBookByIdQueryHandler(IRepository<Book> repository)
		{
			_repository = repository;
		}

		public async Task<GetBookByIdQueryResult> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			return new GetBookByIdQueryResult
			{
				BookID = values.BookID,
				BookAuthor = values.BookAuthor,
				BookImgUrl = values.BookImgUrl,
				BookName = values.BookName,
				GenreID = values.GenreID
			};
		}
	}
}
