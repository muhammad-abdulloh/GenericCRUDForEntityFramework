using EFFastCrud.Connections.Models;
using EFFastCrud.Data.IRepositories;
using EFFastCrud.Data.Repositories;
using EFFastCrud.Service.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace EFFastCrud.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public Task<Employee> GetAsync(Expression<Func<Employee, bool>> predicate)
        {
            
            return _employeeRepository.GetAsync(predicate);
        }


        public Task<IQueryable<Employee>> GetAllAsync(Expression<Func<Employee, bool>> predicate = null)
        {
            return _employeeRepository.GetAllAsync(predicate);
        }

        public Task<Employee> CreateAsync(Employee entity)
        {
            return _employeeRepository.CreateAsync(entity);
        }

        public Task<bool> DeleteAsync(Expression<Func<Employee, bool>> predicate)
        {
           
            return _employeeRepository.DeleteAsync(predicate); 
        }

        public Task<Employee> UpdateAsync(Employee entity)
        {
            return _employeeRepository.UpdateAsync(entity);
        }

        


    }
}
