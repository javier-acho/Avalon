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
    public class subFamiliaCtr: Interfaz.ICRUDctr<subFamilia>
    {
        public subFamilia Agregar(subFamilia modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.nombreCorto))
                    throw new Exception("Debe escribir un nombre corto");
                if (string.IsNullOrEmpty(modelo.nombre))
                    throw new Exception("Debe escribir un nombre");

                subFamiliaRepository ad = new subFamiliaRepository();
                var salida = ad.Add(modelo);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<subFamilia> ConsultarByCriterio(Expression<Func<subFamilia, bool>> criteria)
        {
            try
            {
                subFamiliaRepository ctr = new subFamiliaRepository();
                var salida = ctr.GetAllByCritearia(criteria);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public subFamilia ConsultaUno(int id)
        {
            try
            {
                subFamiliaRepository ad = new subFamiliaRepository();
                var salida = ad.Get<subFamilia>(x => x.id == id);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public subFamilia ConsultaUnoCriterio(Expression<Func<subFamilia, bool>> criteria)
        {
            try
            {
                subFamiliaRepository ad = new subFamiliaRepository();
                var salida = ad.Get(criteria);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Eliminar(subFamilia modelo)
        {
            try
            {
                subFamiliaRepository ad = new subFamiliaRepository();
                var respuesta = ad.Delete(modelo);
                return respuesta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<subFamilia> ListarTodo()
        {
            try
            {
                subFamiliaRepository ad = new subFamiliaRepository();
                var salida = ad.GetAll<subFamilia>();
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public subFamilia Modificar(subFamilia modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.nombreCorto))
                    throw new Exception("Debe escribir un nombre corto");
                if (string.IsNullOrEmpty(modelo.nombre))
                    throw new Exception("Debe escribir un nombre");

                subFamiliaRepository ad = new subFamiliaRepository();
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
