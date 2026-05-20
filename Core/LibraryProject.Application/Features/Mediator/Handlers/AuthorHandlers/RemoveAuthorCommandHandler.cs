using LibraryProject.Application.Features.Mediator.Commands.AuthorCommands;
using LibraryProject.Application.Interfaces;
using LibraryProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Handlers.AuthorHandlers
{
	public class RemoveAuthorCommandHandler : IRequestHandler<RemoveAuthorCommand>
	{
		private readonly IRepository<Author> _repository;

		public RemoveAuthorCommandHandler(IRepository<Author> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveAuthorCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			await _repository.RemoveAsync(values);
		}
	}
}
