using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyAPI.Domain.Entities;

namespace UdemyAPI.Application.Features.Courses.Command.CreateCourse
{
	public class CreateCourseCommandRequest : IRequest<Unit>
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string CategoryId { get; set; }
		public string TrainerId { get; set; }
	}
}
