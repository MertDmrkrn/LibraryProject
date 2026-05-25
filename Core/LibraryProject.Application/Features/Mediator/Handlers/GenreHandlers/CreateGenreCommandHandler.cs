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
	public class CreateGenreCommandHandler : IRequestHandler<CreateGenreCommand>
	{
		private readonly IRepository<Genre> _repository;

		public CreateGenreCommandHandler(IRepository<Genre> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateGenreCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new Genre
			{
				GenreName = request.GenreName,
				GenreDescription = request.GenreDescription,	
				GenreImgUrl = request.GenreImgUrl
			});
		}
	}
}
