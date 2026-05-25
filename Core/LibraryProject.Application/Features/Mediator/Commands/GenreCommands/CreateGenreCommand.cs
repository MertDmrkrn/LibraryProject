using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Commands.GenreCommands
{
	public class CreateGenreCommand : IRequest
	{
		public string GenreName { get; set; }

		public string GenreDescription { get; set; }

		public string GenreImgUrl { get; set; }
	}
}
