using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class RoleBL
    {
        RoleDA RoleDA = new RoleDA();
        public List<Role> GetAll()
        {
            return RoleDA.GetAll();
        }
    }
}
