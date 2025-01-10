using BlogApp.Core.Entities.Common;
using BlogApp.DAL.Context;
using BlogApp.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.DAL.Repositories.Implementations
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        BlogAppDbContext _context;

        public Repository(BlogAppDbContext context)
        {
            _context = context;
        }
        public DbSet<TEntity> Table => throw new NotImplementedException();

        public Task<TEntity> Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExsist(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void SoftDelete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        IQueryable<TEntity> IRepository<TEntity>.GetAll(params string[] includes)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IRepository<TEntity>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
