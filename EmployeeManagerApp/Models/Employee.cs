using System.ComponentModel.DataAnnotations;

namespace EmployeeManagerApp.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = string.Empty;

        [Required]
        public string Department { get; set; } = string.Empty;

        [Range(1, 1000000)]
        public decimal Salary { get; set; }
    }
}