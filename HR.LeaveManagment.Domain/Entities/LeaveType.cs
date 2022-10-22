using HR.LeaveManagment.Domain.Commons;

namespace HR.LeaveManagment.Domain.Entities
{
    public class LeaveType : BaseDomainEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}