using LibraryProject.Application.Features.Mediator.Commands.BlogCommands;
using LibraryProject.Application.Interfaces;
using LibraryProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Handlers.BlogHandlers
{
	public class RemoveBlogCommandHandler : IRequestHandler<RemoveBlogCommand>
	{
		private readonly IRepository<Blog> _repository;

		public RemoveBlogCommandHandler(IRepository<Blog> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveBlogCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			await _repository.RemoveAsync(values);
		}
	}
}
