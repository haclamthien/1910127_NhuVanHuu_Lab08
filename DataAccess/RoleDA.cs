using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RoleDA
    {
        public List<Role> GetAll()
        {
            SqlConnection sqlConnection = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = Ultilities.Role_GetAll;
            sqlConnection.Open();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Role> roles = new List<Role>();
            while (sqlDataReader.Read())
            {
                roles.Add(new Role(int.Parse(sqlDataReader["ID"].ToString()), sqlDataReader["RoleName"].ToString()));
            }
            
            sqlConnection.Close();
            sqlConnection.Dispose();

            return roles;
        }
    }
}
