﻿using TYPO.ApplicationCore.Domain.Entities;
using System.Linq.Expressions;

namespace ApplicationCore.Services.Repository
{
    public interface ITypoRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
        void AddRange(IList<TEntity> entities);
        void UpdateRange(IEnumerable<TEntity> entities);
        void DeleteRange(IEnumerable<TEntity> entities);
        IQueryable<TEntity> GetAll();
        TEntity GetWithInclude(Expression<Func<TEntity, bool>>? predicate, params Expression<Func<TEntity, object>>[] paths);
        void Save();
        IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetListWithInclude(Expression<Func<TEntity, bool>>? predicate, params Expression<Func<TEntity, object>>[] paths);


    }
}
