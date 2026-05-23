using LibraryProject.Application.Features.Mediator.Commands.CategoryCommands;
using LibraryProject.Application.Interfaces;
using LibraryProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Handlers.CategoryHandlers
{
	public class RemoveCategoryCommandHandler : IRequestHandler<RemoveCategoryCommand>
	{
		private readonly IRepository<Category> _repository;

		public RemoveCategoryCommandHandler(IRepository<Category> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveCategoryCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			await _repository.RemoveAsync(values);
		}
	}
}
