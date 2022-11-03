using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeLeaveManagement.Data
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateMotified { get; set; }
    }
}
