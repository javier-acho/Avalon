using AutoMapper;
using Avalon.AccesoDatos;
using Avalon.Controladora.Seguridad;
using Avalon.ViewModel.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Avalon.API.Controllers.Seguridad
{
    public class usuarioController : ApiController
    {
        public IMapper _mapper;
        public usuarioController()
        {
            _mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpPost]
        public IHttpActionResult Agregar(UsuarioViewModel dato)
        {
            try
            {
                usuarioCtr ctr = new usuarioCtr();
                var entidad = _mapper.Map<usuario>(dato);
                var resultado = ctr.Agregar(entidad);
                var salida = _mapper.Map<UsuarioViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public IHttpActionResult Listar()
        {
            try
            {
                usuarioCtr ctr = new usuarioCtr();
                var resultado = ctr.ListarTodo();
                var salida = _mapper.Map<List<UsuarioViewModel>>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("api/TraerUsuario")]
        public IHttpActionResult Listar(UsuarioViewModel modelo)
        {
            try
            {
                usuarioCtr ctr = new usuarioCtr();
                var entidad = _mapper.Map<usuario>(modelo);
                var resultado = ctr.ConsultaUnoCriterio(x => x.nomUsu == modelo.nomUsu);
                var salida = _mapper.Map<UsuarioViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IHttpActionResult Modificar(UsuarioViewModel dato)
        {
            try
            {
                usuarioCtr ctr = new usuarioCtr();
                var entidad = _mapper.Map<usuario>(dato);
                var resultado = ctr.Modificar(entidad);
                var salida = _mapper.Map<UsuarioViewModel>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
