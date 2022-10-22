using HR.LeaveManagment.Domain.Entities;

namespace HR.LeaveManagment.Application.Persistence.Contracts
{
    internal interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
    }
}