using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.Aplicacion.Ayuda
{
    public static class Extensiones
    {
        public static void Limpiar(this TextEdit te)
        {
            te.Text = "";
        }
        public static void SelectedIndex(this LookUpEdit lue, string fieldValue)
        {
            if (lue.Properties.DataSource == null)
                return;
            if (lue.Properties.DataSource.GetType().ToString() == "System.Data.DataTable")
            {
                var ds = lue.Properties.DataSource;
                DataTable dt = (DataTable)ds;
                if (dt.Rows.Count > 0)
                {
                    var id = dt.Rows[0][fieldValue];
                    lue.EditValue = id;
                }
            }
            else
            {
                
            }
        }
    }
}
