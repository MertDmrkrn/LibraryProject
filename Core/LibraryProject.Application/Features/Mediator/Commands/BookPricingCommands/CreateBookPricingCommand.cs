using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Commands.BookPricingCommands
{
	public class CreateBookPricingCommand : IRequest
	{
		public int BookID { get; set; }

		public decimal Amount { get; set; }
	}
}
