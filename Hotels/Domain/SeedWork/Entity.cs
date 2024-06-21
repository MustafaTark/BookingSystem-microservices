using Hotels.Domain.SeedWork;
using System.Collections.Generic;
using System.Data;

namespace Hotels.Domain.SeedWork
{
	/// <summary>
	/// Base class for entities.
	/// </summary>
	public abstract class Entity<T> : IEntity<T>
	{
		public T Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public string? CreatedBy { get; set; }
		public DateTime? LastModified { get; set; }
		public string? LastModifiedBy { get; set; }
	}
}

