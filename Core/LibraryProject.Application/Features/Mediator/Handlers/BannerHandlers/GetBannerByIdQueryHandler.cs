using LibraryProject.Application.Features.Mediator.Queries.BannerQueries;
using LibraryProject.Application.Features.Mediator.Results.BannerResults;
using LibraryProject.Application.Interfaces;
using LibraryProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Handlers.BannerHandlers
{
	public class GetBannerByIdQueryHandler : IRequestHandler<GetBannerByIdQuery, GetBannerByIdQueryResult>
	{
		private readonly IRepository<Banner> _repository;

		public GetBannerByIdQueryHandler(IRepository<Banner> repository)
		{
			_repository = repository;
		}

		public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			return new GetBannerByIdQueryResult
			{
				BannerID = values.BannerID,
				BannerContent = values.BannerContent,
				BannerTitle = values.BannerTitle,
				BannerImg = values.BannerImg
			};
		}
	}
}
