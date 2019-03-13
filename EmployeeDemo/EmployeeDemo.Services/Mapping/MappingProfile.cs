using AutoMapper;
using EmployeeDemo.DataModel;
using EmployeeDemo.ViewModel;

namespace EmployeeDemo.Services.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeViewModel, EmployeeDataModel>().ReverseMap();
        }
    }
}
