using EFFastCrud.Service.Services;
using System;
using System.Threading.Tasks;

namespace EFFastCrud
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var employeeService = new EmployeeService();

             var employee = await employeeService.GetAsync(p => p.FirstName == "Nargiza");
            
             Console.WriteLine(employee.FirstName + " " + employee.LastName);


           /* var results = await employeeService.GetAllAsync();


            foreach (var item in results)
            {
                Console.WriteLine(item.FirstName + " " + item.Id);
            }*/
        }
    }
}
