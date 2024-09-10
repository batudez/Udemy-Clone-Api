using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyAPI.Domain.Common;

namespace UdemyAPI.Domain.Entities
{
	public class Lesson : EntityBase
	{
        public Lesson()
        {
            
        }
        public Lesson(string lessonName,string lessonVideoUrl,string courseId)
        {
            LessonName = lessonName;
            LessonVideoUrl = lessonVideoUrl;
            CourseId = Guid.Parse(courseId);
        }
        public string LessonName { get; set; }
        public string LessonVideoUrl { get; set; }
        public Course Course { get; set; }
        public Guid CourseId { get; set; }
    }
}
