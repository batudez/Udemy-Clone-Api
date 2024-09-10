using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyAPI.Application.Interfaces.Repositories;
using UdemyAPI.Domain.Common;
using UdemyAPI.Domain.Entities;
using UdemyAPI.Persistence.Contexts;

namespace UdemyAPI.Persistence.Repositories
{
	public class WriteRepository<T> : IWriteRepository<T> where T : class, IEntityBase, new()
	{
		private readonly UdemyDbContext _udemyDbContext;
		public WriteRepository(UdemyDbContext udemyDbContext)
		{
			_udemyDbContext = udemyDbContext;
		}
		private DbSet<T> Table { get => _udemyDbContext.Set<T>(); }

		public async Task AddAsync(T Entity)
		{
			await Table.AddAsync(Entity);
		}

		public async Task AddRangeAsync(IList<T> entities)
		{
			await Table.AddRangeAsync(entities);
		}
		public async Task<T> UpdateAsync(T entity)
		{
			await Task.Run(() => Table.Update(entity));
			return entity;
		}

		public async Task HardDeleteAsync(T entity)
		{
			await Task.Run(() => Table.Remove(entity));
		}

		public async Task HardDeleteRangeAsync(IList<T> entity)
		{
			await Task.Run(() => Table.RemoveRange(entity));
		}
	}
}
