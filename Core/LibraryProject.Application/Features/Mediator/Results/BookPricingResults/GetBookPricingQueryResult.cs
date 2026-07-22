using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Results.BookPricingResults
{
	public class GetBookPricingQueryResult
	{
		public int BookPricingID { get; set; }

		public int BookID { get; set; }

		public decimal Amount { get; set; }
	}
}
