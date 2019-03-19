using AutoMapper;
using EmployeeDemo.DataModel;
using EmployeeDemo.RepositoryInterfaces;
using EmployeeDemo.ServiceInterfaces;
using EmployeeDemo.Services.Mapping;
using EmployeeDemo.ViewModel;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeDemo.Services.Tests
{
    [TestFixture]
    public class EmployeeServiceUnitTests
    {
        private IEmployeeService EmployeeService { get; set; }

        private Mock<IEmployeeRepository> EmployeeRepositoryMock { get; set; }

        private Mock<IMapper> MapperMock { get; set; }

        private IMapper _mapper;

        [SetUp]
        public void Arrange()
        {
            this._mapper = new Mapper(new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            }));

            this.EmployeeRepositoryMock = new Mock<IEmployeeRepository>();
            this.MapperMock = new Mock<IMapper>();
            this.EmployeeService = new EmployeeService(this.EmployeeRepositoryMock.Object, this._mapper);
        }

        [Test]
        public void Should_Return_EmployeeList()
        {
            List<EmployeeDataModel> employeeDataModelList = this.GetEmployeeList();

            this.EmployeeRepositoryMock.Setup(x => x.GetEmployeeList())
                .Returns(employeeDataModelList);

            IEnumerable<EmployeeViewModel> result = this.EmployeeService.GetEmployeeList();

            Assert.IsTrue(result.Count() > 0);
        }

        private List<EmployeeDataModel> GetEmployeeList()
        {
            var employeeDataModelList = new List<EmployeeDataModel>()
            {
                new EmployeeDataModel{EmployeeId = 1, EmployeeName = "John", Age = 22, Address = "USA"},
                new EmployeeDataModel{EmployeeId = 1, EmployeeName = "Steve", Age = 24, Address = "UK"},
                new EmployeeDataModel{EmployeeId = 1, EmployeeName = "Sachin", Age = 32, Address = "INDIA"}
            };

            return employeeDataModelList;

        }
    }
}
