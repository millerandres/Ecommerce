using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required(ErrorMessage = " NO puede ser vacio el campo {0}")]
        [MaxLength(50, ErrorMessage = "El campo {0} de tener maximo {1} caracteres")]
        [Display(Name = "Ciudad")]
        public string Name { get; set; }

        [Required(ErrorMessage = " NO puede ser vacio el campo {0}")]
        [Range(1, Double.MaxValue, ErrorMessage = "Debes seleccionar un {0}")]
       
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Company> Companies { get; set; }


    }
}