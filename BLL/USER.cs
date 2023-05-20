using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class USER
    {
        public void AddUser(DAL.MP_USER user)
        {
            
        }
        public BE.USER GetUser(string email)
        {
            DAL.MP_USER user = new DAL.MP_USER();
            return user.GetUserByEmail(email);

        }
    }
}
