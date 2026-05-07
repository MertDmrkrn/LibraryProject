using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Entities
{
	public class Book
	{
		public int BookID { get; set; }

		public string BookName { get; set; }

		public int GenreID { get; set; }

		public Genre Genre { get; set; }

		public string BookImgUrl { get; set; }

		public string BookAuthor { get; set; }

		public List<BookPricing> BookPricings { get; set; }

	}
}
