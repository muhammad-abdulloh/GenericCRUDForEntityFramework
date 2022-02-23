using EFFastCrud.Connections.Models;
using Microsoft.EntityFrameworkCore;

namespace EFFastCrud.Data.DbContexts
{
    public class EmployeeDbContext : DbContext

    {
        DbSet<Employee> employeeDbContext { get; set; }
        private static readonly string CONNECTION_STRING = "Host=localhost; Port=5432; User Id=postgres; Password=12345; Database=experience;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(CONNECTION_STRING);
        }
    }
}
