using Avalon.AccesoDatos;
using Avalon.AccesoDatos.Repositorio.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.Controladora.Maestro
{
    public class familiaCtr: Interfaz.ICRUDctr<familia>
    {
        public familia Agregar(familia modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.nombreCorto))
                    throw new Exception("Debe escribir un nombre corto");
                if (string.IsNullOrEmpty(modelo.nombre))
                    throw new Exception("Debe escribir un nombre");

                familiaRepository ad = new familiaRepository();
                var salida = ad.Add(modelo);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<familia> ConsultarByCriterio(Expression<Func<familia, bool>> criteria)
        {
            try
            {
                familiaRepository ctr = new familiaRepository();
                var salida = ctr.GetAllByCritearia(criteria);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public familia ConsultaUno(int id)
        {
            try
            {
                familiaRepository ad = new familiaRepository();
                var salida = ad.Get<familia>(x => x.id == id);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public familia ConsultaUnoCriterio(Expression<Func<familia, bool>> criteria)
        {
            try
            {
                familiaRepository ad = new familiaRepository();
                var salida = ad.Get(criteria);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Eliminar(familia modelo)
        {
            try
            {
                familiaRepository ad = new familiaRepository();
                var respuesta = ad.Delete(modelo);
                return respuesta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<familia> ListarTodo()
        {
            try
            {
                familiaRepository ad = new familiaRepository();
                var salida = ad.GetAll<familia>();
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public familia Modificar(familia modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.nombreCorto))
                    throw new Exception("Debe escribir un nombre corto");
                if (string.IsNullOrEmpty(modelo.nombre))
                    throw new Exception("Debe escribir un nombre");

                familiaRepository ad = new familiaRepository();
                var salida = ad.Update(modelo);
                return modelo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
