using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyAPI.Application.Interfaces.Automapper;
using UdemyAPI.Application.Interfaces.UnitOfWorks;
using UdemyAPI.Domain.Entities;

namespace UdemyAPI.Application.Features.Courses.Command.CreateCourse
{
	public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommandRequest, Unit>
	{
		private readonly IMapper _mapper;
		private readonly IUnitOfWork _unitOfWork;
        public CreateCourseCommandHandler(IMapper mapper , IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
			_unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(CreateCourseCommandRequest request, CancellationToken cancellationToken)
		{
			Course course = new(request.Name, request.Description, request.CategoryId, request.TrainerId);
			await _unitOfWork.GetWriteRepository<Course>().AddAsync(course);
			await _unitOfWork.SaveAsync();

			return Unit.Value;
		}
	}
}
