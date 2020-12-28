using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Dominio
{
    public class ModeloUsuario
    {
        DataUser DataUser = new DataUser();
        public bool LoginUser(string user, string pass)
        {
            return DataUser.Login(user, pass);
        }
    }
}
