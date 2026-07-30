using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Commands.SocialMediaCommands
{
	public class CreateSocialMediaCommand : IRequest
	{
		public string SocialMediaDescription { get; set; }

		public string SocialMediaUrl { get; set; }

		public string SocialMediaIcon { get; set; }
	}
}
