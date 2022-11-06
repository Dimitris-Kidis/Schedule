﻿using ApplicationCore.Pagination.PagedReq;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TYPO.ApplicationCore.Domain.Entities;

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
        Task<PaginatedResult<TDto>> GetPagedUsers<Entity, TDto>(PagedRequest pagedRequest) where Entity : User where TDto : class;

        Task<PaginatedResult<TDto>> GetPagedUsersAvg<Entity, TDto>(PagedRequest pagedRequest) where Entity : User where TDto : class;
    }
}
