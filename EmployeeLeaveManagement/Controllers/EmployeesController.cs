using AutoMapper;
using EmployeeLeaveManagement.Constants;
using EmployeeLeaveManagement.Contracts;
using EmployeeLeaveManagement.Data;
using EmployeeLeaveManagement.Models;
using EmployeeLeaveManagement.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeLeaveManagement.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly UserManager<Employee> userManager;
        private readonly IMapper mapper;
        private readonly ILeaveAllowcationRepository leaveAllowcationRepository;
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public EmployeesController(UserManager<Employee> userManager, IMapper mapper, ILeaveAllowcationRepository leaveAllowcationRepository,
            ILeaveTypeRepository leaveTypeRepository)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.leaveAllowcationRepository = leaveAllowcationRepository;
            this.leaveTypeRepository = leaveTypeRepository;
        }
        // GET: EmployeesController
        public async Task<ActionResult> Index()
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var model = mapper.Map<List<EmployeeListVM>> (employees);
            return View(model);
        }

        // GET: EmployeesController/ViewAllocations/5
        public async Task<ActionResult> ViewAllocations(string id)
        {
            var model = await leaveAllowcationRepository.GetEmployeeAllocations(id);
            return View(model);
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/EditAllocation/5
        public async Task<ActionResult> EditAllocation(int id)
        {
            var leaveAllocation = await leaveAllowcationRepository.GetAsync(id);
            if(leaveAllocation == null)
            {
                return NotFound();
            }

            var model = mapper.Map<LeaveAllocationEditVM>(leaveAllocation);
            model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(leaveAllocation.EmployeeId));
            return View(model);
        }

        // POST: EmployeesController/EditAllocation/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAllocation(int id, LeaveAllocationEditVM model)
        {
            try
            {
                if(ModelState.IsValid)
                {

                    var leaveAllocation = await leaveAllowcationRepository.GetAsync(model.Id);
                    if(leaveAllocation == null)
                    {
                        return NotFound();
                    }
                    leaveAllocation.Period = model.Period;
                    leaveAllocation.NumberOfDays = model.NumberOfDays;
                    await leaveAllowcationRepository.UpdateAsync(leaveAllocation);
                    return RedirectToAction(nameof(ViewAllocations), new { id = model.EmployeeId });

                }


            }
            catch (Exception ex) 
            {
                ModelState.AddModelError(string.Empty, "Error, pls try again");
                return View();
            }
            model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(model.EmployeeId));
            model.LeaveType = mapper.Map<LeaveTypeVM>(await leaveTypeRepository.GetAsync(model.LeaveTypeId));
            return View(model);
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
