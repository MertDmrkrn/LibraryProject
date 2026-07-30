using LibraryProject.Application.Features.Mediator.Queries.LocationQueries;
using LibraryProject.Application.Features.Mediator.Results.LocationResults;
using LibraryProject.Application.Interfaces;
using LibraryProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Handlers.LocationHandlers
{
	public class GetLocationQueryHandler : IRequestHandler<GetLocationQuery, List<GetLocationQueryResult>>
	{
		private readonly IRepository<Location> _repository;

		public GetLocationQueryHandler(IRepository<Location> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();
			return values.Select(x => new GetLocationQueryResult
			{
				LocationID = x.LocationID,
				LocationName = x.LocationName,
				LocationAddress = x.LocationAddress,
				LocationMail = x.LocationMail,
				LocationPhone = x.LocationPhone,
			}).ToList();
		}
	}
}
