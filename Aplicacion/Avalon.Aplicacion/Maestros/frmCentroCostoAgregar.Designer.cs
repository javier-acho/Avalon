
namespace Avalon.Aplicacion.Maestros
{
    partial class frmCentroCostoAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCentroCostoAgregar));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teNombre = new DevExpress.XtraEditors.TextEdit();
            this.teNombreCorto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNombreCorto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbGuardar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 74);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(265, 52);
            this.panelControl1.TabIndex = 13;
            // 
            // sbGuardar
            // 
            this.sbGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbGuardar.ImageOptions.SvgImage")));
            this.sbGuardar.Location = new System.Drawing.Point(165, 6);
            this.sbGuardar.Name = "sbGuardar";
            this.sbGuardar.Size = new System.Drawing.Size(95, 34);
            this.sbGuardar.TabIndex = 11;
            this.sbGuardar.Text = "Guardar";
            this.sbGuardar.Click += new System.EventHandler(this.sbGuardar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Nombre";
            // 
            // teNombre
            // 
            this.teNombre.Location = new System.Drawing.Point(55, 12);
            this.teNombre.Name = "teNombre";
            this.teNombre.Size = new System.Drawing.Size(191, 20);
            this.teNombre.TabIndex = 15;
            // 
            // teNombreCorto
            // 
            this.teNombreCorto.Location = new System.Drawing.Point(85, 38);
            this.teNombreCorto.Name = "teNombreCorto";
            this.teNombreCorto.Size = new System.Drawing.Size(161, 20);
            this.teNombreCorto.TabIndex = 17;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Nombre Corto";
            // 
            // frmCentroCostoAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 126);
            this.Controls.Add(this.teNombreCorto);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.teNombre);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmCentroCostoAgregar.IconOptions.Image")));
            this.Name = "frmCentroCostoAgregar";
            this.Text = "Agregar CC";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNombreCorto.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbGuardar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teNombre;
        private DevExpress.XtraEditors.TextEdit teNombreCorto;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}