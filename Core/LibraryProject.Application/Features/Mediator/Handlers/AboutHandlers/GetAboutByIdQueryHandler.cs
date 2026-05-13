using LibraryProject.Application.Features.Mediator.Queries.AboutQueries;
using LibraryProject.Application.Features.Mediator.Results.AboutResults;
using LibraryProject.Application.Interfaces;
using LibraryProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Handlers.AboutHandlers
{
	public class GetAboutByIdQueryHandler : IRequestHandler<GetAboutByIdQuery, GetAboutByIdQueryResult>
	{
		private readonly IRepository<About> _repository;

		public GetAboutByIdQueryHandler(IRepository<About> repository)
		{
			_repository = repository;
		}

		public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			return new GetAboutByIdQueryResult
			{
				AboutID = values.AboutID,
				AboutImgUrl = values.AboutImgUrl,
				Description = values.Description,
				Title = values.Title
			};
		}
	}
}
