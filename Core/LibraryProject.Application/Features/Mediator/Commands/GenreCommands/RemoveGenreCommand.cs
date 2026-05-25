using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Commands.GenreCommands
{
	public class RemoveGenreCommand : IRequest
	{
		public int Id { get; set; }

		public RemoveGenreCommand(int id)
		{
			Id = id;
		}
	}
}
