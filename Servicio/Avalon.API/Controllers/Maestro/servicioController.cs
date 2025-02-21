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
    public class servicioController : ApiController
    {
        IMapper _mapper;
        public servicioController()
        {
            _mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpGet]
        public IHttpActionResult ListarTodo()
        {
            try
            {
                var ctr = new servicioCtr();
                var lst = ctr.ListarTodo();
                var salida = _mapper.Map<List<servicioViewModel>>(lst);

                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("api/servicio/GetUn")]
        public IHttpActionResult ListarUno(servicioViewModel modelo)
        {
            try
            {
                var entidad = _mapper.Map<servicio>(modelo);
                var ctr = new servicioCtr();
                var resultado = ctr.ConsultaUnoCriterio(x => x.codigoServicio == entidad.codigoServicio);
                var salida = _mapper.Map<servicioViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("api/servicio/GetUnById/{id}")]
        public IHttpActionResult ListarUno(int id)
        {
            try
            {
                var ctr = new servicioCtr();
                var resultado = ctr.ConsultaUno(id);
                var salida = _mapper.Map<servicioViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IHttpActionResult Registrar(servicioViewModel modelo)
        {
            try
            {
                var entidad = _mapper.Map<servicio>(modelo);
                var ctr = new servicioCtr();
                var resultado = ctr.Agregar(entidad);
                var salida = _mapper.Map<servicioViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IHttpActionResult Modificar(servicioViewModel modelo)
        {
            try
            {
                var entidad = _mapper.Map<servicio>(modelo);
                var ctr = new servicioCtr();
                var resultado = ctr.Modificar(entidad);
                var salida = _mapper.Map<servicioViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("api/servicio/DatosIniciales")]
        public IHttpActionResult DatosIniciales()
        {
            try
            {
                var ctr = new servicioCtr();
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
