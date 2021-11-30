using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class BillDetailBL
    {
        BillDetailDA billDetailDA = new BillDetailDA();
        public int Insert(int BillID, int FoodID, int Quantily)
        {
            return billDetailDA.Insert(BillID, FoodID, Quantily);
        }
        public void Delete(int billDetailID)
        {
            billDetailDA.Delete(billDetailID);
        }
        public string SumQuantily(int FoodID)
        {
            return billDetailDA.SumQuantily(FoodID);
        }
        public DataTable GetFood(int billID)
        {
            return billDetailDA.GetFood(billID);
        }
    }
}
