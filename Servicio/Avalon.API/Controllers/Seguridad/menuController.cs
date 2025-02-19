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
    public class menuController : ApiController
    {
        public IMapper _mapper;
        public menuController()
        {
            _mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }

        [HttpPost]
        public IHttpActionResult GetMenu(UsuarioViewModel modelo)
        {
            try
            {
                menuCtr ctr = new menuCtr();
                var entidad = _mapper.Map<usuario>(modelo);
                var dtMenu = ctr.GetDatosMenu(entidad);
                return Ok(dtMenu);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
