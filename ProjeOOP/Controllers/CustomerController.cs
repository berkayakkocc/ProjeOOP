using Microsoft.AspNetCore.Mvc;
using ProjeOOP.Entity;
using ProjeOOP.ProjectContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeOOP.Controllers
{
    public class CustomerController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Customers.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            context.Add(customer);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCustomer(int id)
        {
            var value = context.Customers.Where(x => x.Id == id).FirstOrDefault();
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
          var value=context.Customers.Where(x => x.Id == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
           var value= context.Customers.Where(x => x.Id == customer.Id).FirstOrDefault();
            value.Name = customer.Name;
            value.City = customer.City;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
