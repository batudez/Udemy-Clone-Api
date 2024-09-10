using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAPI.Application.Features.Lessons.Queries.GetLessonByCourseId
{
	public class GetLessonByCourseIdQueryResponse
	{
		public string LessonName { get; set; }
		public string LessonVideoUrl { get; set; }
	}
}
