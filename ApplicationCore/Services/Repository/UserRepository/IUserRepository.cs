using System.Linq.Expressions;

namespace ApplicationCore.Services.Repository.UserRepository
{

    public interface IUserRepository<TEntity>
    {
        void Delete(TEntity entity);
        void Save();
        Task<TEntity> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetAll();
        TEntity GetWithInclude(Expression<Func<TEntity, bool>>? predicate, params Expression<Func<TEntity, object>>[] paths);

    }
}
