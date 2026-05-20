using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Commands.BannerCommands
{
	public class CreateBannerCommand : IRequest
	{
		public string BannerTitle { get; set; }

		public string BannerImg { get; set; }

		public string BannerContent { get; set; }
	}
}
