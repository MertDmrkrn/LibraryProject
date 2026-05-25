using LibraryProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Results.BookResults
{
	public class GetBookByIdQueryResult
	{
		public int BookID { get; set; }

		public string BookName { get; set; }

		public int GenreID { get; set; }

		public string BookImgUrl { get; set; }

		public string BookAuthor { get; set; }
	}
}
