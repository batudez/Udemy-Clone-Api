using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyAPI.Application.Interfaces.Repositories;
using UdemyAPI.Application.Interfaces.UnitOfWorks;
using UdemyAPI.Persistence.Contexts;
using UdemyAPI.Persistence.Repositories;
using UdemyAPI.Persistence.UnitOfWorks;

namespace UdemyAPI.Persistence
{
	public static class ServiceRegistration
	{
		public static void AddPersistenceServices(this IServiceCollection services,IConfiguration configuration)
		{
			services.AddDbContext<UdemyDbContext>(opt =>
			opt.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));


			services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
			services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));
			services.AddScoped<IUnitOfWork, UnitOfWork>();
		}
	}
}
