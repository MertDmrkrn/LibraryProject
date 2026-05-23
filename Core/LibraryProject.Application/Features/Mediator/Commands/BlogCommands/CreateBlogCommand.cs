using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Commands.BlogCommands
{
	public class CreateBlogCommand : IRequest
	{
		public string BlogTitle { get; set; }

		public int AuthorID { get; set; }

		public string Description { get; set; }

		public string CoverImgUrl { get; set; }

		public DateTime CreatedDate { get; set; }

		public int CategoryID { get; set; }
	}
}
