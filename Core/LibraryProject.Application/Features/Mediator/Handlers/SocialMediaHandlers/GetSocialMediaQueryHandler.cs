using LibraryProject.Application.Features.Mediator.Queries.SocialMediaQueries;
using LibraryProject.Application.Features.Mediator.Results.SocialMediaResults;
using LibraryProject.Application.Interfaces;
using LibraryProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
	public class GetSocialMediaQueryHandler : IRequestHandler<GetSocialMediaQuery, List<GetSocialMediaQueryResult>>
	{
		private readonly IRepository<SocialMedia> _repository;

		public GetSocialMediaQueryHandler(IRepository<SocialMedia> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetSocialMediaQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();
			return values.Select(x => new GetSocialMediaQueryResult
			{
				SocialMediaID = x.SocialMediaID,
				SocialMediaDescription = x.SocialMediaDescription,
				SocialMediaIcon = x.SocialMediaIcon,
				SocialMediaUrl = x.SocialMediaUrl
			}).ToList();

		}
	}
}
