using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _06._01._2022_ASP_SimpleCRUD.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }

        [MinLength(10), MaxLength(50)]
        public string Name { get; set; }

        public List<Employee> Employees = new List<Employee>();
    }
}
