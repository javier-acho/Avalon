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
    public partial class frmCrearUsuario : AvalonForm
    {
        string tipoEvento = "";
        string nombreUsuario;
        int idUsuarioModifica = -1;
        string keyWord = string.Empty;
        string password = "";
        public frmCrearUsuario(string tipoEvento, string nombreUsuario = null)
        {
            InitializeComponent();
            keyWord = ConfigurationManager.AppSettings["KeyWord"];
            this.tipoEvento = tipoEvento;
            this.nombreUsuario = nombreUsuario;
        }

        private async void sbGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                UsuarioViewModel modelo = new UsuarioViewModel();
                if (tipoEvento == "C")
                {
                    
                    modelo.nomUsu = teUsuario.Text;
                    modelo.nombre = teNombre.Text;
                    var encriptado = Encryptar.EncryptText(tePassword.Text, keyWord);
                    modelo.password = encriptado;
                    modelo.usuCrea = Global.nombreUsuario;

                    if (tePassword.Text != tePasswordConfirmar.Text)
                    {
                        throw new Exception("Las contraseñas no son iguales");
                    }
                    var resutlado = await Utiles.HelperApi.Execute<UsuarioViewModel, UsuarioViewModel>(Constante.USUARIO, "post", modelo);
                }
                else
                {
                    modelo.id = idUsuarioModifica;
                    modelo.nomUsu = teUsuario.Text;
                    modelo.nombre = teNombre.Text;
                    if (!string.IsNullOrEmpty(tePassword.Text))
                    {
                        if (tePassword.Text != tePasswordConfirmar.Text)
                        {
                            throw new Exception("Las contraseñas no son iguales");
                        }
                        var encriptado = Encryptar.EncryptText(tePassword.Text, keyWord);
                        modelo.password = encriptado;
                    }
                    else
                    {
                        modelo.password = password;
                    }
                    var salida = await Utiles.HelperApi.Execute<UsuarioViewModel, UsuarioViewModel>(Constante.USUARIO, "put", modelo);
                }
                splashScreenManager1.CloseWaitForm();
                Mensaje("Se registro con exito");
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
            teUsuario.Limpiar();
            tePassword.Limpiar();
            tePasswordConfirmar.Limpiar();
        }

        private async void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            if (tipoEvento == "M")
            {
                sbGuardar.Text = "Modificar";
                await CargarDatos(nombreUsuario);
            }
        }

        private async Task CargarDatos(string nombreUsuario)
        {
            try
            {
                UsuarioViewModel m = new UsuarioViewModel();
                m.nomUsu = nombreUsuario;
                var modelo = await Utiles.HelperApi.Execute<UsuarioViewModel, UsuarioViewModel>(Constante.GET_USUARIO, "post", m);
                idUsuarioModifica = modelo.id;
                teUsuario.Text = modelo.nomUsu;
                teNombre.Text = modelo.nombre;
                
                
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }
    }
}
