using Paycompute.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Paycompute.Services
{
    public interface IEmployeeService
    {
        Task CreateAsync(Employee newEmployee);
        Employee GetById(int employeeId);
        Task UpdateAsync(Employee employee);
        Task UpdateAsync(int id);
        Task Delete(int employeeId);
        decimal UnionFees(int employeeId);
        decimal StudentLoanRepaymentAmount(int employeeId, decimal totalAmount);
        IEnumerable<Employee> GetAll();
    }
}
