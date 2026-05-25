using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Commands.BookCommands
{
	public class RemoveBookCommand : IRequest
	{
		public int Id { get; set; }

		public RemoveBookCommand(int id)
		{
			Id = id;
		}
	}
}
