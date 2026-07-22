using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Commands.BookPricingCommands
{
	public class RemoveBookPricingCommand : IRequest
	{
		public int Id { get; set; }

		public RemoveBookPricingCommand(int id)
		{
			Id = id;
		}
	}
}
