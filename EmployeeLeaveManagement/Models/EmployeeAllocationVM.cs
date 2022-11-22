using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace EmployeeLeaveManagement.Models
{
    public class EmployeeAllocationVM : EmployeeListVM
    {
        public List<LeaveAllocationVM>? LeaveAllocatioins { get; set; }
    }
}
