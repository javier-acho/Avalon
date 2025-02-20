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
                var datos = ctr.DatosIniciales();
                var salida = _mapper.Map<List<productoViewModel>>(lst);

                DataTable dtClase = datos.Tables["CL"];
                DataTable dtSubClase = datos.Tables["SCL"];
                DataTable dtSubSubClase = datos.Tables["SSCL"];
                DataTable dtFamilia = datos.Tables["fam"];
                DataTable dtSubFamilia = datos.Tables["sfam"];
                DataTable dtUM = datos.Tables["um"];
                foreach (var item in salida)
                {
                    int idClase = item.idClase.Value;
                    int idSubClase = item.idSubClase.Value;
                    int idSubSubClase = item.idSubSubClase.Value;
                    int idFamilia = item.idFamilia.Value;
                    int idSubFamilia = item.idSubFamilia.Value;
                    int idUnidadMedida = item.idUnidadMedida.Value;

                    string clase = dtClase.Select($"id={idClase}").FirstOrDefault()["nombre"].ToString();
                    string subClase = dtSubClase.Select($"id={idSubClase}").FirstOrDefault()["nombre"].ToString();
                    string subSubClase = dtSubSubClase.Select($"id={idSubSubClase}").FirstOrDefault()["nombre"].ToString();
                    string familia = dtFamilia.Select($"id={idFamilia}").FirstOrDefault()["nombre"].ToString();
                    string subFamilia = dtSubFamilia.Select($"id={idSubFamilia}").FirstOrDefault()["nombre"].ToString();
                    string unidadMedida = dtUM.Select($"id={idUnidadMedida}").FirstOrDefault()["nombre"].ToString();

                    item.clase = clase;
                    item.subClase = subClase;
                    item.subSubClase = subSubClase;
                    item.familia = familia;
                    item.subFamilia = subFamilia;
                    item.unidadMedida = unidadMedida;
                }

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
        [HttpGet]
        [Route("api/producto/GetUnById/{id}")]
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
