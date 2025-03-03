namespace Avalon.Aplicacion.Maestros
{
    partial class frmSubCentroCostosAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubCentroCostosAgregar));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.teNombreCorto = new DevExpress.XtraEditors.TextEdit();
            this.teNombre = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teNombreCorto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNombre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Nombre Corto";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Nombre";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbGuardar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 63);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(262, 52);
            this.panelControl1.TabIndex = 18;
            // 
            // sbGuardar
            // 
            this.sbGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbGuardar.ImageOptions.SvgImage")));
            this.sbGuardar.Location = new System.Drawing.Point(162, 6);
            this.sbGuardar.Name = "sbGuardar";
            this.sbGuardar.Size = new System.Drawing.Size(95, 34);
            this.sbGuardar.TabIndex = 11;
            this.sbGuardar.Text = "Guardar";
            this.sbGuardar.Click += new System.EventHandler(this.sbGuardar_Click);
            // 
            // teNombreCorto
            // 
            this.teNombreCorto.Location = new System.Drawing.Point(85, 32);
            this.teNombreCorto.Name = "teNombreCorto";
            this.teNombreCorto.Size = new System.Drawing.Size(161, 20);
            this.teNombreCorto.TabIndex = 22;
            // 
            // teNombre
            // 
            this.teNombre.Location = new System.Drawing.Point(55, 6);
            this.teNombre.Name = "teNombre";
            this.teNombre.Size = new System.Drawing.Size(191, 20);
            this.teNombre.TabIndex = 20;
            // 
            // frmSubCentroCostosAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 115);
            this.Controls.Add(this.teNombreCorto);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.teNombre);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmSubCentroCostosAgregar.IconOptions.Image")));
            this.Name = "frmSubCentroCostosAgregar";
            this.Text = "Agregar Sub CC";
            this.Load += new System.EventHandler(this.frmSubCentroCostosAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teNombreCorto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNombre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teNombreCorto;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit teNombre;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbGuardar;
    }
}