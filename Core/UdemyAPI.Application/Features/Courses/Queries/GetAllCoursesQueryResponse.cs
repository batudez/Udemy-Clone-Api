using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyAPI.Application.DTOs;

namespace UdemyAPI.Application.Features.Courses.Queries
{
	public class GetAllCoursesQueryResponse
	{
        public string Id { get; set; }
        public string Name { get; set; }
		public string Description { get; set; }
        public TrainerDto Trainer { get; set; }
        public CategoryDto Category { get; set; }
    }
}
