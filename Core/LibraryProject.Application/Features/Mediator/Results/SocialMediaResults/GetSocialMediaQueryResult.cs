using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Results.SocialMediaResults
{
	public class GetSocialMediaQueryResult
	{
		public int SocialMediaID { get; set; }

		public string SocialMediaDescription { get; set; }

		public string SocialMediaUrl { get; set; }

		public string SocialMediaIcon { get; set; }
	}
}
