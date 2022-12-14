using AutoMapper;
using EmployeeLeaveManagement.Constants;
using EmployeeLeaveManagement.Contracts;
using EmployeeLeaveManagement.Data;
using EmployeeLeaveManagement.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace EmployeeLeaveManagement.Repositories
{
    public class LeaveAllowcationRepository : GenericRepository<LeaveAllocation>, ILeaveAllowcationRepository
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;

        public LeaveAllowcationRepository(ApplicationDbContext context, UserManager<Employee> userManager, 
            ILeaveTypeRepository leaveTypeRepository, IMapper mapper) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
        }

        public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
        {
            return await context.LeaveAllocations.AnyAsync(q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId
            && q.Period == period);
        }

        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
        {
            var allocations = await context.LeaveAllocations
                .Include(q => q.LeaveType)
                .Where(q => q.EmployeeId == employeeId).ToListAsync();
                
            var employee = await userManager.FindByIdAsync(employeeId);

            var employeeAllocationModel = mapper.Map<EmployeeAllocationVM>(employee);
            employeeAllocationModel.LeaveAllocatioins = mapper.Map<List<LeaveAllocationVM>>(allocations);
            return employeeAllocationModel;
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leaveType = await leaveTypeRepository.GetAsync(leaveTypeId);
            var allocations = new List<LeaveAllocation>();

            foreach(var employee in employees)
            {
                if (await AllocationExists(employee.Id, leaveTypeId, period))
                    continue;
                allocations.Add( new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberOfDays = leaveType.DefaultDays
                });
                await AddRangeAsync(allocations);
            }
            //throw new NotImplementedException();
        }

        public Task UpdateEmployeeAllocation(LeaveAllocationEditVM model)
        {
            throw new NotImplementedException();
        }
    }
}
