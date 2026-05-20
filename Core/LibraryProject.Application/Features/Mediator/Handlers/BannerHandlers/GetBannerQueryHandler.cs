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
	public class GetBannerQueryHandler : IRequestHandler<GetBannerQuery, List<GetBannerQueryResult>>
	{
		private readonly IRepository<Banner> _repository;

		public GetBannerQueryHandler(IRepository<Banner> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetBannerQueryResult>> Handle(GetBannerQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();
			return values.Select(x => new GetBannerQueryResult
			{
				BannerID = x.BannerID,
				BannerContent = x.BannerContent,
				BannerImg = x.BannerImg,
				BannerTitle = x.BannerTitle
			}).ToList();
		}
	}
}
