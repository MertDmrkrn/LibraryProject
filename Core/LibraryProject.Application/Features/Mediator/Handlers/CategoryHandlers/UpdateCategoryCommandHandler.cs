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
	public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand>
	{
		private readonly IRepository<Category> _repository;

		public UpdateCategoryCommandHandler(IRepository<Category> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.CategoryID);
			values.CategoryName = request.CategoryName;
			await _repository.UpdateAsync(values);
		}
	}
}
