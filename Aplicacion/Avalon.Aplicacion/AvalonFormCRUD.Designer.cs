
namespace Avalon.Aplicacion
{
    partial class AvalonFormCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvalonFormCRUD));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.sbModificar = new DevExpress.XtraEditors.SimpleButton();
            this.sbAgregar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbEliminar);
            this.panelControl1.Controls.Add(this.sbModificar);
            this.panelControl1.Controls.Add(this.sbAgregar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(551, 63);
            this.panelControl1.TabIndex = 0;
            // 
            // sbEliminar
            // 
            this.sbEliminar.Appearance.Options.UseTextOptions = true;
            this.sbEliminar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.sbEliminar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.sbEliminar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbEliminar.ImageOptions.SvgImage")));
            this.sbEliminar.Location = new System.Drawing.Point(180, 5);
            this.sbEliminar.Name = "sbEliminar";
            this.sbEliminar.Size = new System.Drawing.Size(78, 53);
            this.sbEliminar.TabIndex = 2;
            this.sbEliminar.Text = "Eliminar";
            // 
            // sbModificar
            // 
            this.sbModificar.Appearance.Options.UseTextOptions = true;
            this.sbModificar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.sbModificar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.sbModificar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbModificar.ImageOptions.SvgImage")));
            this.sbModificar.Location = new System.Drawing.Point(96, 5);
            this.sbModificar.Name = "sbModificar";
            this.sbModificar.Size = new System.Drawing.Size(78, 53);
            this.sbModificar.TabIndex = 1;
            this.sbModificar.Text = "Modificar";
            // 
            // sbAgregar
            // 
            this.sbAgregar.Appearance.Options.UseTextOptions = true;
            this.sbAgregar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.sbAgregar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.sbAgregar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbAgregar.ImageOptions.SvgImage")));
            this.sbAgregar.Location = new System.Drawing.Point(12, 5);
            this.sbAgregar.Name = "sbAgregar";
            this.sbAgregar.Size = new System.Drawing.Size(78, 53);
            this.sbAgregar.TabIndex = 0;
            this.sbAgregar.Text = "Agregar";
            // 
            // AvalonFormCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 346);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("AvalonFormCRUD.IconOptions.Image")));
            this.Name = "AvalonFormCRUD";
            this.Text = "AvalonFormCRUD";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraEditors.SimpleButton sbAgregar;
        public DevExpress.XtraEditors.SimpleButton sbEliminar;
        public DevExpress.XtraEditors.SimpleButton sbModificar;
        public DevExpress.XtraEditors.PanelControl panelControl1;
    }
}