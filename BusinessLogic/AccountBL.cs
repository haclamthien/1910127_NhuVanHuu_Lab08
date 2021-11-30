using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class AccountBL
    {
        AccountDA accountDA = new AccountDA();
        public DataTable GetAll()
        {
            return accountDA.GetAll();
        }
        public DataTable GetDataToLoad()
        {
            return accountDA.GetDataToLoad();
        }
        public int Insert(Account account, string roleID, string stt)
        {
            return accountDA.Insert(account, roleID, stt);
        }
    }
}
