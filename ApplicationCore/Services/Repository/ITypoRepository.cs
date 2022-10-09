using TYPO.ApplicationCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ApplicationCore.Services.Repository
{
    public interface ITypoRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> Read();
        Task<TEntity> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<TEntity?> TryGetByIdAsync(int id, CancellationToken cancellationToken = default);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
        void AddRange(IList<TEntity> entities);
        void UpdateRange(IEnumerable<TEntity> entities);
        void DeleteRange(IEnumerable<TEntity> entities);
        IQueryable<TEntity> GetAll();
        TEntity GetWithInclude(Expression<Func<TEntity, bool>>? predicate, params Expression<Func<TEntity, object>>[] paths);
    }
}
