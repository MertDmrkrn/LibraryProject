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
	public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand>
	{
		private readonly IRepository<Book> _repository;

		public UpdateBookCommandHandler(IRepository<Book> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateBookCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.BookID);
			values.BookName = request.BookName;
			values.BookAuthor = request.BookAuthor;
			values.BookImgUrl = request.BookImgUrl;
			values.GenreID = request.GenreID;
			await _repository.UpdateAsync(values);
		}
	}
}
