using LibraryProject.Application.Features.Mediator.Queries.FooterAddressQueries;
using LibraryProject.Application.Features.Mediator.Results.FooterAddress;
using LibraryProject.Application.Interfaces;
using LibraryProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Handlers.FooterAddresHandlers
{
	public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQuery, List<GetFooterAddressQueryResult>>
	{
		private readonly IRepository<FooterAddress> _repository;

		public GetFooterAddressQueryHandler(IRepository<FooterAddress> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetFooterAddressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();
			return values.Select(x => new GetFooterAddressQueryResult
			{
				FooterAddressID = x.FooterAddressID,
				Address = x.Address,
				Description = x.Description,
				Mail = x.Mail,
				Phone = x.Phone
			}).ToList();
		}
	}
}
