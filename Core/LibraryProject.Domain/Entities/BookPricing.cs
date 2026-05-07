using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Entities
{
	public class BookPricing
	{
		public int BookPricingID { get; set; }

		public int BookID { get; set; }

		public Book Book { get; set; }

		public decimal Amount { get; set; }
	}
}
