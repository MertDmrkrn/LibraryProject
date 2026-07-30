using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Results.LocationResults
{
	public class GetLocationQueryResult
	{
		public int LocationID { get; set; }

		public string LocationName { get; set; }

		public string LocationAddress { get; set; }

		public string LocationPhone { get; set; }

		public string LocationMail { get; set; }
	}
}
