using EFFastCrud.Data.DbContexts;
using EFFastCrud.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EFFastCrud.Data.Repositories
{
#pragma warning disable
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private EmployeeDbContext _najotTalimDbContext;
        private DbSet<T> dbSet { get; set; }
        public GenericRepository()
        {
            _najotTalimDbContext = new EmployeeDbContext();
            this.dbSet = _najotTalimDbContext.Set<T>();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await dbSet.FirstOrDefaultAsync(predicate);
        }


        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            return predicate == null ? dbSet : dbSet.Where(predicate);
        }

        public async Task<T> CreateAsync(T entity)
        {
            EntityEntry entry = await dbSet.AddAsync(entity);

            await _najotTalimDbContext.SaveChangesAsync();

            return (T)entry.Entity;
        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            var entity = await dbSet.FirstOrDefaultAsync(predicate);

            if (entity is null)
                return false;

            dbSet.Remove(entity);

            await _najotTalimDbContext.SaveChangesAsync();

            return true;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            //_najotTalimDbContext.Entry(entity).State = EntityState.Modified;

            var entry = dbSet.Update(entity);

            await _najotTalimDbContext.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
