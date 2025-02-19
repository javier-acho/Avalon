using AutoMapper;
using Avalon.AccesoDatos;
using Avalon.Controladora.Maestro;
using Avalon.ViewModel.Maestros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Avalon.API.Controllers.Maestro
{
    public class socioNegocioController : ApiController
    {
        IMapper _mapper;
        public socioNegocioController()
        {
            _mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }

        [HttpGet]
        [Route("api/socioNegocio/{tipo}")]
        public IHttpActionResult ListarSocioNegocio(string tipo)
        {
            try
            {
                socioNegocioCtr ctr = new socioNegocioCtr();
                var lst = ctr.ConsultarByCriterio(x=> x.tipoSocio == tipo);
                var salida = _mapper.Map<List<socioNegocioViewModel>>(lst);

                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IHttpActionResult InsertarProveedor(socioNegocioViewModel modelo)
        {
            try
            {
                socioNegocioCtr ctr = new socioNegocioCtr();
                var entidad = _mapper.Map<socioNegocio>(modelo);
                var resultado = ctr.Agregar(entidad);
                var salida = _mapper.Map<socioNegocioViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IHttpActionResult ModificarSocioNegocio(socioNegocioViewModel modelo)
        {
            try
            {
                socioNegocioCtr ctr = new socioNegocioCtr();
                var entidad = _mapper.Map<socioNegocio>(modelo);
                var resultado = ctr.Modificar(entidad);
                var salida = _mapper.Map<socioNegocioViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //[HttpPost]
        //[Route("api/socioNegocio/Insert")]
        //public IHttpActionResult InsertarProveedor(socioNegocioViewModel modelo)
        //{
        //    try
        //    {
        //        socioNegocioCtr ctr = new socioNegocioCtr();
        //        var lst = ctr.ListarTodo();
        //        var salida = _mapper.Map<List<socioNegocioViewModel>>(lst);

        //        return Ok(salida);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        [HttpGet]
        [Route("api/socioNegocio/datosIniciales")]
        public IHttpActionResult CargardatosIniciales()
        {
            try
            {
                socioNegocioCtr ctr = new socioNegocioCtr();
                var salida = ctr.DatosIniciales();
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/socioNegocio/seleccionaUno/{id}")]
        public IHttpActionResult CargarUnSocioNegocio(int id)
        {
            try
            {
                socioNegocioCtr ctr = new socioNegocioCtr();
                var salida = ctr.ConsultaUno(id);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
