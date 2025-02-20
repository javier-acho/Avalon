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
    public class productoRepository:EF_Common
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

                    DataTable dtFam = new DataTable("fam");
                    DataTable dtSFam = new DataTable("sfam");

                    DataTable dtUm = new DataTable("um");


                    var lstCL = db.clase.ToList();
                    var lstSCL = db.subClase.ToList();
                    var lstSSCL = db.subSubClase.ToList();

                    var lstFam = db.familia.ToList();
                    var lstSFam = db.subFamilia.ToList();

                    var lstUm = db.unidadMedida.ToList();

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

                    using (var reader = ObjectReader.Create(lstFam, "id", "nombre"))
                    {
                        dtFam.Load(reader);
                    }
                    using (var reader = ObjectReader.Create(lstSFam, "id", "idFamilia", "nombre"))
                    {
                        dtSFam.Load(reader);
                    }
                    ds.Tables.Add(dtFam);
                    ds.Tables.Add(dtSFam);

                    using (var reader = ObjectReader.Create(lstUm, "id", "nombre"))
                    {
                        dtUm.Load(reader);
                    }

                    ds.Tables.Add(dtUm);
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
