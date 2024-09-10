using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using UdemyAPI.Domain.Common;

namespace UdemyAPI.Domain.Entities
{
	public class Course : EntityBase
	{
        public Course()
        {
            
        }
        public Course(string name, string description, string categoryId,string trainerId)
        {
            Name = name;
			Description = description;
			CategoryId = Guid.Parse(categoryId);
			TrainerId = Guid.Parse(trainerId);
			CreatedDate = DateTime.UtcNow;
        }
        public string Name { get; set; }
		public string Description { get; set; }
		public  Category Category { get; set; }
		public Guid CategoryId { get; set; }
		public  Trainer Trainer { get; set; }
		public Guid TrainerId { get; set; }
		public  ICollection<Lesson> Lessons { get; set; }
	}
}
