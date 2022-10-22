using AutoMapper;
using HR.LeaveManagment.Application.DTOs;
using HR.LeaveManagment.Application.DTOs.LeaveRequest;
using HR.LeaveManagment.Domain.Entities;

namespace HR.LeaveManagment.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
              CreateMap<LeaveRequest,LeaveRequestDto>().ReverseMap();
              CreateMap<LeaveRequest,LeaveRequestListDto>().ReverseMap();
              CreateMap<LeaveType,LeaveTypeDto>().ReverseMap();
              CreateMap<LeaveAllocation,LeaveAllocationDto>().ReverseMap();
        }
    }
}