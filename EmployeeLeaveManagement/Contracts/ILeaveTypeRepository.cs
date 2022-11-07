using EmployeeLeaveManagement.Data;
using static EmployeeLeaveManagement.Contracts.IGenericRepository;

namespace EmployeeLeaveManagement.Contracts
{
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
        
    }
}
