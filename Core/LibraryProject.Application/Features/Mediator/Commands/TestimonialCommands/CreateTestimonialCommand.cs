using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Commands.TestimonialCommands
{
	public class CreateTestimonialCommand : IRequest
	{
		public string TestimonialName { get; set; }

		public string TestimonialTitle { get; set; }
	}
}
