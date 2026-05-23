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
	public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, List<GetCategoryQueryResult>>
	{
		private readonly IRepository<Category> _repository;

		public GetCategoryQueryHandler(IRepository<Category> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetCategoryQueryResult>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();
			return values.Select(x => new GetCategoryQueryResult
			{
				CategoryID = x.CategoryID,
				CategoryName = x.CategoryName
			}).ToList();
		}
	}
}
