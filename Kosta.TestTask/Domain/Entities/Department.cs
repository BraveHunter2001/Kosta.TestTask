using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kosta.TestTask.Domain.Entities
{
    [Table("Department")]
    public class Department
    {
        [Required]
        [Key]
        public Guid ID { get; set; }
        [ForeignKey("ParentDepartmentID")]
        public Department? ParentDepartment { get; set; }
        [StringLength(10)]
        public string Code { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
        public ICollection<Employee> Employees { get; set; }
    }
}
