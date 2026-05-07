using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Entities
{
	public class Blog
	{
		public int BlogID { get; set; }

		public string BlogTitle { get; set; }

		public int AuhtorID { get; set; }

		public Author Author { get; set; }

		public string CoverImgUrl { get; set; }

		public DateTime CreatedDate { get; set; }

		public int CategoryID { get; set; }

		public Category Category { get; set; }

		public string Description { get; set; }
	}
}
