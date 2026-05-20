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
	public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand>
	{
		private readonly IRepository<Author> _repository;

		public CreateAuthorCommandHandler(IRepository<Author> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new Author
			{
				AuthorImgUrl = request.AuthorImgUrl,
				AuthorName = request.AuthorName,
				Description = request.Description,
			});
		}
	}
}
