using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class EcommerceContext: DbContext
    {
        public EcommerceContext() : base("DefaultConnection")
        {

        }

        public DbSet<Department> Departments { get; set; }

        public System.Data.Entity.DbSet<Ecommerce.Models.City> Cities { get; set; }

       
    }
}