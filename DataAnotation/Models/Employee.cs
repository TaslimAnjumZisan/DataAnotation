using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnotation.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Employee name")]
        [Required(ErrorMessage ="Employee name  is required")]
        [StringLength(50)]
        public string Name { get; set; }    

        public string Address { get; set; }

        public decimal Salary { get; set; }

        public string Email { get; set; }
    }
}