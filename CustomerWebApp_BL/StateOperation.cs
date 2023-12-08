using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerWebApp_BL
{
    public class StateOperation
    {
        public List<string> GetStates()
        {
            CustomerWebApp_DAL.DBOperation.StateDBOperation stateDBOperation = new CustomerWebApp_DAL.DBOperation.StateDBOperation();
            List<string> stateLists = stateDBOperation.GetStates();
            return stateLists;
        }
    }
}
