using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Entities
{
	public class Genre
	{
		public int GenreID { get; set; }

		public string GenreName { get; set; }

		public string GenreDescription { get; set; }

		public string GenreImgUrl { get; set; }

		public List<Book> Books { get; set; }

	}
}
