using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Results.BannerResults
{
	public class GetBannerQueryResult
	{
		public int BannerID { get; set; }

		public string BannerTitle { get; set; }

		public string BannerImg { get; set; }

		public string BannerContent { get; set; }
	}
}
