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
    public class centroCostoController : ApiController
    {
        IMapper _mapper;
        public centroCostoController()
        {
            _mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpPost]
        public IHttpActionResult Agregar(centroCostosViewModel modelo)
        {
            try
            {
                var entidad = _mapper.Map<centroCostos>(modelo);
                centroCostosCtr ctr = new centroCostosCtr();
                var resultado = ctr.Agregar(entidad);
                var salida = _mapper.Map<centroCostosViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IHttpActionResult Actualizar(centroCostosViewModel modelo)
        {
            try
            {
                var entidad = _mapper.Map<centroCostos>(modelo);
                centroCostosCtr ctr = new centroCostosCtr();
                var resultado = ctr.Modificar(entidad);
                var salida = _mapper.Map<centroCostosViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("api/Centrocosto/{id}")]
        public IHttpActionResult ConsultaUno(int id)
        {
            try
            {
                centroCostosCtr ctr = new centroCostosCtr();
                var resultado = ctr.ConsultaUno(id);
                var salida = _mapper.Map<centroCostosViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("api/Centrocosto/Eliminar")]
        public IHttpActionResult CambiarEstado(centroCostosViewModel modelo)
        {
            try
            {
                var entidad = _mapper.Map<centroCostos>(modelo);
                centroCostosCtr ctr = new centroCostosCtr();
                var resultado = ctr.Eliminar(entidad);
                var salida = _mapper.Map<centroCostosViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public IHttpActionResult ConsultarTodo()
        {
            try
            {
                centroCostosCtr ctr = new centroCostosCtr();
                var resultado = ctr.ListarTodo();
                var salida = _mapper.Map<List<centroCostosViewModel>>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
