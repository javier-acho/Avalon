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
    public class socioNegocioCtr : ICRUDctr<socioNegocio>
    {
        public socioNegocio Agregar(socioNegocio modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.codigoSocio))
                    throw new Exception("Debe digitar un codigo de socio");
                if (string.IsNullOrEmpty(modelo.nroDocumento))
                    throw new Exception("Debe digitar un numero de documento");
                if (string.IsNullOrEmpty(modelo.razonSocial))
                    throw new Exception("La razon social no debe estar en blanco"); 

                socioNegocioRepository ad = new socioNegocioRepository();
                var salida = ad.Add<socioNegocio>(modelo);

                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<socioNegocio> ConsultarByCriterio(Expression<Func<socioNegocio, bool>> criteria)
        {
            try
            {
                socioNegocioRepository ad = new socioNegocioRepository();
                var salida = ad.GetAllByCritearia<socioNegocio>(criteria);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public socioNegocio ConsultaUno(int id)
        {
            try
            {
                socioNegocioRepository ad = new socioNegocioRepository();
                var salida = ad.Get<socioNegocio>(x => x.id == id);
                return salida;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public socioNegocio ConsultaUnoCriterio(Expression<Func<socioNegocio, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(socioNegocio modelo)
        {
            throw new NotImplementedException();
        }

        public List<socioNegocio> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public socioNegocio Modificar(socioNegocio modelo)
        {
            try
            {
                if (string.IsNullOrEmpty(modelo.codigoSocio))
                    throw new Exception("Debe digitar un codigo de socio");
                if (string.IsNullOrEmpty(modelo.nroDocumento))
                    throw new Exception("Debe digitar un numero de documento");
                if (string.IsNullOrEmpty(modelo.razonSocial))
                    throw new Exception("La razon social no debe estar en blanco");

                socioNegocioRepository ad = new socioNegocioRepository();
                
                var salida = ad.Update<socioNegocio>(modelo);
                
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
                socioNegocioRepository ad = new socioNegocioRepository();
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
