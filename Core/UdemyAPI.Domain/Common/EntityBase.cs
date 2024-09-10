using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyAPI.Domain.Common
{
	public class EntityBase : IEntityBase
	{
		public Guid Id { get; set; }
		public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
		public bool IsDeleted { get; set; } = false;
	}
}
