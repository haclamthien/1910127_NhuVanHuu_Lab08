using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AccountDA
    {
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand command = sqlConn.CreateCommand();
            //command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Account_GetAll;
            sqlConn.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            sqlDataAdapter.Fill(dt);

            sqlConn.Close();
            return dt;
        }
        public DataTable GetDataToLoad()
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            
            sqlCommand.CommandText = Ultilities.Account_LoadData;
            sqlConnection.Open();

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Accounts");
            da.Fill(dt);
            return dt;
        }
        public int Insert (Account account, string roleID, string stt)
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = Ultilities.Account_Insert;

            sqlCommand.Parameters.Add("@AccountName", SqlDbType.NVarChar, 100).Value = account.AccountName;
            sqlCommand.Parameters.Add("@FullName", SqlDbType.NVarChar, 1000).Value = account.FullName;
            sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 1000).Value = account.Email;
            sqlCommand.Parameters.Add("@Tell", SqlDbType.NVarChar, 200).Value = account.Tell;

            sqlCommand.Parameters.Add("@Active", SqlDbType.Bit).Value = stt == "1" ? 1 : 0;
            try { sqlCommand.Parameters.Add("@RoleId", SqlDbType.Int).Value = int.Parse(roleID);} catch (Exception ex) { }


            sqlConnection.Open();
            int num = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            sqlConnection.Dispose();
            return num;
        }
    }
}
