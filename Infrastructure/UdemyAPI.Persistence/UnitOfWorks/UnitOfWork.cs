using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyAPI.Application.Interfaces.Repositories;
using UdemyAPI.Application.Interfaces.UnitOfWorks;
using UdemyAPI.Persistence.Contexts;
using UdemyAPI.Persistence.Repositories;

namespace UdemyAPI.Persistence.UnitOfWorks
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly UdemyDbContext _udemyDbContext;
		public UnitOfWork(UdemyDbContext udemyDbContext)
		{
			_udemyDbContext = udemyDbContext;
		}
		public async ValueTask DisposeAsync() => await _udemyDbContext.DisposeAsync();


		public int Save() => _udemyDbContext.SaveChanges();
		public async Task<int> SaveAsync() => await _udemyDbContext.SaveChangesAsync();
		IReadRepository<T> IUnitOfWork.GetReadRepository<T>() => new ReadRepository<T>(_udemyDbContext);
		IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>() => new WriteRepository<T>(_udemyDbContext);
	}
}
