
namespace Avalon.Aplicacion.Seguridad
{
    partial class frmCrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearUsuario));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tePasswordConfirmar = new DevExpress.XtraEditors.TextEdit();
            this.teNombre = new DevExpress.XtraEditors.TextEdit();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.teUsuario = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tePasswordConfirmar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUsuario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbGuardar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 64);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(356, 47);
            this.panelControl1.TabIndex = 0;
            // 
            // sbGuardar
            // 
            this.sbGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbGuardar.ImageOptions.SvgImage")));
            this.sbGuardar.Location = new System.Drawing.Point(249, 5);
            this.sbGuardar.Name = "sbGuardar";
            this.sbGuardar.Size = new System.Drawing.Size(95, 34);
            this.sbGuardar.TabIndex = 10;
            this.sbGuardar.Text = "Guardar";
            this.sbGuardar.Click += new System.EventHandler(this.sbGuardar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Usuario";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Password";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(134, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Nombre";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(160, 41);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Confirmar Password";
            // 
            // tePasswordConfirmar
            // 
            this.tePasswordConfirmar.Location = new System.Drawing.Point(262, 38);
            this.tePasswordConfirmar.Name = "tePasswordConfirmar";
            this.tePasswordConfirmar.Properties.PasswordChar = '*';
            this.tePasswordConfirmar.Properties.UseSystemPasswordChar = true;
            this.tePasswordConfirmar.Size = new System.Drawing.Size(82, 20);
            this.tePasswordConfirmar.TabIndex = 8;
            // 
            // teNombre
            // 
            this.teNombre.Location = new System.Drawing.Point(186, 12);
            this.teNombre.Name = "teNombre";
            this.teNombre.Size = new System.Drawing.Size(158, 20);
            this.teNombre.TabIndex = 4;
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(64, 38);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.PasswordChar = '*';
            this.tePassword.Properties.UseSystemPasswordChar = true;
            this.tePassword.Size = new System.Drawing.Size(82, 20);
            this.tePassword.TabIndex = 6;
            // 
            // teUsuario
            // 
            this.teUsuario.Location = new System.Drawing.Point(64, 12);
            this.teUsuario.Name = "teUsuario";
            this.teUsuario.Size = new System.Drawing.Size(64, 20);
            this.teUsuario.TabIndex = 2;
            // 
            // frmCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 111);
            this.Controls.Add(this.tePasswordConfirmar);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.teNombre);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.tePassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.teUsuario);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmCrearUsuario.IconOptions.Image")));
            this.Name = "frmCrearUsuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.frmCrearUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tePasswordConfirmar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUsuario.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbGuardar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teUsuario;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit teNombre;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tePasswordConfirmar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}