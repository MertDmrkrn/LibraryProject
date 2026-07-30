using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Commands.TestimonialCommands
{
	public class UpdateTestimonialCommand : IRequest
	{
		public int TestimonialID { get; set; }

		public string TestimonialName { get; set; }

		public string TestimonialTitle { get; set; }
	}
}
