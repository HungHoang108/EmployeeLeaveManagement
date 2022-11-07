using AutoMapper;
using EmployeeLeaveManagement.Data;
using EmployeeLeaveManagement.Models;

namespace EmployeeLeaveManagement.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }

    }
}
