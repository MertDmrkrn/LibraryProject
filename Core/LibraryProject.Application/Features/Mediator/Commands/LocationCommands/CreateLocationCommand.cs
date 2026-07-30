using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Commands.LocationCommands
{
	public class CreateLocationCommand : IRequest
	{	
		public string LocationName { get; set; }

		public string LocationAddress { get; set; }

		public string LocationPhone { get; set; }

		public string LocationMail { get; set; }
	}
}
