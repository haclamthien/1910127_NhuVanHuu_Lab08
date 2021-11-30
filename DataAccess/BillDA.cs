using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BillDA
    {
        public int Insert(int TableID, string AccountName)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
           // command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Bill_Insert;

            command.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
            command.Parameters.Add("@TableID", SqlDbType.Int).Value = TableID;
            command.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100).Value = AccountName;

            int num = command.ExecuteNonQuery();
            sqlConn.Close();
            if (num > 0)
            {
                return int.Parse(command.Parameters["@ID"].Value.ToString());
            }
            return 0;
        }
        public int GetBillHaveNotCheckOutByTableID(int tableID)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            // command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Bill_GetBillHaveNotCheckOutByTableID;
            command.Parameters.Add("@tableID", SqlDbType.Int).Value = tableID;
            int kq = 0;
            if(command.ExecuteScalar()!=null)
                kq = (int)command.ExecuteScalar();
            //try { kq = (int)command.ExecuteScalar(); }
            //catch (Exception ex) { }
            sqlConn.Close();
            return kq;

        }
        public void Pay(int tableID, int BillID, int Amount,  float Discount)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandText = Ultilities.Bill_Pay;
            command.Parameters.Add("@tableID", SqlDbType.Int).Value = tableID;
            command.Parameters.Add("@BillID", SqlDbType.Int).Value = BillID;
            command.Parameters.Add("@Amount", SqlDbType.Int).Value = Amount;
            command.Parameters.Add("@Discount", SqlDbType.Float).Value = Math.Round(Discount, 2);

            command.ExecuteNonQuery();
            sqlConn.Close();
        }
        public void Delete(int billID)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            command.CommandText = Ultilities.Bill_Delete;
            command.Parameters.Add("@BillID", SqlDbType.Int).Value = billID;
            
            command.ExecuteNonQuery();
            sqlConn.Close();
        }
        public DataTable GetByDateAndTableID(int TableId, String date)
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = Ultilities.Bill_GetByDateAndTableID;

            sqlCommand.Parameters.Add("@TableID", SqlDbType.Int).Value = TableId;
            sqlCommand.Parameters.Add("@Date", SqlDbType.Date).Value = date;
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }
        public int GetSalary(int TableId, String date)
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = Ultilities.Bill_GetSalary;

            sqlCommand.Parameters.Add("@TableID", SqlDbType.Int).Value = TableId;
            sqlCommand.Parameters.Add("@Date", SqlDbType.Date).Value = date;
            sqlConnection.Open();
            return int.Parse(sqlCommand.ExecuteScalar().ToString());
        }
        public int GetSalary(String date)
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = Ultilities.Bill_GetSalaryAllDay;

            sqlCommand.Parameters.Add("@Date", SqlDbType.Date).Value = date;
            sqlConnection.Open();
            return int.Parse(sqlCommand.ExecuteScalar().ToString());
        }
        public DataTable GetByDate(String date)
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = Ultilities.Bill_GetByDate;

            sqlCommand.Parameters.Add("@Date", SqlDbType.Date).Value = date;
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            sqlConnection.Close();
            sqlConnection.Dispose();
            return dt;
        }
    }
}
