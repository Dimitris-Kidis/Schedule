using Microsoft.EntityFrameworkCore;
using TYPO.ApplicationCore.Domain;
using TYPO.ApplicationCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services.Repository
{
    public class TypoRepository<TEntity> : ITypoRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly TypoDbContext _dbContext;
        //private readonly IUserSession _currentUser; // !!!!!!!!!!!!!!!!!!!!!

        //public TypoRepository(TypoDbContext dbContext/*, IUserSession currentUser*/)
        //{
        //    _dbContext = dbContext;
        //    //_currentUser = currentUser;
        //}
        public virtual IQueryable<TEntity> Read() => _dbContext.Set<TEntity>();
        public async Task<TEntity> GetByIdAsync(int id, CancellationToken cancellationToken = default) =>
            await _dbContext.Set<TEntity>().SingleAsync(x => x.Id == id, cancellationToken);
        public async Task<TEntity> TryGetByIdAsync(int id, CancellationToken cancellationToken = default) =>
            await _dbContext.Set<TEntity>().SingleAsync(x => x.Id == id, cancellationToken);

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
            Audit();
        }

        public void AddRange(IList<TEntity> entities)
        {
            _dbContext.Set<TEntity>().AddRange(entities);
            Audit();
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
                }
                else if (entry.State == EntityState.Modified)
                {
                    entity.LastModifiedAt = now;
                    //entity.LastModifiedBy = _currentUser.Email; // !!!!!!!!!!!!!!!!!!!!!
                }
            }
        }
    }
}
