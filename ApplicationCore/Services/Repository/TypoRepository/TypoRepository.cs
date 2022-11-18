using Microsoft.EntityFrameworkCore;
using TYPO.ApplicationCore.Domain;
using TYPO.ApplicationCore.Domain.Entities;
using System.Linq.Expressions;
using AutoMapper;
using ApplicationCore.Domain.Entities;

namespace ApplicationCore.Services.Repository
{
    public class TypoRepository<TEntity> : ITypoRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly TypoDbContext _dbContext;
        private readonly IMapper _mapper;

        public TypoRepository(TypoDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        //private readonly IUserSession _currentUser; // !!!!!!!!!!!!!!!!!!!!!

        //public TypoRepository(TypoDbContext dbContext/*, IUserSession currentUser*/)
        //{
        //    _dbContext = dbContext;
        //    //_currentUser = currentUser;
        //}
        public virtual IQueryable<TEntity> Read() => _dbContext.Set<TEntity>();
        public async Task<TEntity> GetByIdAsync(int id, CancellationToken cancellationToken = default) =>
            await _dbContext.Set<TEntity>().SingleAsync(x => x.Id == id, cancellationToken);
        public async Task<TEntity?> TryGetByIdAsync(int id, CancellationToken cancellationToken = default) =>
            await _dbContext.Set<TEntity>().SingleOrDefaultAsync(x => x.Id == id, cancellationToken);

        public TEntity Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            Audit();
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            Audit();
            return entity;
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public void AddRange(IList<TEntity> entities)
        {
            _dbContext.Set<TEntity>().AddRange(entities);
            Audit();
        }

        public IEnumerable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> queryable = _dbContext.Set<TEntity>().Where(predicate);
            return queryable.AsEnumerable();
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _dbContext.Set<TEntity>().UpdateRange(entities);
            Audit();
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _dbContext.Set<TEntity>().RemoveRange(entities);
        }

        public IQueryable<TEntity> GetAll()
        {
            var set = _dbContext.Set<TEntity>();
            //Audit();
            return set;
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public TEntity GetWithInclude(Expression<Func<TEntity, bool>>? predicate, params Expression<Func<TEntity, object>>[] paths)
        {
            IQueryable<TEntity> queryable = _dbContext.Set<TEntity>().Where(predicate);
            if (paths != null)
            {
                queryable = paths.Aggregate(queryable, (current, path) => current.Include(path));
            }
            List<TEntity> list = queryable.ToList();
            int index = new Random().Next(list.Count);
            return list[index];
        }

        public IQueryable<TEntity> GetListWithInclude(Expression<Func<TEntity, bool>>? predicate, params Expression<Func<TEntity, object>>[] paths)
        {
            IQueryable<TEntity> queryable = _dbContext.Set<TEntity>().Where(predicate);
            if (paths != null)
            {
                queryable = paths.Aggregate(queryable, (current, path) => current.Include(path));
            }
            return queryable;
        }
        public IQueryable<TEntity> GetAllWithInclude<TEntity>(params Expression<Func<TEntity, object>>[] includeProperties) where TEntity : BaseEntity
        {
            return IncludeProperties(includeProperties);
        }



        //public async Task<PaginatedResult<TDto>> GetPagedUsers<TEntity, TDto>(PagedRequest pagedRequest) where TEntity : BaseEntity
        //                                                                                where TDto : class
        //{
        //    return await _dbContext.Set<TEntity>().CreatePaginatedResultAsync<TEntity, TDto>(pagedRequest, _mapper);
        //}

        private IQueryable<TEntity> IncludeProperties<TEntity>(params Expression<Func<TEntity, object>>[] includeProperties) where TEntity : BaseEntity
        {
            IQueryable<TEntity> entities = _dbContext.Set<TEntity>();
            foreach (var includeProperty in includeProperties)
            {
                entities = entities.Include(includeProperty);
            }
            return entities;
        }


        private void Audit()
        {
            var entries = _dbContext.ChangeTracker.Entries().Where(x => x.State == EntityState.Added || x.State == EntityState.Modified);

            foreach (var entry in entries)
            {
                var now = DateTimeOffset.Now;
                var entity = (BaseEntity)entry.Entity;

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedAt = now;
                    //entity.CreatedBy = _currentUser.Email; // !!!!!!!!!!!!!!!!!!!!!
                    entity.CreatedBy = "admin";
                }
                else if (entry.State == EntityState.Modified)
                {
                    entity.LastModifiedAt = now;
                    //entity.LastModifiedBy = _currentUser.Email; // !!!!!!!!!!!!!!!!!!!!!
                    entity.LastModifiedBy = "admin";
                }
            }
        }
    }
}
