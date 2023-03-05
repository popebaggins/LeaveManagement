using AutoMapper;
using LeaveManagement.Web.Data;

namespace LeaveManagement.Web.Models.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
