using Avalon.AccesoDatos;
using Avalon.AccesoDatos.Repositorio.Compra;
using Avalon.Controladora.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.Controladora.Compra
{
    public class requerimientoCtr : ICRUDctr<requerimiento>
    {
        public DataSet DatosIniciales()
        {
            try
            {
                requerimientoRepository ad = new requerimientoRepository();
                var salida = ad.DatosIniciales();
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public requerimiento Agregar(requerimiento modelo)
        {
            try
            {
                requerimientoRepository ad = new requerimientoRepository();
                var salida = ad.Add(modelo);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<requerimiento> ConsultarByCriterio(Expression<Func<requerimiento, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public requerimiento ConsultaUno(int id)
        {
            throw new NotImplementedException();
        }

        public requerimiento ConsultaUnoCriterio(Expression<Func<requerimiento, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(requerimiento modelo)
        {
            throw new NotImplementedException();
        }

        public List<requerimiento> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public requerimiento Modificar(requerimiento modelo)
        {
            throw new NotImplementedException();
        }
    }
}
