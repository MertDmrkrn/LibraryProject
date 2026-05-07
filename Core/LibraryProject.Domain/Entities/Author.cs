using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Entities
{
	public class Author
	{
		public int AuthorID { get; set; }

		public string  AuthorName { get; set; }

		public string AuthorImgUrl { get; set; }

		public string Description { get; set; }

		public List<Blog> Blogs { get; set; }
	}
}
