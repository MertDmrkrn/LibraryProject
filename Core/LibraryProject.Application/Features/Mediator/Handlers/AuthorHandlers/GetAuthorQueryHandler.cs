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
	public class GetAuthorQueryHandler : IRequestHandler<GetAuthorQuery, List<GetAuthorQueryResult>>
	{
		private readonly IRepository<Author> _repository;

		public GetAuthorQueryHandler(IRepository<Author> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetAuthorQueryResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();
			return values.Select(x => new GetAuthorQueryResult
			{
				AuthorID = x.AuthorID,
				AuthorName = x.AuthorName,
				AuthorImgUrl = x.AuthorImgUrl,
				Description = x.Description
			}).ToList();
		}
	}
}
