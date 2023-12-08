using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerWebApp_DAL.DBOperation
{
    public class StateDBOperation
    {
        string connString = "Data Source=DESKTOP-AOVI42O\\SQLEXPRESS;Initial Catalog=CustomerManagementSystem;Integrated Security=True";
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
