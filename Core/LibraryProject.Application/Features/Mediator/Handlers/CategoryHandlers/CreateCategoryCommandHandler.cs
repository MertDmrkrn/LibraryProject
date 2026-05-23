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
	public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand>
	{
		private readonly IRepository<Category> _repository;

		public CreateCategoryCommandHandler(IRepository<Category> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new Category
			{
				CategoryName = request.CategoryName
			});
		}
	}
}
