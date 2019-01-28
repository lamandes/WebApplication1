using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customerList = new List<Customer>
            {
                new Customer{ Id = 1, Name = "Andes"},
                new Customer{ Id = 2, Name = "Mary"}
            };
            var viewModel = new CustomerViewModels
            {
                CustomerList = customerList
            };
            return View(viewModel);
        }

        [Route("Customer/Detail/{id}")]

        // GET: Customer/Detail/xxxx
        public ActionResult Detail(int id)
        {
            if (id > 2)
            {
                return HttpNotFound();
            }
            else
            {
                if (id == 1)
                {
                    return View(new Customer { Id = 1, Name = "Andes" });
                }
                else
                {
                    return View(new Customer { Id = 2, Name = "Mary" });
                }
            }
        }
    }
}