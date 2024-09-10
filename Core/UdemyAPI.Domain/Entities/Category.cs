using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using UdemyAPI.Domain.Common;

namespace UdemyAPI.Domain.Entities
{
	public class Category : EntityBase
	{
        public Category()
        {
            
        }
        public Category(string categoryName)
        {
            CategoryName = categoryName;
            CreatedDate = DateTime.UtcNow;
        }
        public string CategoryName { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
