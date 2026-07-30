using LibraryProject.Application.Features.Mediator.Commands.TestimonialCommands;
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
	public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommand>
	{
		private readonly IRepository<Testimonial> _repository;

		public UpdateTestimonialCommandHandler(IRepository<Testimonial> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.TestimonialID);
			values.TestimonialTitle = request.TestimonialTitle;
			values.TestimonialName = request.TestimonialName;
			await _repository.UpdateAsync(values);
		}
	}
}
