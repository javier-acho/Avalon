using Avalon.AccesoDatos;
using Avalon.API.Controllers.Maestro;
using Avalon.Controladora.Compra;
using Avalon.ViewModel.Compra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Avalon.API.Controllers.Compra
{
    public class requerimientoController : controllerCRUD<requerimiento,requerimientoViewModel,requerimientoCtr>
    {
		[HttpGet]
		[Route("api/requerimiento/datosIniciales")]
        public IHttpActionResult DatosIniciales()
        {
			try
			{
				requerimientoCtr ctr = new requerimientoCtr();
				var ds = ctr.DatosIniciales();
				return Ok(ds);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
        }
    }
}
