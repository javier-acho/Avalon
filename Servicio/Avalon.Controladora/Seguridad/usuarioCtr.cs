using Avalon.AccesoDatos;
using Avalon.AccesoDatos.Repositorio;
using Avalon.Controladora.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.Controladora.Seguridad
{
    public class usuarioCtr : ICRUDctr<usuario>
    {
        public usuario Agregar(usuario modelo)
        {
            try
            {
                usuarioRepository ad = new usuarioRepository();
                modelo.fechaCrea = DateTime.Now;
                var result = ad.Add<usuario>(modelo);
                return result;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<usuario> ConsultarByCriterio(Expression<Func<usuario, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public usuario ConsultaUno(int id)
        {
            throw new NotImplementedException();
        }

        public usuario ConsultaUnoCriterio(Expression<Func<usuario, bool>> criteria)
        {
            usuarioRepository ad = new usuarioRepository();
            var result = ad.Get<usuario>(criteria);
            return result;
        }

        public bool Eliminar(usuario modelo)
        {
            throw new NotImplementedException();
        }

        public List<usuario> ListarTodo()
        {
            usuarioRepository ad = new usuarioRepository();
            return ad.GetAll<usuario>();
        }

        public usuario Modificar(usuario modelo)
        {
            try
            {
                usuarioRepository ad = new usuarioRepository();
                modelo.fechaCrea = DateTime.Now;
                var result = ad.Update<usuario>(modelo);
                return modelo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
