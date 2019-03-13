using EmployeeDemo.ViewModel;
using System.Collections.Generic;

namespace EmployeeDemo.ServiceInterfaces
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeViewModel> GetEmployeeList();
    }
}
