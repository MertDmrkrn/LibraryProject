using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Commands.AboutCommands
{
	public class CreateAboutCommand : IRequest
	{
		public string Title { get; set; }

		public string AboutImgUrl { get; set; }

		public string Description { get; set; }
	}
}
