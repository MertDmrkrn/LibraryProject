using LibraryProject.Application.Features.Mediator.Commands.SocialMediaCommands;
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
	public class UpdateSocialMediaCommandHandler : IRequestHandler<UpdateSocialMediaCommand>
	{
		private readonly IRepository<SocialMedia> _repository;

		public UpdateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.SocialMediaID);
			values.SocialMediaDescription = request.SocialMediaDescription;
			values.SocialMediaIcon = request.SocialMediaIcon;
			values.SocialMediaUrl = request.SocialMediaUrl;
			await _repository.UpdateAsync(values);
		}
	}
}
