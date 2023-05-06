using Kosta.TestTask.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Kosta.TestTask.Model
{
    public class EmployeeJsonModel
    {

            public decimal ID { get; set; }
            public string SurName { get; set; }

            public string FirstName { get; set; }
            public string? Patronymic { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string DocSeries { get; set; }
            public string DocNumber { get; set; }

            public string Position { get; set; }
            public int Age { get; set; }

    }
}
