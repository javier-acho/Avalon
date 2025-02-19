using Avalon.Aplicacion.Ayuda;
using Avalon.Utiles;
using Avalon.ViewModel.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalon.Aplicacion.Seguridad
{
    public partial class frmLogin : AvalonForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void sbIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                string usuario = teUsuario.Text;
                string password = teContrasena.Text;

                UsuarioViewModel modelo = new UsuarioViewModel();
                modelo.nomUsu = usuario;
                
                var entidadUsuario = await HelperApi.Execute<UsuarioViewModel,UsuarioViewModel>(Constante.GET_USUARIO,"post",modelo);
                if (ValidarUsuario(entidadUsuario))
                {
                    splashScreenManager1.CloseWaitForm();
                    this.DialogResult = DialogResult.OK;
                }

            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private bool ValidarUsuario(UsuarioViewModel modelo)
        {
            try
            {
                if (modelo == null)
                {
                    throw new Exception("El usuario no existe");
                }
                string passwordInput = teContrasena.Text;
                string keyWord = ConfigurationManager.AppSettings["KeyWord"];
                var password = Encryptar.DecryptText(modelo.password, keyWord);
                if (passwordInput != password)
                {
                    throw new Exception("La contraseña no es la correcta");
                }
                Global.nombreUsuario = modelo.nomUsu;
                Global.nombreCompleto = modelo.nombre;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void sbCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
