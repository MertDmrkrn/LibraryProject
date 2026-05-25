using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Results.GenreResults
{
	public class GetGenreByIdQueryResult
	{
		public int GenreID { get; set; }

		public string GenreName { get; set; }

		public string GenreDescription { get; set; }

		public string GenreImgUrl { get; set; }
	}
}
