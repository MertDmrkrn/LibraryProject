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
	public class RemoveGenreCommandHandler : IRequestHandler<RemoveGenreCommand>
	{
		private readonly IRepository<Genre> _repository;

		public RemoveGenreCommandHandler(IRepository<Genre> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveGenreCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			await _repository.RemoveAsync(values);
		}
	}
}
