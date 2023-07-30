using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Login
    {
        CD_Login cD_Login = new CD_Login();
        public bool LoginUser(string username, string password)
        {
            return cD_Login.Login(username, password);
        }

      
    }


}
