using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.Utiles
{
    public class HelperApi
    {
        public static async Task<W> ExecuteGet<W>(string _url, string token = null)
        {
            try
            {
                W salida = default(W);
                string responseString = "";
                var client = new HttpClient();
                string url = _url;
                System.Net.HttpStatusCode respuesta = System.Net.HttpStatusCode.BadRequest;

                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    respuesta = response.StatusCode;
                    responseString = await response.Content.ReadAsStringAsync();
                }
                if (respuesta == System.Net.HttpStatusCode.OK)
                {
                    salida = JsonConvert.DeserializeObject<W>(responseString);
                }
                else if (respuesta == System.Net.HttpStatusCode.Unauthorized)
                {
                    throw new UnauthorizedAccessException("No tiene Autorizacion, debe iniciar sesión");
                }
                else
                {
                    Newtonsoft.Json.Linq.JObject result = JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JObject>(responseString);
                    throw new Exception(result["message"].ToString());
                }
                return salida;
            }
            catch (TimeoutException tex)
            {
                throw tex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static async Task<Treturn> Execute<Trequest, Treturn>(string _url, string metodo, Trequest request, string token = null)
        {
            try
            {
                Treturn responseObject = default(Treturn);
                string responseString = "";
                var json = JsonConvert.SerializeObject(request);
                var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                var client = new HttpClient();
                string url = _url;
                System.Net.HttpStatusCode respuesta = System.Net.HttpStatusCode.BadRequest;
                switch (metodo)
                {
                    case ("post"):
                        {
                            using (HttpResponseMessage response = await client.PostAsync(url, byteContent))
                            {
                                respuesta = response.StatusCode;
                                responseString = await response.Content.ReadAsStringAsync();
                            }
                        }; break;
                    case ("put"):
                        {
                            using (HttpResponseMessage response = await client.PutAsync(url, byteContent))
                            {
                                respuesta = response.StatusCode;
                                responseString = await response.Content.ReadAsStringAsync();
                            }
                        }; break;
                    case ("delete"):
                        {
                            using (HttpResponseMessage response = await client.DeleteAsync(url))
                            {
                                respuesta = response.StatusCode;
                                responseString = await response.Content.ReadAsStringAsync();
                            }
                        }; break;
                }
                if (respuesta == System.Net.HttpStatusCode.OK)
                {
                    responseObject = JsonConvert.DeserializeObject<Treturn>(responseString);
                }
                else if (respuesta == System.Net.HttpStatusCode.Unauthorized)
                {
                    throw new UnauthorizedAccessException("No tiene Autorizacion, debe iniciar sesión");
                }
                else
                {
                    Newtonsoft.Json.Linq.JObject result = JsonConvert.DeserializeObject<Newtonsoft.Json.Linq.JObject>(responseString);
                    throw new Exception(result["message"].ToString());
                }
                return responseObject;
            }
            catch (UnauthorizedAccessException unauth)
            {
                throw unauth;
            }
            catch (TimeoutException tex)
            {
                throw tex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
