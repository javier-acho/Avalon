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
    public class claseCtr : Interfaz.ICRUDctr<clase>
    {
        public clase Agregar(clase modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.nombreCorto))
                    throw new Exception("Debe escribir un nombre corto");
                if (string.IsNullOrEmpty(modelo.nombre))
                    throw new Exception("Debe escribir un nombre");

                claseRepository ad = new claseRepository();
                var salida = ad.Add(modelo);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<clase> ConsultarByCriterio(Expression<Func<clase, bool>> criteria)
        {
            try
            {
                claseRepository ctr = new claseRepository();
                var salida = ctr.GetAllByCritearia(criteria);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public clase ConsultaUno(int id)
        {
            try
            {
                claseRepository ad = new claseRepository();
                var salida = ad.Get<clase>(x => x.id == id);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public clase ConsultaUnoCriterio(Expression<Func<clase, bool>> criteria)
        {
            try
            {
                claseRepository ad = new claseRepository();
                var salida = ad.Get(criteria);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Eliminar(clase modelo)
        {
            try
            {
                claseRepository ad = new claseRepository();
                var respuesta = ad.Delete(modelo);
                return respuesta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<clase> ListarTodo()
        {
            try
            {
                claseRepository ad = new claseRepository();
                var salida = ad.GetAll<clase>();
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public clase Modificar(clase modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.nombreCorto))
                    throw new Exception("Debe escribir un nombre corto");
                if (string.IsNullOrEmpty(modelo.nombre))
                    throw new Exception("Debe escribir un nombre");

                claseRepository ad = new claseRepository();
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
