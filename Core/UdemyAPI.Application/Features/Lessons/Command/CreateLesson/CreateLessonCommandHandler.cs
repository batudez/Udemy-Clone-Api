using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyAPI.Application.Interfaces.Automapper;
using UdemyAPI.Application.Interfaces.UnitOfWorks;
using UdemyAPI.Domain.Entities;

namespace UdemyAPI.Application.Features.Lessons.Command.CreateLesson
{
	public class CreateLessonCommandHandler : IRequestHandler<CreateLessonCommandRequest,Unit>
	{
		private readonly IMapper _mapper;
		private readonly IUnitOfWork _unitOfWork;
		public CreateLessonCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
		{
			_mapper = mapper;
			_unitOfWork = unitOfWork;
		}

		public async Task<Unit> Handle(CreateLessonCommandRequest request, CancellationToken cancellationToken)
		{
			Lesson lesson = new(request.LessonName, request.LessonVideoUrl, request.CourseId);
			await _unitOfWork.GetWriteRepository<Lesson>().AddAsync(lesson);
			await _unitOfWork.SaveAsync();

			return Unit.Value;
		}
	}
}
