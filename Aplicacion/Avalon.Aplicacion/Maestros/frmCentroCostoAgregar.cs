using Avalon.Aplicacion.Ayuda;
using Avalon.Utiles;
using Avalon.ViewModel.Maestros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalon.Aplicacion.Maestros
{
    public partial class frmCentroCostoAgregar : AvalonForm
    {
        string tipoEvento;
        int idCC;
        public frmCentroCostoAgregar(string tipoEvento, int idCC = -1)
        {
            InitializeComponent();
            this.tipoEvento = tipoEvento;
            if(tipoEvento == "M")
            {
                sbGuardar.Text = "Modificar";
                this.idCC = idCC;
            }
        }

        private async void sbGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                if (idCC > 0)
                {
                    centroCostosViewModel cc = new centroCostosViewModel();
                    cc.id = idCC;
                    cc.nombre = teNombre.Text;
                    cc.nombreCorto = teNombreCorto.Text;
                    cc.estado = true;

                    var salida = await Utiles.HelperApi.Execute<centroCostosViewModel, centroCostosViewModel>(Constante.CENTRO_COSTO, "put", cc);
                }
                else
                {
                    centroCostosViewModel cc = new centroCostosViewModel();
                    cc.nombre = teNombre.Text;
                    cc.nombreCorto = teNombreCorto.Text;
                    cc.estado = true;

                    var salida = await Utiles.HelperApi.Execute<centroCostosViewModel, centroCostosViewModel>(Constante.CENTRO_COSTO, "post", cc);
                }
                splashScreenManager1.CloseWaitForm();
                Mensaje("Se registro con éxito");
                Limpiar();
                
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void Limpiar()
        {
            teNombre.Limpiar();
            teNombreCorto.Limpiar();
        }

        private async void frmCentroCostoAgregar_Load(object sender, EventArgs e)
        {
            if(tipoEvento == "M")
            {
                await CargarDatos();
            }
        }

        private async Task CargarDatos()
        {
            try
            {
                if(idCC >0)
                {
                    var cc = await Utiles.HelperApi.ExecuteGet<centroCostosViewModel>($"{Constante.CENTRO_COSTO}/{idCC}");
                    teNombre.Text = cc.nombre;
                    teNombreCorto.Text = cc.nombreCorto;
                }
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }
    }
}
