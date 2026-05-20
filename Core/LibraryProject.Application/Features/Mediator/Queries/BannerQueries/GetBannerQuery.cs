using LibraryProject.Application.Features.Mediator.Results.BannerResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Queries.BannerQueries
{
	public class GetBannerQuery : IRequest<List<GetBannerQueryResult>>
	{
	}
}
