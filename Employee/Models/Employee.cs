using System.ComponentModel.DataAnnotations;

namespace Employee.Models
{
    public class Employee
    {
        [Key]
        public int employeeId { get; set; }
        [Required]
        public string employeeName { get; set; }
        public int MyProperty { get; set; }
        public string position { get; set; }    
    }
}
