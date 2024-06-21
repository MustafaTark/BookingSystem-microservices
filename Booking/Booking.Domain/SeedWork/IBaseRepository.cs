using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Domain.SeedWork
{
	public interface IBaseRepository<T> where T : class
	{
		Task<IEnumerable<T>> FindAll(bool trackChanges);
		Task<IEnumerable<T>> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
		Task<T?> Find(Expression<Func<T, bool>> expression, bool trackChanges);
		Task<T> Create(T entity);
		void Delete(T entity);
		void Update(T entity);
		Task SaveAsync (CancellationToken cancellationToken);
	}
}
