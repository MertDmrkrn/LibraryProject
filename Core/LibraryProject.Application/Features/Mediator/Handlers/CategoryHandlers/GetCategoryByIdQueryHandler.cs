using LibraryProject.Application.Features.Mediator.Queries.CategoryQueries;
using LibraryProject.Application.Features.Mediator.Results.CategoryResults;
using LibraryProject.Application.Interfaces;
using LibraryProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Handlers.CategoryHandlers
{
	public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, GetCategoryByIdQueryResult>
	{
		private readonly IRepository<Category> _repository;

		public GetCategoryByIdQueryHandler(IRepository<Category> repository)
		{
			_repository = repository;
		}

		public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			return new GetCategoryByIdQueryResult
			{
				CategoryID = values.CategoryID,
				CategoryName = values.CategoryName
			};
		}
	}
}
