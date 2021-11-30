using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BillDetailDA
    {
        public int Insert(int BillID, int FoodID, int Quantily)
        {
            List<BillDetail> bills = new List<BillDetail>();
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            // command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.BillDetail_Insert;

            command.Parameters.Add("@IDD", SqlDbType.Int).Direction = ParameterDirection.Output;
            command.Parameters.Add("@BillID", SqlDbType.Int).Value = BillID;
            command.Parameters.Add("@FoodID", SqlDbType.Int).Value = FoodID;
            command.Parameters.Add("@Quantity", SqlDbType.Int).Value = Quantily;

            int num = command.ExecuteNonQuery();
            sqlConn.Close();
            if (num > 0)
            {
                return int.Parse(command.Parameters["@IDD"].Value.ToString());
            }
            return 0;
        }
        public void Delete(int billDetailID)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            // command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.BillDetail_Delete;

            command.Parameters.Add("@ID", SqlDbType.Int).Value = billDetailID;

            int num = command.ExecuteNonQuery();
            sqlConn.Close();
        }
        public string SumQuantily(int FoodID)
        {
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();

            SqlCommand command = sqlConn.CreateCommand();
            // command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.BillDetail_SumQuantily;

            command.Parameters.Add("@foodID", SqlDbType.Int).Value = FoodID;
            command.Parameters.Add("@numQuantily", SqlDbType.Int).Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            string result = "0";
            if (command.Parameters["@numQuantily"].Value != null)
                result = command.Parameters["@numQuantily"].Value.ToString();
            else
                result = "-1";
            sqlConn.Close();
            return result;
        }
        public DataTable GetFood(int BillID)
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = Ultilities.BillDetail_GetFood;

            sqlCommand.Parameters.Add("@BillID", SqlDbType.Int).Value = BillID;
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
