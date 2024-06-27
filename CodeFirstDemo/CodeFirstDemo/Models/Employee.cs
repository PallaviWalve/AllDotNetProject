using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstDemo.Models
{
    [Table("Emp")]
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [Required(ErrorMessage = "Name is Compulsory", AllowEmptyStrings = false)]
        [StringLength(50)]
        [MinLength(2, ErrorMessage = "Enter atleast 2 chars name")]
        [MaxLength(50, ErrorMessage = "Max Allowed name is 50 chars")]
        public string Empname { get; set; }

        [EmailAddress(ErrorMessage = "Need a valid Email Id")]
        public string Email { get; set; }

        [Range(10000,90000, ErrorMessage = "Salary Not In Range")]
        [Required]
        public long Salary { get; set; }
    }
}
