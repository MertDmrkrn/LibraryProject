using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Results.AboutResults
{
	public class GetAboutQueryResult
	{
		public int AboutID { get; set; }

		public string Title { get; set; }

		public string AboutImgUrl { get; set; }

		public string Description { get; set; }
	}
}
