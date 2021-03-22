using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Lf
{
    class Usuarios
    {
        User_Datos user_datos = new User_Datos();
        public bool login_user(string user, string pass)
        {
            return user_datos.Login(user, pass);
        }
    }
}
