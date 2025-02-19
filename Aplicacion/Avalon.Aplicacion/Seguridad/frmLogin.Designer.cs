
namespace Avalon.Aplicacion.Seguridad
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teUsuario = new DevExpress.XtraEditors.TextEdit();
            this.teContrasena = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.sbIniciar = new DevExpress.XtraEditors.SimpleButton();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.teUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teContrasena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Usuario";
            // 
            // teUsuario
            // 
            this.teUsuario.Location = new System.Drawing.Point(74, 12);
            this.teUsuario.Name = "teUsuario";
            this.teUsuario.Size = new System.Drawing.Size(100, 20);
            this.teUsuario.TabIndex = 1;
            // 
            // teContrasena
            // 
            this.teContrasena.Location = new System.Drawing.Point(74, 38);
            this.teContrasena.Name = "teContrasena";
            this.teContrasena.Properties.PasswordChar = '*';
            this.teContrasena.Properties.UseSystemPasswordChar = true;
            this.teContrasena.Size = new System.Drawing.Size(100, 20);
            this.teContrasena.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Contraseña";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbCancelar);
            this.panelControl1.Controls.Add(this.sbIniciar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 72);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(254, 45);
            this.panelControl1.TabIndex = 4;
            // 
            // sbCancelar
            // 
            this.sbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbCancelar.ImageOptions.Image")));
            this.sbCancelar.Location = new System.Drawing.Point(154, 5);
            this.sbCancelar.Name = "sbCancelar";
            this.sbCancelar.Size = new System.Drawing.Size(95, 34);
            this.sbCancelar.TabIndex = 1;
            this.sbCancelar.Text = "Cancelar";
            this.sbCancelar.Click += new System.EventHandler(this.sbCancelar_Click);
            // 
            // sbIniciar
            // 
            this.sbIniciar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbIniciar.ImageOptions.Image")));
            this.sbIniciar.Location = new System.Drawing.Point(53, 5);
            this.sbIniciar.Name = "sbIniciar";
            this.sbIniciar.Size = new System.Drawing.Size(95, 34);
            this.sbIniciar.TabIndex = 0;
            this.sbIniciar.Text = "Iniciar";
            this.sbIniciar.Click += new System.EventHandler(this.sbIniciar_Click);
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Location = new System.Drawing.Point(180, 12);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(69, 46);
            this.svgImageBox1.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Stretch;
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 5;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.sbIniciar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.sbCancelar;
            this.ClientSize = new System.Drawing.Size(254, 117);
            this.Controls.Add(this.svgImageBox1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.teContrasena);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.teUsuario);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmLogin.IconOptions.Image")));
            this.Name = "frmLogin";
            this.Text = "Inicio Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.teUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teContrasena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teUsuario;
        private DevExpress.XtraEditors.TextEdit teContrasena;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraEditors.SimpleButton sbCancelar;
        private DevExpress.XtraEditors.SimpleButton sbIniciar;
    }
}