using DressBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DressBazar.Services
{
    public class EmployeeService
    {
        public  List<Employee> GetAllEmployees()
        {
            using (var context = new DressBazar.Database.DBazarContext())
            {
                return context.employees.ToList();
            }
        }
        public void SaveEmployees(Employee emp)
        {
            using (var context = new DressBazar.Database.DBazarContext())
            {
                context.employees.Add(emp);
                context.SaveChanges();
            }
        }
    }
}
