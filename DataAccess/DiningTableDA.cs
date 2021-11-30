using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DiningTableDA
    {
        public List<DiningTable> GetAll()
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand command = sqlConn.CreateCommand();
            //command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.DiningTable_GetAll;
            sqlConn.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<DiningTable> list = new List<DiningTable>();
            while (reader.Read())
            {
                DiningTable diningTable = new DiningTable();
                diningTable.ID = Convert.ToInt32(reader["ID"]);
                diningTable.Name = reader["Name"].ToString();
                diningTable.Status = Convert.ToInt32(reader["Status"]);
                diningTable.Capacity = Convert.ToInt32(reader["Capacity"]);
                list.Add(diningTable);
            }
            sqlConn.Close();
            sqlConn.Dispose();
            return list;
        }
        public void ResetStatus(int TableID)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand command = sqlConn.CreateCommand();
            //command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.DiningTable_ResetStatus;
            sqlConn.Open();

            command.Parameters.Add("@TableID", System.Data.SqlDbType.Int).Value = TableID;
            command.ExecuteNonQuery();
            sqlConn.Close();
        }
        public int MoveTable(int BeMoveTableID, int TableID)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand command = sqlConn.CreateCommand();
            //command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.DiningTable_Move;
            sqlConn.Open();
            command.Parameters.Add("@BeMoveTableID", System.Data.SqlDbType.Int).Value = BeMoveTableID;
            command.Parameters.Add("@TableID", System.Data.SqlDbType.Int).Value = TableID;
            int num = command.ExecuteNonQuery();
            sqlConn.Close();
            return num;
        }
        public int PoolTable(int BePoolTableID, int TableID)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand command = sqlConn.CreateCommand();
            //command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.DiningTable_Pool;
            sqlConn.Open();
            command.Parameters.Add("@BePoolTableID", System.Data.SqlDbType.Int).Value = BePoolTableID;
            command.Parameters.Add("@TableID", System.Data.SqlDbType.Int).Value = TableID;
            int num = command.ExecuteNonQuery();
            sqlConn.Close();
            return num;
        }
        public int InsertUpdateDelete(DiningTable table, int action)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.DiningTable_InsertUpdateDelete;

            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;
            command.Parameters.Add(IDPara).Value = table.ID;
            command.Parameters.Add("@Name", SqlDbType.NVarChar, 1000).Value = table.Name;
            command.Parameters.Add("@Status", SqlDbType.Int).Value = table.Status;
            command.Parameters.Add("@Capacity", SqlDbType.Int).Value = table.Capacity;
            command.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            int result = command.ExecuteNonQuery();
            if (result > 0)
                return (int)command.Parameters["@ID"].Value;
            return 0;
        }

    }
}
