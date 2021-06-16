using BLL.Interfaces;
using sharps_ent.Entity;
using sharps_ent.Repository.Interface;
using System.Collections.Generic;

namespace BLL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IRepository<Employee> EmployeeRepository;

        public EmployeeService(IRepository<Employee> EmployeeRepository)
        {
            this.EmployeeRepository = EmployeeRepository;
        }

        public void CreateEmployee(Employee Employee)
        {
            EmployeeRepository.Add(Employee);
        }

        public void DeleteEmployee(Employee Employee)
        {
            EmployeeRepository.Remove(Employee);
        }
        public Employee GetEmployeeById(int id)
        {
            return EmployeeRepository.Get(id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return EmployeeRepository.Get();
        }

        public void UpdateEmployee(Employee Employee)
        {
            EmployeeRepository.Update(Employee);
        }
    }
}
