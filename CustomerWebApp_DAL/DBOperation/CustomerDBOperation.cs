using CustomerWebApp_DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerWebApp_DAL.DBOperation
{
    public class CustomerDBOperation
    {
        string connString = "Data Source=DESKTOP-AOVI42O\\SQLEXPRESS;Initial Catalog=CustomerManagementSystem;Integrated Security=True";
        public List<Customer> GetCustomers() 
        { 
            List<Customer> customerList = new List<Customer>();
            SqlConnection sqlConnection = new SqlConnection(connString);
            try 
            {
                sqlConnection.Open();
                SqlCommand command = sqlConnection.CreateCommand();
                command.CommandText = "select * from Customers";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerID = Convert.ToInt32(reader[0].ToString());
                    customer.Salutation = reader[1].ToString();
                    customer.FirstName = reader[2].ToString();
                    customer.LastName = reader[3].ToString();
                    customer.DOB = Convert.ToDateTime(reader[4].ToString());
                    customer.SSN = reader[5].ToString();
                    customer.AddressLine1 = reader[6].ToString();
                    customer.AddressLine2 = reader[7].ToString();
                    customer.City = reader[8].ToString();
                    customer.State = reader[9].ToString(); 
                    customer.ZipCode = reader[10].ToString();
                    customer.PhoneNumber = reader[11].ToString();
                    customer.EmailAddress = reader[12].ToString();
                    customer.CreatedOn = Convert.ToDateTime(reader[13].ToString());
                    customerList.Add(customer);
                }

            }

            catch 
            { 
            
            }
            sqlConnection.Close();

            return customerList;

        }



        public Customer GetCustomer(int CustomerID)
        {
            Customer customer = new Customer();
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
               
                sqlConnection.Open();
                SqlCommand command = sqlConnection.CreateCommand();
                command.CommandText = "select * from Customers where CustomerID = " + CustomerID;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    customer.CustomerID = Convert.ToInt32(reader[0].ToString());
                    customer.Salutation = reader[1].ToString();
                    customer.FirstName = reader[2].ToString();
                    customer.LastName = reader[3].ToString();
                    customer.DOB = Convert.ToDateTime(reader[4].ToString());
                    customer.SSN = reader[5].ToString();
                    customer.AddressLine1 = reader[6].ToString();
                    customer.AddressLine2 = reader[7].ToString();
                    customer.City = reader[8].ToString();
                    customer.State = reader[9].ToString();
                    customer.ZipCode = reader[10].ToString();
                    customer.PhoneNumber = reader[11].ToString();
                    customer.EmailAddress = reader[12].ToString();
                    customer.CreatedOn = Convert.ToDateTime(reader[13].ToString());
                   
                }

            }

            catch
            {

            }
            sqlConnection.Close();

            return customer;

            

        }

        public void AddCustomer(Customer customer)
        {
            
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                SqlCommand command = sqlConnection.CreateCommand();
                command.CommandText = "spInsertCustomer";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter() { ParameterName = "@Salutation", Value = customer.Salutation });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@FirstName", Value = customer.FirstName });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@LastName", Value = customer.LastName });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@DOB", Value = customer.DOB });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@SSN", Value = customer.SSN });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@AddressLine1", Value = customer.AddressLine1 });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@AddressLine2", Value = customer.AddressLine2 });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@City", Value = customer.City });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@State", Value = customer.State });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@ZipCode", Value = customer.ZipCode });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@PhoneNumber", Value = customer.PhoneNumber });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@EmailAddress", Value = customer.EmailAddress });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@CreatedOn", Value = customer.CreatedOn });

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            sqlConnection.Close();
        }


        public void UpdateCustomer(Customer customer)
        {

            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                SqlCommand command = sqlConnection.CreateCommand();
                command.CommandText = "spUpdateCustomer";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter() { ParameterName = "@CustomerID", Value = customer.CustomerID });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@Salutation", Value = customer.Salutation });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@FirstName", Value = customer.FirstName });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@LastName", Value = customer.LastName });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@DOB", Value = customer.DOB });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@SSN", Value = customer.SSN });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@AddressLine1", Value = customer.AddressLine1 });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@AddressLine2", Value = customer.AddressLine2 });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@City", Value = customer.City });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@State", Value = customer.State });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@ZipCode", Value = customer.ZipCode });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@PhoneNumber", Value = customer.PhoneNumber });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@EmailAddress", Value = customer.EmailAddress });
                command.Parameters.Add(new SqlParameter() { ParameterName = "@CreatedOn", Value = customer.CreatedOn });

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            sqlConnection.Close();
        }

        public void DeleteCustomer(int CustomerID)
        {
           
            SqlConnection sqlConnection = new SqlConnection(connString);
            try
            {
                sqlConnection.Open();
                SqlCommand command = sqlConnection.CreateCommand();
                command.CommandText = "spDeleteCustomer";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter() { ParameterName = "@CustomerID", Value = CustomerID });
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            sqlConnection.Close();
        }


        public List<string> GetStates()
        {
            List<string> stateList = new List<string>();
            SqlConnection sqlConnection = new SqlConnection(connString);

            sqlConnection.Open();
            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = "spGetStates";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                stateList.Add(reader[0].ToString());
            }

            sqlConnection.Close();
            return stateList;

        }
    }


}


