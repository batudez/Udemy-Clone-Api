using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UdemyAPI.Domain.Entities;


namespace UdemyAPI.Persistence.Contexts
{
	public class UdemyDbContext : DbContext
	{
        public UdemyDbContext()
        {
            
        }
        public UdemyDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Category> Categories { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}

	}
}
