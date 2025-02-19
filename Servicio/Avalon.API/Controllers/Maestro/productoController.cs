using AutoMapper;
using Avalon.AccesoDatos;
using Avalon.Controladora.Maestro;
using Avalon.ViewModel.Maestros;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Avalon.API.Controllers.Maestro
{
    public class productoController : ApiController
    {
        IMapper _mapper;
        public productoController()
        {
            _mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpGet]
        public IHttpActionResult ListarTodo()
        {
            try
            {
                var ctr = new productoCtr();
                var lst = ctr.ListarTodo();
                var salida = _mapper.Map<List<productoViewModel>>(lst);

                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("api/producto/GetUn")]
        public IHttpActionResult ListarUno(productoViewModel modelo)
        {
            try
            {
                var entidad = _mapper.Map<producto>(modelo);
                var ctr = new productoCtr();
                var resultado = ctr.ConsultaUnoCriterio(x => x.codigoProducto == entidad.codigoProducto);
                var salida = _mapper.Map<productoViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("api/producto/GetUnById")]
        public IHttpActionResult ListarUno(int id)
        {
            try
            { 
                var ctr = new productoCtr();
                var resultado = ctr.ConsultaUno(id);
                var salida = _mapper.Map<productoViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IHttpActionResult Registrar(productoViewModel modelo)
        {
            try
            {
                var entidad = _mapper.Map<producto>(modelo);
                var ctr = new productoCtr();
                var resultado = ctr.Agregar(entidad);
                var salida = _mapper.Map<productoViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPut]
        public IHttpActionResult Modificar(productoViewModel modelo)
        {
            try
            {
                var entidad = _mapper.Map<producto>(modelo);
                var ctr = new productoCtr();
                var resultado = ctr.Modificar(entidad);
                var salida = _mapper.Map<productoViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("api/producto/DatosIniciales")]
        public IHttpActionResult DatosIniciales()
        {
            try
            {
                var ctr = new productoCtr();
                DataSet resultado = ctr.DatosIniciales();
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
