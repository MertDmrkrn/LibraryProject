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
	public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand>
	{
		private readonly IRepository<Author> _repository;

		public UpdateAuthorCommandHandler(IRepository<Author> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.AuthorID);
			values.AuthorName = request.AuthorName;
			values.AuthorImgUrl = request.AuthorImgUrl;
			values.Description = request.Description;
			await _repository.UpdateAsync(values);
		}
	}
}
