using AutoMapper;
using EmployeeDemo.RepositoryInterfaces;
using EmployeeDemo.ServiceInterfaces;
using EmployeeDemo.ViewModel;
using System.Collections.Generic;

namespace EmployeeDemo.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            this._employeeRepository = employeeRepository;
            this._mapper = mapper;
        }

        public IEnumerable<EmployeeViewModel> GetEmployeeList()
        {
            List<EmployeeViewModel> employeeViewModelList = this._mapper.Map<List<EmployeeViewModel>>(this._employeeRepository.GetEmployeeList());

            return employeeViewModelList;
        }
    }
}
