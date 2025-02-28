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
    public class subCentrocostoCtr : Interfaz.ICRUDctr<subCentroCostos>
    {
        public subCentroCostos Agregar(subCentroCostos modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.nombreCorto))
                    throw new Exception("Debe escribir un nombre corto");
                if (string.IsNullOrEmpty(modelo.nombre))
                    throw new Exception("Debe escribir un nombre");

                subCentroCostosRepository ctr = new subCentroCostosRepository();
                var salida = ctr.Add(modelo);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<subCentroCostos> ConsultarByCriterio(Expression<Func<subCentroCostos, bool>> criteria)
        {
            try
            {
                subCentroCostosRepository ctr = new subCentroCostosRepository();
                var salida = ctr.GetAllByCritearia(criteria);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public subCentroCostos ConsultaUno(int id)
        {
            try
            {
                subCentroCostosRepository ad = new subCentroCostosRepository();
                var salida = ad.Get<subCentroCostos>(x => x.id == id);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public subCentroCostos ConsultaUnoCriterio(Expression<Func<subCentroCostos, bool>> criteria)
        {
            try
            {
                subCentroCostosRepository ad = new subCentroCostosRepository();
                var salida = ad.Get(criteria);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Eliminar(subCentroCostos modelo)
        {
            try
            {
                subCentroCostosRepository ad = new subCentroCostosRepository();
                var respuesta = ad.Update(modelo);
                return respuesta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<subCentroCostos> ListarTodo()
        {
            try
            {
                subCentroCostosRepository ad = new subCentroCostosRepository();
                var respuesta = ad.GetAll<subCentroCostos>();
                return respuesta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public subCentroCostos Modificar(subCentroCostos modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.nombreCorto))
                    throw new Exception("Debe escribir un nombre corto");
                if (string.IsNullOrEmpty(modelo.nombre))
                    throw new Exception("Debe escribir un nombre");

                subCentroCostosRepository ctr = new subCentroCostosRepository();
                var salida = ctr.Update(modelo);
                return modelo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
