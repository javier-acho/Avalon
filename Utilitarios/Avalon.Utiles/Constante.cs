using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.Utiles
{
    public static class Constante
    {
        public const string FORMATO_FECHA = "dd-MM-yyyy";

        static string URL_API = LlamaURL();

        private static string LlamaURL()
        {
            string Path = System.Reflection.Assembly.GetAssembly(typeof(Constante)).Location;
            string PathToClassLibPro = System.IO.Path.GetDirectoryName(Path);
            string path = System.IO.Path.Combine(PathToClassLibPro, "ruta.json");
            //string rutaApi = JsonConvert.DeserializeObject<RutaApi>(System.IO.File.ReadAllText(path)).rutaApi;
            var lstApi = JsonConvert.DeserializeObject<List<RutaApi>>(System.IO.File.ReadAllText(path));
            var api = lstApi.Where(x => x.activo).FirstOrDefault();
            string rutaApi = api.rutaApi;
            return rutaApi;
        }
        public const string default_password = "123";
        public class RutaApi
        {
            public string nombre { get; set; }
            public string rutaApi { get; set; }
            public bool activo { get; set; }
        }
        public static string USUARIO
        {
            get
            {
                return $"{URL_API}usuario";
            }
        }
        public static string GET_USUARIO
        {
            get
            {
                return $"{URL_API}TraerUsuario";
            }
        }
        public static string DATA_MENU
        {
            get
            {
                return $"{URL_API}menu";
            }
        }

        public static string SOCIO_NEGOCIO
        {
            get
            {
                return $"{URL_API}socioNegocio";
            }
        }
        public static string DATOS_SOCIO_NEGOCIO
        {
            get
            {
                return $"{URL_API}socioNegocio/datosIniciales";
            }
        }
        public static string SOCIO_NEGOCIO_GET_UN
        {
            get
            {
                return $"{URL_API}socioNegocio/seleccionaUno";
            }
        }
        public static string PRODUCTO
        {
            get
            {
                return $"{URL_API}producto";
            }
        }
        public static string DATOS_PRODUCTO
        {
            get
            {
                return $"{URL_API}producto/seleccionaUno";
            }
        }

        public static string SERVICIO
        {
            get
            {
                return $"{URL_API}servicio";
            }
        }
        public static string DATOS_SERVICIO
        {
            get
            {
                return $"{URL_API}servicio/seleccionaUno";
            }
        }
    }
}
