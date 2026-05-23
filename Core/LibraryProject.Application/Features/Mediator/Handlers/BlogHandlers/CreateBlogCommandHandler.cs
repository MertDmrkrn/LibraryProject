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
	public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand>
	{
		private readonly IRepository<Blog> _repository;

		public CreateBlogCommandHandler(IRepository<Blog> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateBlogCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new Blog
			{
				AuthorID = request.AuthorID,
				BlogTitle = request.BlogTitle,
				CategoryID = request.CategoryID,
				CoverImgUrl = request.CoverImgUrl,
				CreatedDate = request.CreatedDate,
				Description = request.Description
			});
		}
	}
}
