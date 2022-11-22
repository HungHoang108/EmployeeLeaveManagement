using EmployeeLeaveManagement.Data;
using EmployeeLeaveManagement.Models;
using static EmployeeLeaveManagement.Contracts.IGenericRepository;

namespace EmployeeLeaveManagement.Contracts
{
    public interface ILeaveAllowcationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation (int LeaveTypeId);
        Task<bool> AllocationExists (string employeeId, int leaveTypeId, int period);
        Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId);
        Task UpdateEmployeeAllocation(LeaveAllocationEditVM model);
    }
}
