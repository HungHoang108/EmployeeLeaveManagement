using EmployeeLeaveManagement.Contracts;
using EmployeeLeaveManagement.Data;

namespace EmployeeLeaveManagement.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
