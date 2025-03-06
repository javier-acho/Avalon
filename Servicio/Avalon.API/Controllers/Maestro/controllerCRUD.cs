using AutoMapper;
using Avalon.AccesoDatos;
using Avalon.Controladora.Interfaz;
using Avalon.Controladora.Maestro;
using Avalon.ViewModel.Maestros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace Avalon.API.Controllers.Maestro
{
	public abstract class controllerCRUD<TM,TVM,C>: ApiController where C:ICRUDctr<TM>
    {
        IMapper _mapper;
        public const string ruta = "";
        protected controllerCRUD()
        {
            _mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }

        [HttpPost]
        public IHttpActionResult Agregar(TVM viewModel)
        {
            try
            {
                C ctr = (C)Activator.CreateInstance(typeof(C), null);
                var entidad = _mapper.Map<TM>(viewModel);
                var resultado = ctr.Agregar(entidad);
                var salida = _mapper.Map<TVM>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public IHttpActionResult Modificar(TVM viewModel)
        {
            try
            {
                C ctr = (C)Activator.CreateInstance(typeof(C), null);
                var entidad = _mapper.Map<TM>(viewModel);
                var resultado = ctr.Modificar(entidad);
                var salida = _mapper.Map<TVM>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public IHttpActionResult ObtenerUno(int id)
        {
            try
            {
                C ctr = (C)Activator.CreateInstance(typeof(C), null);
                var resultado = ctr.ConsultaUno(id);
                var salida = _mapper.Map<TVM>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        public IHttpActionResult ListarTodo()
        {
            try
            {
                C ctr = (C)Activator.CreateInstance(typeof(C), null);
                var resultado = ctr.ListarTodo();
                var salida = _mapper.Map<List<TVM>>(resultado);
                return Ok(salida);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
    }
}