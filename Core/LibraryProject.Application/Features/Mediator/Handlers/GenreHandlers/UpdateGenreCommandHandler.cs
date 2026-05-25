using LibraryProject.Application.Features.Mediator.Commands.GenreCommands;
using LibraryProject.Application.Interfaces;
using LibraryProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Handlers.GenreHandlers
{
	public class UpdateGenreCommandHandler : IRequestHandler<UpdateGenreCommand>
	{
		private readonly IRepository<Genre> _repository;

		public UpdateGenreCommandHandler(IRepository<Genre> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateGenreCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.GenreID);
			values.GenreDescription = request.GenreDescription;
			values.GenreName = request.GenreName;
			values.GenreImgUrl = request.GenreImgUrl;
			await _repository.UpdateAsync(values);
		}
	}
}
