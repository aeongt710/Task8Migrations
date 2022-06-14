using System.ComponentModel.DataAnnotations;

namespace Task8Migrations.Models
{
    public class Model
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
    public class Department
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string DepartmentName { get; set; }
        [Required]
        public string Block { get; set; }
    }
}
