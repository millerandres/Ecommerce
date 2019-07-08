using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = " NO puede ser vacio el campo {0}")]
        [MaxLength(50, ErrorMessage = "El campo {0} de tener maximo {1} caracteres")]
        [Display(Name = "Name")]
        [Index("Company_name_Index", IsUnique = true)]
        public string Name { get; set; }

        [Required(ErrorMessage = " NO puede ser vacio el campo {0}")]
        [MaxLength(20, ErrorMessage = "El campo {0} de tener maximo {1} caracteres")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = " NO puede ser vacio el campo {0}")]
        [MaxLength(100, ErrorMessage = "El campo {0} de tener maximo {1} caracteres")] 
        public string Address { get; set; }

        
        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }

        [NotMapped]
        public HttpPostedFileBase LogoFile { get; set; }

        [Required(ErrorMessage = " NO puede ser vacio el campo {0}")]
        [Range(1, Double.MaxValue, ErrorMessage = "Debes seleccionar un {0}")]
        [Display(Name = "Departamento")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = " NO puede ser vacio el campo {0}")]
        [Range(1, Double.MaxValue, ErrorMessage = "Debes seleccionar un {0}")]
        [Display(Name = "Ciudad")]
        public int CityId { get; set; }


        public virtual Department Department { get; set; }

        public virtual City City { get; set; }


        
    }
}