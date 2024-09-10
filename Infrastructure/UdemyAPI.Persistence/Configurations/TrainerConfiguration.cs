using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyAPI.Domain.Entities;

namespace UdemyAPI.Persistence.Configurations
{
	public class TrainerConfiguration : IEntityTypeConfiguration<Trainer>
	{
		public void Configure(EntityTypeBuilder<Trainer> builder)
		{
			Trainer trainer1 = new()
			{
				About = "Test",
				CreatedDate = DateTime.UtcNow,
				Id = Guid.NewGuid(),
				NameSurname = "Gencay Yildiz",
				ImageUrl = "testurl",
				IsDeleted = false,
			};
			Trainer trainer2 = new()
			{
				About = "Test2",
				CreatedDate = DateTime.UtcNow,
				Id = Guid.NewGuid(),
				NameSurname = "Murat Yucedag",
				ImageUrl = "testurl",
				IsDeleted = false,
			};
			Trainer trainer3 = new()
			{
				About = "Test3",
				CreatedDate = DateTime.UtcNow,
				Id = Guid.NewGuid(),
				NameSurname = "Maximillian Shwarzmuller",
				ImageUrl = "testurl",
				IsDeleted = false,
			};
			builder.HasData(trainer1, trainer2, trainer3);
		}
	}
}
