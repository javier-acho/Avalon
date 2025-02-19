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
    public class productoCtr : ICRUDctr<producto>
    {
        public producto Agregar(producto modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.codigoProducto))
                    throw new Exception("El codigo de producto no puede estar vacio");
                if(string.IsNullOrEmpty(modelo.nombreProducto))
                    throw new Exception("El nombre de producto no puede estar vacio");
                if(!modelo.esParaCompra.Value && !modelo.esParaVenta.Value)
                    throw new Exception("Debe decidir si el producto es para compras y/o ventas");

                productoRepository ad = new productoRepository();
                var salida = ad.Add(modelo);
                return salida;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<producto> ConsultarByCriterio(Expression<Func<producto, bool>> criteria)
        {
            try
            {
                productoRepository ad = new productoRepository();
                var lista = ad.GetAllByCritearia(criteria);
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public producto ConsultaUno(int id)
        {
            try
            {
                productoRepository ad = new productoRepository();
                var salida = ad.Get<producto>(x => x.id == id);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public producto ConsultaUnoCriterio(Expression<Func<producto, bool>> criteria)
        {
            try
            {
                productoRepository ad = new productoRepository();
                var salida = ad.Get(criteria);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Eliminar(producto modelo)
        {
            try
            {
                productoRepository ad = new productoRepository();
                var respuesta = ad.Delete(modelo);
                return respuesta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<producto> ListarTodo()
        {
            try
            {
                productoRepository ad = new productoRepository();
                var salida = ad.GetAll<producto>();
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public producto Modificar(producto modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.codigoProducto))
                    throw new Exception("El codigo de producto no puede estar vacio");
                if (string.IsNullOrEmpty(modelo.nombreProducto))
                    throw new Exception("El nombre de producto no puede estar vacio");
                if (!modelo.esParaCompra.Value && !modelo.esParaVenta.Value)
                    throw new Exception("Debe decidir si el producto es para compras y/o ventas");

                productoRepository ad = new productoRepository();
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
                productoRepository ad = new productoRepository();
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
