using EFFastCrud.Connections.Models;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EFFastCrud.Service.Interfaces
{
    public interface IEmployeeService
    {
        Task<Employee> GetAsync(Expression<Func<Employee, bool>> predicate);
        Task<IQueryable<Employee>> GetAllAsync(Expression<Func<Employee, bool>> predicate = null);
        Task<Employee> CreateAsync(Employee entity);
        Task<bool> DeleteAsync(Expression<Func<Employee, bool>> predicate);
        Task<Employee> UpdateAsync(Employee entity);

    }
}
