using TYPO.ApplicationCore.Domain.Entities;
using System.Linq.Expressions;
using ApplicationCore.Pagination.PagedReq;

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
        void Save();
        IQueryable<TEntity> GetAllWithInclude<TEntity>(params Expression<Func<TEntity, object>>[] includeProperties) where TEntity : BaseEntity; // ??? ВОПРОС
        IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetListWithInclude(Expression<Func<TEntity, bool>>? predicate, params Expression<Func<TEntity, object>>[] paths);

        Task<PaginatedResult<TDto>> GetPagedUsers<TEntity, TDto>(PagedRequest pagedRequest) where TEntity : BaseEntity // !!! ??? 
                                                                                        where TDto : class;
    }
}
