using LibraryProject.Application.Features.Mediator.Queries.AuthorQueries;
using LibraryProject.Application.Features.Mediator.Results.AuthorResults;
using LibraryProject.Application.Interfaces;
using LibraryProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Handlers.AuthorHandlers
{
	public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdQueryResult>
	{
		private readonly IRepository<Author> _repository;

		public GetAuthorByIdQueryHandler(IRepository<Author> repository)
		{
			_repository = repository;
		}

		public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			return new GetAuthorByIdQueryResult
			{
				AuthorID = values.AuthorID,
				AuthorImgUrl = values.AuthorImgUrl,
				AuthorName = values.AuthorName,
				Description = values.Description
			};
		}
	}
}
