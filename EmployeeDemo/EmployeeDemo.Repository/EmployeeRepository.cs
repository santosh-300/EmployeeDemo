using System.Collections.Generic;
using EmployeeDemo.DataModel;
using EmployeeDemo.RepositoryInterfaces;

namespace EmployeeDemo.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<EmployeeDataModel> GetEmployeeList()
        {
            // TODO: get it from db

            return GetEmployeeData();
        }

        private List<EmployeeDataModel> GetEmployeeData()
        {
            List<EmployeeDataModel> employeeDataModelList = new List<EmployeeDataModel>
            {
                new EmployeeDataModel{EmployeeId = 1, EmployeeName = "John", Age = 25, Address = "USA"},
                new EmployeeDataModel{EmployeeId = 1, EmployeeName = "Jack", Age = 25, Address = "UK"},
                new EmployeeDataModel{EmployeeId = 1, EmployeeName = "Mark", Age = 25, Address = "Australia"},
                new EmployeeDataModel{EmployeeId = 1, EmployeeName = "Steve", Age = 25, Address = "USA"},
                new EmployeeDataModel{EmployeeId = 1, EmployeeName = "Ryan", Age = 25, Address = "USA"},
            };

            return employeeDataModelList;
        }
    }
}
