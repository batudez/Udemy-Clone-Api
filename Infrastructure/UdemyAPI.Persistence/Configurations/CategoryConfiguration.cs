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
	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			Category category1 = new()
			{
				CategoryName = "Yazılım",
				CreatedDate = DateTime.UtcNow,
				Id = Guid.NewGuid(),
				IsDeleted = false,

			};
			Category category2 = new()
			{
				CategoryName = "Finans",
				CreatedDate = DateTime.UtcNow,
				Id = Guid.NewGuid(),
				IsDeleted = false,

			};
			Category category3 = new()
			{
				CategoryName = "Kişisel Gelişim",
				CreatedDate = DateTime.UtcNow,
				Id = Guid.NewGuid(),
				IsDeleted = false,
			};

			builder.HasData(category1,category2, category3);

		}
	}
}
