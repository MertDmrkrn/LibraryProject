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
	public class GetSocialMediaByIdQueryHandler : IRequestHandler<GetSocialMediaByIdQuery, GetSocialMediaByIdQueryResult>
	{
		private readonly IRepository<SocialMedia> _repository;

		public GetSocialMediaByIdQueryHandler(IRepository<SocialMedia> repository)
		{
			_repository = repository;
		}

		public async Task<GetSocialMediaByIdQueryResult> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			return new GetSocialMediaByIdQueryResult
			{
				SocialMediaID=values.SocialMediaID,
				SocialMediaDescription = values.SocialMediaDescription,
				SocialMediaIcon = values.SocialMediaIcon,
				SocialMediaUrl = values.SocialMediaUrl
			};
		}
	}
}
