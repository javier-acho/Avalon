using DevExpress.Skins;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalon.Aplicacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SkinManager.EnableFormSkins();



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SkinManager.EnableFormSkins();
            SkinManager.EnableMdiFormSkins();
            //Application.Run(new SeleccionNE.frmSeleccionarNE());
            var culture = CultureInfo.GetCultureInfo("es-PE");

            // this may fail sometimes: (see Drachenkatze's comment below)
            // var culture = new CultureInfo("en-US");

            //Culture for any thread
            CultureInfo.DefaultThreadCurrentCulture = culture;

            //Culture for UI in any thread
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            //Application.Run(new Seguridad.frmMantenimientoUsuario());
            var obj = new frmPrincipal();
            if (obj.Autorizado)
            {
                Application.Run(obj);
                //Application.Run(new Seguridad.frmMantenimientoUsuario());
                //Application.Run(new Logistica.frmMaestroMateriales());
            }
        }
    }
}
