using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyAPI.Application.Interfaces.Automapper;

namespace UdemyAPI.Mapper
{
	public static class ServiceRegistration
	{
		public static void AddCustomMapper(this IServiceCollection services)
		{
			services.AddSingleton<IMapper, AutoMapper.Mapper>();
		}
	}
}
