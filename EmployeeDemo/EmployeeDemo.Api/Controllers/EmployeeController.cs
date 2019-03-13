using System;
using System.Collections.Generic;
using EmployeeDemo.ServiceInterfaces;
using EmployeeDemo.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }

        [HttpGet]
        [Route("GetEmployeeList")]
        public ActionResult<IEnumerable<EmployeeViewModel>> GetEmployeeList()
        {
            IEnumerable<EmployeeViewModel> employeeViewModelList = new List<EmployeeViewModel>();

            try
            {
                employeeViewModelList = this._employeeService.GetEmployeeList();
            }
            catch (Exception)
            {
                // TODO: handle exception
            }

            return Ok(employeeViewModelList);
        }
    }
}