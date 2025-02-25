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
    public class subSubClaseCtr : Interfaz.ICRUDctr<subSubClase>
    {
        public subSubClase Agregar(subSubClase modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.nombreCorto))
                    throw new Exception("Debe escribir un nombre corto");
                if (string.IsNullOrEmpty(modelo.nombre))
                    throw new Exception("Debe escribir un nombre");

                subSubClaseRepository ad = new subSubClaseRepository();
                var salida = ad.Add(modelo);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<subSubClase> ConsultarByCriterio(Expression<Func<subSubClase, bool>> criteria)
        {
            try
            {
                subSubClaseRepository ctr = new subSubClaseRepository();
                var salida = ctr.GetAllByCritearia(criteria);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public subSubClase ConsultaUno(int id)
        {
            try
            {
                subSubClaseRepository ad = new subSubClaseRepository();
                var salida = ad.Get<subSubClase>(x => x.id == id);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public subSubClase ConsultaUnoCriterio(Expression<Func<subSubClase, bool>> criteria)
        {
            try
            {
                subSubClaseRepository ad = new subSubClaseRepository();
                var salida = ad.Get(criteria);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Eliminar(subSubClase modelo)
        {
            try
            {
                subSubClaseRepository ad = new subSubClaseRepository();
                var respuesta = ad.Delete(modelo);
                return respuesta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<subSubClase> ListarTodo()
        {
            try
            {
                subSubClaseRepository ad = new subSubClaseRepository();
                var salida = ad.GetAll<subSubClase>();
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public subSubClase Modificar(subSubClase modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.nombreCorto))
                    throw new Exception("Debe escribir un nombre corto");
                if (string.IsNullOrEmpty(modelo.nombre))
                    throw new Exception("Debe escribir un nombre");

                subSubClaseRepository ad = new subSubClaseRepository();
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
