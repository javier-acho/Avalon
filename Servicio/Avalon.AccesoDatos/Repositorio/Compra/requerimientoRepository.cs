using Avalon.AccesoDatos.ClaseAbstracta;
using FastMember;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.AccesoDatos.Repositorio.Compra
{
    public class requerimientoRepository:EF_Common
    {
        public DataSet DatosIniciales()
        {
			try
			{
				using (AvalonDBEntities db = new AvalonDBEntities())
				{
					var cc = db.centroCostos.Where(x=>x.estado.Value).ToList();
					var scc = db.subCentroCostos.Where(x => x.estado.Value).ToList();
					var sscc = db.subSubCentroCostos.Where(x => x.estado.Value).ToList();
					var area = db.area.ToList();

                    DataSet ds = new DataSet();
                    DataTable dtcc = new DataTable();
                    DataTable dtscc = new DataTable();
                    DataTable dtsscc = new DataTable();
                    DataTable dtarea = new DataTable();

                    DataTable dtN = new DataTable();
                    dtN.Columns.Add("numero");
                    //LogicaNumeracion
                    string numeroRQ = string.Empty;
                    var rq = db.requerimiento.OrderByDescending(x => x.id);
                    if(rq.Count() == 0)
                    {
                        numeroRQ = "RQ000001";
                    }
                    else
                    {
                        var ultimoRQ = rq.First().codigoRQ;
                        var numeral = Convert.ToInt32(ultimoRQ.Substring(2, ultimoRQ.Length));
                        numeral++;
                        numeroRQ = $"RQ{numeral.ToString().PadLeft(6, '0')}";
                    }
                    dtN.Rows.Add(numeroRQ);


                    using (var reader = ObjectReader.Create(cc, "id", "nombre","nombreCorto"))
                    {
                        dtcc.Load(reader);
                    }
                    using (var reader = ObjectReader.Create(scc, "id", "idCentroCostos", "nombre", "nombreCorto"))
                    {
                        dtscc.Load(reader);
                    }
                    using (var reader = ObjectReader.Create(sscc, "id", "idCentroCostos", "idSubCentroCostos", "nombre", "nombreCorto"))
                    {
                        dtsscc.Load(reader);
                    }
                    using (var reader = ObjectReader.Create(area, "id", "nombre", "nombreCorto"))
                    {
                        dtarea.Load(reader);
                    }
                    ds.Tables.Add(dtcc);
                    ds.Tables.Add(dtscc);
                    ds.Tables.Add(dtsscc);
                    ds.Tables.Add(dtarea);
                    ds.Tables.Add(dtN);

                    return ds;
                }
			}
			catch (Exception ex)
			{
				throw ex;
			}
        }
    }
}
