using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Index("Department_name_Index", IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
    }
}