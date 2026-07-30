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
	public class GetLocationByIdQueryHandler : IRequestHandler<GetLocationByIdQuery, GetLocationByIdQueryResult>
	{
		private readonly IRepository<Location> _repository;

		public GetLocationByIdQueryHandler(IRepository<Location> repository)
		{
			_repository = repository;
		}

		public async Task<GetLocationByIdQueryResult> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);
			return new GetLocationByIdQueryResult
			{
				LocationID = values.LocationID,
				LocationAddress = values.LocationAddress,
				LocationMail = values.LocationMail,
				LocationName = values.LocationName,
				LocationPhone = values.LocationPhone
			};
		}
	}
}
