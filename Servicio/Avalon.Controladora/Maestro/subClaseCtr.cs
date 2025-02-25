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
    public class subClaseCtr:Interfaz.ICRUDctr<subClase>
    {
        public subClase Agregar(subClase modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.nombreCorto))
                    throw new Exception("Debe escribir un nombre corto");
                if (string.IsNullOrEmpty(modelo.nombre))
                    throw new Exception("Debe escribir un nombre");

                subClaseRepository ad = new subClaseRepository();
                var salida = ad.Add(modelo);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<subClase> ConsultarByCriterio(Expression<Func<subClase, bool>> criteria)
        {
            try
            {
                subClaseRepository ctr = new subClaseRepository();
                var salida = ctr.GetAllByCritearia(criteria);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public subClase ConsultaUno(int id)
        {
            try
            {
                subClaseRepository ad = new subClaseRepository();
                var salida = ad.Get<subClase>(x => x.id == id);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public subClase ConsultaUnoCriterio(Expression<Func<subClase, bool>> criteria)
        {
            try
            {
                subClaseRepository ad = new subClaseRepository();
                var salida = ad.Get(criteria);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Eliminar(subClase modelo)
        {
            try
            {
                subClaseRepository ad = new subClaseRepository();
                var respuesta = ad.Delete(modelo);
                return respuesta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<subClase> ListarTodo()
        {
            try
            {
                subClaseRepository ad = new subClaseRepository();
                var salida = ad.GetAll<subClase>();
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public subClase Modificar(subClase modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.nombreCorto))
                    throw new Exception("Debe escribir un nombre corto");
                if (string.IsNullOrEmpty(modelo.nombre))
                    throw new Exception("Debe escribir un nombre");

                subClaseRepository ad = new subClaseRepository();
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
