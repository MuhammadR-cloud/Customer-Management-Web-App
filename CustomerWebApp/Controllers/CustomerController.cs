using CustomerWebApp_BL;
using CustomerWebApp_DAL.Model;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerWebApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            CustomerOperation customerOperation = new CustomerOperation();
            List<Customer> customerList = customerOperation.GetCustomers();
            return View(customerList);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            CustomerOperation customerOperation = new CustomerOperation();
            customerOperation.GetCustomer(id);
            return View(customerOperation.GetCustomer(id));
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            Customer customer = new Customer();

            customer.SalutationList = new List<string>
            {
                "Mr.",
                "Ms.",
                "Mrs.",
                "Dr.",
                "Engg."
            };

            customer.StateList = new List<string>();
            CustomerOperation customerOperation = new CustomerOperation();
            customer.StateList = customerOperation.GetStates();
            return View(customer);
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    CustomerOperation customerOperation = new CustomerOperation();
                    customerOperation.AddCustomer(customer);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            CustomerOperation customerOperation = new CustomerOperation();
            List<Customer> Customers = customerOperation.GetCustomers();
            Customer customer = Customers.Find(i => i.CustomerID == id);

            return View(customer);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit( Customer customer)
        {
            try
            {
                // TODO: Add update logic here
                CustomerOperation customerOperation = new CustomerOperation();
                customerOperation.UpdateCustomer(customer);


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            CustomerOperation customerOperation = new CustomerOperation();
            List<Customer> Customers = customerOperation.GetCustomers();
            Customer customer = Customers.Find(i => i.CustomerID == id);
            return View(customer);
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete( int id, Customer customer)
        {
            try
            {
                CustomerOperation customerOperation = new CustomerOperation();
                customerOperation.DeleteCustomer(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            
        }
    }
}
