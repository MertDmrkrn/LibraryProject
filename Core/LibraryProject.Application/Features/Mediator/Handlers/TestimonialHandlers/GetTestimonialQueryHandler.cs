using LibraryProject.Application.Features.Mediator.Queries.TestimonialQueries;
using LibraryProject.Application.Features.Mediator.Results.TestimonialResults;
using LibraryProject.Application.Interfaces;
using LibraryProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Application.Features.Mediator.Handlers.TestimonialHandlers
{
	public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
	{
		private readonly IRepository<Testimonial> _repository;

		public GetTestimonialQueryHandler(IRepository<Testimonial> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();
			return values.Select(x => new GetTestimonialQueryResult
			{
				TestimonialID = x.TestimonialID,
				TestimonialName = x.TestimonialName,
				TestimonialTitle = x.TestimonialTitle
			}).ToList();
		}
	}
}
