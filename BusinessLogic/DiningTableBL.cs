using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class DiningTableBL
    {
        DiningTableDA diningTableDA = new DiningTableDA();
        public List<DiningTable> GetAll()
        {
            return diningTableDA.GetAll();
        }
        public void ResetStatus(int TableID)
        {
            diningTableDA.ResetStatus(TableID);
        }
        public int MoveTable(int BeMoveTableID, int TableID)
        {
          return  diningTableDA.MoveTable(BeMoveTableID, TableID);
        }
        public int PoolTable(int BePoolTableID, int TableID)
        {
            return diningTableDA.PoolTable(BePoolTableID, TableID);
        }
        public int Insert(DiningTable table)
        {
            return diningTableDA.InsertUpdateDelete(table, 0);
        }
        public int Update(DiningTable table)
        {
            return diningTableDA.InsertUpdateDelete(table, 1);
            
        }
        public int Delete(DiningTable table)
        {
            return diningTableDA.InsertUpdateDelete(table, 2);
        }
    }
}
