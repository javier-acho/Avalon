using Avalon.AccesoDatos;
using Avalon.AccesoDatos.Repositorio.Maestro;
using Avalon.Controladora.Interfaz;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.Controladora.Maestro
{
    public class servicioCtr : ICRUDctr<servicio>
    {
        public servicio Agregar(servicio modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.codigoServicio))
                    throw new Exception("El codigo de servicio no puede estar vacio");
                if (string.IsNullOrEmpty(modelo.nombreServicio))
                    throw new Exception("El nombre de servicio no puede estar vacio");
                if (!modelo.esParaCompra.Value && !modelo.esParaVenta.Value)
                    throw new Exception("Debe decidir si el servicio es para compras y/o ventas");

                servicioRepository ad = new servicioRepository();
                var salida = ad.Add(modelo);
                return salida;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<servicio> ConsultarByCriterio(Expression<Func<servicio, bool>> criteria)
        {
            try
            {
                servicioRepository ad = new servicioRepository();
                var lista = ad.GetAllByCritearia(criteria);
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public servicio ConsultaUno(int id)
        {
            try
            {
                servicioRepository ad = new servicioRepository();
                var salida = ad.Get<servicio>(x => x.id == id);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public servicio ConsultaUnoCriterio(Expression<Func<servicio, bool>> criteria)
        {
            try
            {
                servicioRepository ad = new servicioRepository();
                var salida = ad.Get(criteria);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Eliminar(servicio modelo)
        {
            try
            {
                servicioRepository ad = new servicioRepository();
                var respuesta = ad.Delete(modelo);
                return respuesta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<servicio> ListarTodo()
        {
            try
            {
                servicioRepository ad = new servicioRepository();
                var salida = ad.GetAll<servicio>();
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public servicio Modificar(servicio modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.codigoServicio))
                    throw new Exception("El codigo de servicio no puede estar vacio");
                if (string.IsNullOrEmpty(modelo.nombreServicio))
                    throw new Exception("El nombre de servicio no puede estar vacio");
                if (!modelo.esParaCompra.Value && !modelo.esParaVenta.Value)
                    throw new Exception("Debe decidir si el servicio es para compras y/o ventas");

                servicioRepository ad = new servicioRepository();
                var salida = ad.Update(modelo);
                return modelo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet DatosIniciales()
        {
            try
            {
                servicioRepository ad = new servicioRepository();
                var salida = ad.DatosIniciales();
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
