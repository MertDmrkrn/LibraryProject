using LibraryProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Commands.BookCommands
{
	public class CreateBookCommand : IRequest
	{
		public string BookName { get; set; }

		public int GenreID { get; set; }

		public string BookImgUrl { get; set; }

		public string BookAuthor { get; set; }
	}
}
