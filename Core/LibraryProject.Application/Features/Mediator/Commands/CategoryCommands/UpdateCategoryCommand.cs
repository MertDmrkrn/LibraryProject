using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Commands.CategoryCommands
{
	public class UpdateCategoryCommand:IRequest
	{
		public int CategoryID { get; set; }

		public string CategoryName { get; set; }
	}
}
