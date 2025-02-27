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
    public class subCentroCostoController : ApiController
    {
        IMapper _mapper;
        public subCentroCostoController()
        {
            _mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpPost]
        public IHttpActionResult Agregar(subCentroCostosViewModel modelo)
        {
            try
            {
                var entidad = _mapper.Map<subCentroCostos>(modelo);
                subCentrocostoCtr ctr = new subCentrocostoCtr();
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
        public IHttpActionResult Actualizar(subCentroCostosViewModel modelo)
        {
            try
            {
                var entidad = _mapper.Map<subCentroCostos>(modelo);
                subCentrocostoCtr ctr = new subCentrocostoCtr();
                var resultado = ctr.Modificar(entidad);
                var salida = _mapper.Map<subCentroCostosViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("api/subCentroCosto/{id}")]
        public IHttpActionResult ConsultaUno(int id)
        {
            try
            {
                subCentrocostoCtr ctr = new subCentrocostoCtr();
                var resultado = ctr.ConsultaUno(id);
                var salida = _mapper.Map<subCentroCostosViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("api/subCentroCosto/Eliminar")]
        public IHttpActionResult CambiarEstado(subCentroCostosViewModel modelo)
        {
            try
            {
                var entidad = _mapper.Map<subCentroCostos>(modelo);
                subCentrocostoCtr ctr = new subCentrocostoCtr();
                var resultado = ctr.Eliminar(entidad);
                var salida = _mapper.Map<subCentroCostosViewModel>(resultado);
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
                subCentrocostoCtr ctr = new subCentrocostoCtr();
                var resultado = ctr.ListarTodo();
                var salida = _mapper.Map<List<subCentroCostosViewModel>>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
