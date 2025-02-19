using Avalon.AccesoDatos;
using Avalon.AccesoDatos.Repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.Controladora.Seguridad
{
    public class menuCtr
    {
        public DataTable GetDatosMenu(usuario modelo)
        {
            try
            {
                menuRepository ad = new menuRepository();
                var salida = ad.DatoMenu(modelo);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
