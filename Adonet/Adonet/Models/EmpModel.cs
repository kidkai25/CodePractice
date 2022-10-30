using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Adonet.Models
{
    public class EmpModel
    {
        [Display(Name = "Id")]
        public int Empid { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        public int Age { get; set; }
    }
}