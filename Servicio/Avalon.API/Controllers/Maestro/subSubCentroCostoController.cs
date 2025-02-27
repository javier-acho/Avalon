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
    public class subSubCentroCostoController : ApiController
    {
        IMapper _mapper;
        public subSubCentroCostoController()
        {
            _mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpPost]
        public IHttpActionResult Agregar(subSubCentroCostosViewModel modelo)
        {
            try
            {
                var entidad = _mapper.Map<subSubCentroCostos>(modelo);
                subSubCentrocostoCtr ctr = new subSubCentrocostoCtr();
                var resultado = ctr.Agregar(entidad);
                var salida = _mapper.Map<subSubCentroCostosViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IHttpActionResult Actualizar(subSubCentroCostosViewModel modelo)
        {
            try
            {
                var entidad = _mapper.Map<subSubCentroCostos>(modelo);
                subSubCentrocostoCtr ctr = new subSubCentrocostoCtr();
                var resultado = ctr.Modificar(entidad);
                var salida = _mapper.Map<subSubCentroCostosViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("api/subSubCentroCosto/{id}")]
        public IHttpActionResult ConsultaUno(int id)
        {
            try
            {
                subSubCentrocostoCtr ctr = new subSubCentrocostoCtr();
                var resultado = ctr.ConsultaUno(id);
                var salida = _mapper.Map<subSubCentroCostosViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("api/subSubCentroCosto/Eliminar")]
        public IHttpActionResult CambiarEstado(subSubCentroCostosViewModel modelo)
        {
            try
            {
                var entidad = _mapper.Map<subSubCentroCostos>(modelo);
                subSubCentrocostoCtr ctr = new subSubCentrocostoCtr();
                var resultado = ctr.Eliminar(entidad);
                var salida = _mapper.Map<subSubCentroCostosViewModel>(resultado);
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
                subSubCentrocostoCtr ctr = new subSubCentrocostoCtr();
                var resultado = ctr.ListarTodo();
                var salida = _mapper.Map<List<subSubCentroCostosViewModel>>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
