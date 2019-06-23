using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = " NO puede ser vacio el campo {0}")]
        [MaxLength(50,ErrorMessage = "El campo {0} de tener maximo {1} caracteres")]
        [Display(Name = "Departamento")]
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}