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
	public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand>
	{
		private readonly IRepository<Book> _repository;

		public CreateBookCommandHandler(IRepository<Book> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateBookCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new Book
			{
				BookAuthor = request.BookAuthor,
				BookName = request.BookName,
				BookImgUrl = request.BookImgUrl,
				GenreID = request.GenreID
			});
		}
	}
}
