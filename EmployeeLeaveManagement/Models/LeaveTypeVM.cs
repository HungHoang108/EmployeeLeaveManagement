using System.ComponentModel.DataAnnotations;

namespace EmployeeLeaveManagement.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "leave Type")]
        [Required]
        public string? Name { get; set; }

        [Display(Name = "Number of Days")]
        [Required]
        [Range(1, 25, ErrorMessage ="Please Enter A Valid Number")]
        public int DefaultDays { get; set; }
    }
}
