using Avalon.AccesoDatos.ClaseAbstracta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.AccesoDatos.Repositorio.Maestro
{
    public class socioNegocioRepository:EF_Common
    {
        public DataSet DatosIniciales()
        {
            try
            {
                DataSet ds = new DataSet();
                using (AvalonDBEntities db = new AvalonDBEntities())
                {
                    var condicionPago = db.condicionPago.ToList();
                    var tipoDocumentoIdentidad = db.tipoDocumentoIdentidad.ToList();

                    DataTable dtCondicion = new DataTable();
                    dtCondicion.Columns.Add("id");
                    dtCondicion.Columns.Add("nombre");
                    dtCondicion.Columns.Add("dias");
                    foreach (var item in condicionPago)
                    {
                        var fila = dtCondicion.NewRow();
                        fila["id"] = item.id;
                        fila["nombre"] = item.nombre;
                        fila["dias"] = item.dias;
                        dtCondicion.Rows.Add(fila);
                    }

                    DataTable dtTDI = new DataTable();
                    dtTDI.Columns.Add("id");
                    dtTDI.Columns.Add("nombre");
                    foreach (var item in tipoDocumentoIdentidad)
                    {
                        var fila = dtTDI.NewRow();
                        fila["id"] = item.id;
                        fila["nombre"] = item.nombre;
                        dtTDI.Rows.Add(fila);
                    }
                    ds.Tables.Add(dtCondicion);
                    ds.Tables.Add(dtTDI);
                }
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
