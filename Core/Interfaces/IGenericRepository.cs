using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces;

public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
            Task<TEntity> GetByIdAsync(int id);
            Task<IEnumerable<TEntity>> GetAllAsync();
            IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression);
            void Add(TEntity entity);
            void AddRange(IEnumerable<TEntity> entities);
            void Remove(TEntity entity);
            void RemoveRange(IEnumerable<TEntity> entities);
            void Update(TEntity entity);
    }
