using CustomerWebApp_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerWebApp_BL
{
    public class CustomerOperation
    {
        public List<Customer> GetCustomers() 
        {
            CustomerWebApp_DAL.DBOperation.CustomerDBOperation customerDBOperation = new CustomerWebApp_DAL.DBOperation.CustomerDBOperation();
            return customerDBOperation.GetCustomers();
        
        }

        public Customer GetCustomer(int CustomerID) 
        {
            CustomerWebApp_DAL.DBOperation.CustomerDBOperation customerDBOperation = new CustomerWebApp_DAL.DBOperation.CustomerDBOperation();
            return customerDBOperation.GetCustomer(CustomerID);
        }

        public void AddCustomer(Customer customer)
        {
            CustomerWebApp_DAL.DBOperation.CustomerDBOperation customerDBOperation = new CustomerWebApp_DAL.DBOperation.CustomerDBOperation();
            customerDBOperation.AddCustomer(customer);

        }

        public void UpdateCustomer(Customer customer)
        {
            CustomerWebApp_DAL.DBOperation.CustomerDBOperation customerDBOperation = new CustomerWebApp_DAL.DBOperation.CustomerDBOperation();
            customerDBOperation.UpdateCustomer(customer);
        }
        public void DeleteCustomer(int CustomerID)
        {
            CustomerWebApp_DAL.DBOperation.CustomerDBOperation customerDBOperation = new CustomerWebApp_DAL.DBOperation.CustomerDBOperation();
            customerDBOperation.DeleteCustomer(CustomerID);
        }

        public List<string> GetStates()
        {
            CustomerWebApp_DAL.DBOperation.StateDBOperation stateDBOperation = new CustomerWebApp_DAL.DBOperation.StateDBOperation();
            List<string> stateLists = stateDBOperation.GetStates();
            return stateLists;
        }
    }
}
