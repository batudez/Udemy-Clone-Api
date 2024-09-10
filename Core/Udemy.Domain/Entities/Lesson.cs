using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Application.Entities
{
	public class Lesson : BaseEntity
	{
        public string LessonVideoUrl { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
