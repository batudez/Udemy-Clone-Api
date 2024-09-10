using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Application.Entities
{
	public class Course : BaseEntity
	{
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public Trainer Trainer { get; set; }
        public ICollection<Lesson> Lessons  { get; set; }
    }
}
