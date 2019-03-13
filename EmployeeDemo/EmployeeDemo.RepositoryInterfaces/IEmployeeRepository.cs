using EmployeeDemo.DataModel;
using System.Collections.Generic;

namespace EmployeeDemo.RepositoryInterfaces
{
    public interface IEmployeeRepository
    {
        List<EmployeeDataModel> GetEmployeeList();
    }
}
