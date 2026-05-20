using LibraryProject.Application.Features.Mediator.Commands.BannerCommands;
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
	public class UpdateBannerCommandHandler : IRequestHandler<UpdateBannerCommand>
	{
		private readonly IRepository<Banner> _repository;

		public UpdateBannerCommandHandler(IRepository<Banner> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateBannerCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.BannerID);
			values.BannerImg = request.BannerImg;
			values.BannerContent = request.BannerContent;
			values.BannerTitle = request.BannerTitle;
			await _repository.UpdateAsync(values);
		}
	}
}
