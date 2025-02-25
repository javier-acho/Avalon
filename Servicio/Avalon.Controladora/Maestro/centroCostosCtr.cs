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
    public class centroCostosCtr : Interfaz.ICRUDctr<centroCostos>
    {
        public centroCostos Agregar(centroCostos modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.nombreCorto))
                    throw new Exception("Debe escribir un nombre corto");
                if (string.IsNullOrEmpty(modelo.nombre))
                    throw new Exception("Debe escribir un nombre");

                centroCostosRepository ad = new centroCostosRepository();
                var salida = ad.Add(modelo);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<centroCostos> ConsultarByCriterio(Expression<Func<centroCostos, bool>> criteria)
        {
            try
            {
                centroCostosRepository ctr = new centroCostosRepository();
                var salida = ctr.GetAllByCritearia(criteria);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public centroCostos ConsultaUno(int id)
        {
            try
            {
                centroCostosRepository ad = new centroCostosRepository();
                var salida = ad.Get<centroCostos>(x => x.id == id);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public centroCostos ConsultaUnoCriterio(Expression<Func<centroCostos, bool>> criteria)
        {
            try
            {
                centroCostosRepository ad = new centroCostosRepository();
                var salida = ad.Get(criteria);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Eliminar(centroCostos modelo)
        {
            try
            {
                centroCostosRepository ad = new centroCostosRepository();
                var respuesta = ad.Delete(modelo);
                return respuesta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<centroCostos> ListarTodo()
        {
            try
            {
                centroCostosRepository ad = new centroCostosRepository();
                var salida = ad.GetAll<centroCostos>();
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public centroCostos Modificar(centroCostos modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.nombreCorto))
                    throw new Exception("Debe escribir un nombre corto");
                if (string.IsNullOrEmpty(modelo.nombre))
                    throw new Exception("Debe escribir un nombre");

                centroCostosRepository ad = new centroCostosRepository();
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
