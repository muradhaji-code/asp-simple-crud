using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _06._01._2022_ASP_SimpleCRUD.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [MinLength(6), MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Fullname { get; set; }

        public int Age { get; set; }

        [ForeignKey("Employee")]
        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
