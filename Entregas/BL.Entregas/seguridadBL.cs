using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Entregas
{
    public class SeguridadBL
    {
        public bool Acceso(string usuario, string contrasena)
        {
            if (usuario == "admin" && contrasena == "1234" || usuario == "bily" && contrasena == "5678")
            {
                return true;
            }

            return false;            
        }
        
    }
}
