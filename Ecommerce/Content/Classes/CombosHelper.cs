using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Content.Clases
{

    


    public class CombosHelper : IDisposable
    {
        private static EcommerceContext db = new EcommerceContext();

        public static List<Department> GetDepartments()
        {
            var departments = db.Departments.ToList();
            departments.Add(new Department
            {
                DepartmentId = 0,
                Name =  "[select a department]",
            });

            return departments.OrderBy(d => d.Name).ToList();
        }

        public static List<City> GetCities()
        {
            var cities = db.Cities.ToList();
            cities.Add(new City
            {
                CityId = 0,
                Name = "[Seleccione una ciudad]",
            });

            return cities.OrderBy(d => d.Name).ToList();
        }





        public void Dispose()
        {
            db.Dispose();
        }
    }
}