using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using UdemyAPI.Domain.Common;

namespace UdemyAPI.Domain.Entities
{
	public class Trainer : EntityBase
	{
        public Trainer()
        {
            
        }
        public Trainer(string nameSurname,string about,string imageUrl)
        {
            NameSurname = nameSurname;
            About = about;
            CreatedDate = DateTime.UtcNow;
            ImageUrl = imageUrl;
        }
        public string NameSurname { get; set; }
        public string About { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
