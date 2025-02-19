using Avalon.AccesoDatos.ClaseAbstracta;
using FastMember;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.AccesoDatos.Repositorio.Maestro
{
    public class servicioRepository:EF_Common
    {
        public DataSet DatosIniciales()
        {
            try
            {
                using (AvalonDBEntities db = new AvalonDBEntities())
                {
                    DataSet ds = new DataSet();
                    DataTable dtCL = new DataTable("CL");
                    DataTable dtSCL = new DataTable("SCL");
                    DataTable dtSSCL = new DataTable("SSCL");


                    var lstCL = db.clase.ToList();
                    var lstSCL = db.subClase.ToList();
                    var lstSSCL = db.subSubClase.ToList();

                    using (var reader = ObjectReader.Create(lstCL, "id", "nombre"))
                    {
                        dtCL.Load(reader);
                    }
                    using (var reader = ObjectReader.Create(lstSCL, "id", "idClase", "nombre"))
                    {
                        dtSCL.Load(reader);
                    }
                    using (var reader = ObjectReader.Create(lstSSCL, "id", "idClase", "idSubClase", "nombre"))
                    {
                        dtSSCL.Load(reader);
                    }
                    ds.Tables.Add(dtCL);
                    ds.Tables.Add(dtSCL);
                    ds.Tables.Add(dtSSCL);

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
