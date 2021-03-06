﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            var customers = getCustomer();
            return View(customers);
        }

        public ActionResult Details(int Id)
        {
            var customer = getCustomer().SingleOrDefault(c => c.Id == Id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }


        private IEnumerable<Customer> getCustomer()
        {
            var customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "Cristiano Ronaldo" },
                new Customer {Id = 2, Name = "Lionel Messi" }
            };
            return customers;
        }
    }
}