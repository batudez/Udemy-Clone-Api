using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyAPI.Application.Interfaces.Automapper;
using UdemyAPI.Application.Interfaces.UnitOfWorks;
using UdemyAPI.Domain.Entities;

namespace UdemyAPI.Application.Features.Lessons.Queries.GetLessonByCourseId
{
	public class GetLessonByCourseIdQueryHandler : IRequestHandler<GetLessonByCourseIdQueryRequest, IList<GetLessonByCourseIdQueryResponse>>
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;
        public GetLessonByCourseIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
			_unitOfWork = unitOfWork;
        }
        public async Task<IList<GetLessonByCourseIdQueryResponse>> Handle(GetLessonByCourseIdQueryRequest request, CancellationToken cancellationToken)
		{
			var lessons = await _unitOfWork.GetReadRepository<Lesson>().GetAllAsync(x => x.CourseId == request.CourseId);

			var map = _mapper.Map<GetLessonByCourseIdQueryResponse, Lesson>(lessons);

			return map;
		}
	}
}
