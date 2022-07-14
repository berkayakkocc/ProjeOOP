using Microsoft.AspNetCore.Mvc;
using ProjeOOP.ProjectContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeOOP.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Products.ToList();
            return View(values);
        }
    }
}
