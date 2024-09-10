using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAPI.Application.Features.Lessons.Queries.GetLessonByCourseId
{
	public class GetLessonByCourseIdQueryRequest : IRequest<IList<GetLessonByCourseIdQueryResponse>>
	{
        public Guid CourseId { get; set; }
    }
}
