using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kosta.TestTask.Domain.Entities
{
    [Table("Empoyee")]
    public class Employee
    {
        [Required]
        [Key]
        public decimal ID { get; set; }
        [Required]
        public Guid? DepartmentID { get; set; }
        [Required]
        [ForeignKey("DepartmentID")]
        public Department Department { get; set; }
        [Required]
        public string SurName { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string? Patronymic { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public string DocSeries { get; set; }
        public string DocNumber { get; set; }
        [Required]
        public string Position { get; set; }
        [NotMapped]
        public int Age
        {
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }


    }
}