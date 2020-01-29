using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department {Id= 1, Name = "Calçados" });
            list.Add(new Department { Id = 2, Name = "Roupas" });
            return View(list);
        }
    }
}
