using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class BillBL
    {
        BillDA billDA = new BillDA();
        public int Insert(int TableID, string AccountName)
        {
            return billDA.Insert(TableID, AccountName);
        }
        public int GetBillHaveNotCheckOutByTableID(int tableID)
        {
            return billDA.GetBillHaveNotCheckOutByTableID(tableID);
        }
        public void Pay(int tableID, int BillID, int Amount, float Discount)
        {
            billDA.Pay(tableID, BillID, Amount, Discount);
        }
        public void Delete(int billID)
        {
            billDA.Delete(billID);
        }
        public DataTable GetByDateAndTableID(int TableID, String date)
        {
            return billDA.GetByDateAndTableID(TableID, date);
        }
        public int GetSalary(int TableID, String date)
        {
            return billDA.GetSalary(TableID, date);
        }
        public int GetSalary(String date)
        {
            return billDA.GetSalary(date);
        }
        public DataTable GetByDate(String date)
        {
            return billDA.GetByDate(date);
        }
    }
}
