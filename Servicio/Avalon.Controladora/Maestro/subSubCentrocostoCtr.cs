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
    public class subSubCentrocostoCtr : Interfaz.ICRUDctr<subSubCentroCostos>
    {
        public subSubCentroCostos Agregar(subSubCentroCostos modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.nombreCorto))
                    throw new Exception("Debe escribir un nombre corto");
                if (string.IsNullOrEmpty(modelo.nombre))
                    throw new Exception("Debe escribir un nombre");

                subSubCentroCostosRepository ad = new subSubCentroCostosRepository();
                var salida = ad.Add(modelo);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<subSubCentroCostos> ConsultarByCriterio(Expression<Func<subSubCentroCostos, bool>> criteria)
        {
            try
            {
                subSubCentroCostosRepository ad = new subSubCentroCostosRepository();
                var salida = ad.GetAllByCritearia(criteria);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public subSubCentroCostos ConsultaUno(int id)
        {
            try
            {
                subSubCentroCostosRepository ad = new subSubCentroCostosRepository();
                var salida = ad.Get<subSubCentroCostos>(x => x.id == id);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public subSubCentroCostos ConsultaUnoCriterio(Expression<Func<subSubCentroCostos, bool>> criteria)
        {
            try
            {
                subSubCentroCostosRepository ad = new subSubCentroCostosRepository();
                var salida = ad.Get(criteria);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Eliminar(subSubCentroCostos modelo)
        {
            try
            {
                subSubCentroCostosRepository ad = new subSubCentroCostosRepository();
                var salida = ad.Update(modelo);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<subSubCentroCostos> ListarTodo()
        {
            try
            {
                subSubCentroCostosRepository ad = new subSubCentroCostosRepository();
                var salida = ad.GetAll<subSubCentroCostos>();
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public subSubCentroCostos Modificar(subSubCentroCostos modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.nombreCorto))
                    throw new Exception("Debe escribir un nombre corto");
                if (string.IsNullOrEmpty(modelo.nombre))
                    throw new Exception("Debe escribir un nombre");

                subSubCentroCostosRepository ad = new subSubCentroCostosRepository();
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
