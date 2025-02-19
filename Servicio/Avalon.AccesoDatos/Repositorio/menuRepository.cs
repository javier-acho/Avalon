using Avalon.AccesoDatos.ClaseAbstracta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.AccesoDatos.Repositorio
{
    public class menuRepository:EF_Common
    {
        public DataTable DatoMenu(usuario modelo)
        {
            try
            {
                DataTable salida = new DataTable();
                using (AvalonDBEntities db = new AvalonDBEntities())
                {
                    var entidadUsuario = db.usuario.Where(x => x.nomUsu == modelo.nomUsu).FirstOrDefault();
                    var usuPerfil = db.usuarioXperfil.Where(x => x.idUsuario == entidadUsuario.id).FirstOrDefault();
                    var lstMenuxPerfil = db.menuXperfil.Where(x => x.idPerfil == usuPerfil.idPerfil).ToList();
                    var lstMenu = db.menu.ToList();

                    var lstModulo = db.modulo.ToList();

                    salida.Columns.Add("id");
                    salida.Columns.Add("nombre");
                    salida.Columns.Add("orden");
                    salida.Columns.Add("padre");

                    foreach (var item in lstMenuxPerfil)
                    {
                        var itemMenu = lstMenu.Where(x => x.id == item.idMenu && x.estado.Value).FirstOrDefault();
                        if (itemMenu == null) continue;

                        var moduloSeleccion = lstModulo.Where(x => x.idMenu == itemMenu.id).FirstOrDefault();

                        DataRow fila = salida.NewRow();
                        fila["id"] = itemMenu.id;
                        fila["nombre"] = itemMenu.nombre;
                        fila["padre"] =  itemMenu.padre;
                        fila["orden"] = moduloSeleccion == null ? null : moduloSeleccion.orden;

                        salida.Rows.Add(fila);
                    }
                }
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
