﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Application.Entities
{
	public class Trainer : BaseEntity
	{
        public string NameSurname { get; set; }
        public string  About  { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
