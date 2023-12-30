using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstCore6.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Column("EmployeeID",TypeName = "varchar(20)")]
        [Required]
        public string EmpID { get; set; }

        [Column("FirstName", TypeName = "varchar(50)")]
        [Required]
        public string FirstName { get; set; }

        [Column("LastName", TypeName = "varchar(50)")]
        [Required]
        public string LastName { get; set; }
        public DateTime DOB { get; set; }

        [Column("Gender", TypeName = "varchar(10)")]
        public string Gender { get; set; }
        [Column("Department", TypeName = "varchar(50)")]
        [Required]
        public string Department { get; set; }  
    }
}
