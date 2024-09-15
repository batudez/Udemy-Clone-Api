using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyAPI.Domain.Entities;

namespace UdemyAPI.Application.Features.Lessons.Command.CreateLesson
{
	public class CreateLessonCommandRequest : IRequest<Unit>
	{
		public string LessonName { get; set; }
		//public string LessonVideoUrl { get; set; } = string.Empty;
		public string LessonVideoUrl { get; set; }	= string.Empty;
		public string CourseId { get; set; }
		public IFormFile file { get; set; }
	}
}
