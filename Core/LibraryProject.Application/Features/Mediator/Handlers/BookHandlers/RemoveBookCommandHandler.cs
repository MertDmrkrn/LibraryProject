using LibraryProject.Application.Features.Mediator.Commands.BookCommands;
using LibraryProject.Application.Interfaces;
using LibraryProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Handlers.BookHandlers
{
	public class RemoveBookCommandHandler : IRequestHandler<RemoveBookCommand>
	{
		private readonly IRepository<Book> _repository;

		public RemoveBookCommandHandler(IRepository<Book> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveBookCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			await _repository.RemoveAsync(values);
		}
	}
}
