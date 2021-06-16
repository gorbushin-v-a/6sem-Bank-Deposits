using sharps_ent.Entity;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IEmployeeService
    {
        void CreateEmployee(Employee Employee);
        void DeleteEmployee(Employee Employee);
        Employee GetEmployeeById(int id);
        IEnumerable<Employee> GetEmployees();
        void UpdateEmployee(Employee Employee);
    }
}
