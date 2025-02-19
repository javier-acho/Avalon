
namespace Avalon.Aplicacion.Seguridad
{
    partial class frmMantenimientoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoUsuario));
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.SuspendLayout();
            // 
            // sbAgregar
            // 
            this.sbAgregar.Appearance.Options.UseTextOptions = true;
            this.sbAgregar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.sbAgregar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.sbAgregar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbAgregar.ImageOptions.SvgImage")));
            // 
            // sbEliminar
            // 
            this.sbEliminar.Appearance.Options.UseTextOptions = true;
            this.sbEliminar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.sbEliminar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.sbEliminar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbEliminar.ImageOptions.SvgImage")));
            // 
            // sbModificar
            // 
            this.sbModificar.Appearance.Options.UseTextOptions = true;
            this.sbModificar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.sbModificar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.sbModificar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbModificar.ImageOptions.SvgImage")));
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(547, 63);
            // 
            // gcData
            // 
            this.gcData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcData.Location = new System.Drawing.Point(0, 63);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(547, 260);
            this.gcData.TabIndex = 1;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsPrint.AutoWidth = false;
            this.gvData.OptionsView.ColumnAutoWidth = false;
            this.gvData.OptionsView.ShowAutoFilterRow = true;
            this.gvData.OptionsView.ShowFooter = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            // 
            // frmMantenimientoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 323);
            this.Controls.Add(this.gcData);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmMantenimientoUsuario.IconOptions.Image")));
            this.Name = "frmMantenimientoUsuario";
            this.Text = "frmMantenimientoUsuario";
            this.Load += new System.EventHandler(this.frmMantenimientoUsuario_Load);
            this.Controls.SetChildIndex(this.panelControl1, 0);
            this.Controls.SetChildIndex(this.gcData, 0);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData;
    }
}