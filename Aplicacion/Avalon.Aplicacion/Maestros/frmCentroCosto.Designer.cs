
namespace Avalon.Aplicacion.Maestros
{
    partial class frmCentroCosto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCentroCosto));
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.gvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbAsignarPerfil = new DevExpress.XtraEditors.SimpleButton();
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
            this.sbAgregar.Click += new System.EventHandler(this.sbAgregar_Click);
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
            this.sbModificar.Click += new System.EventHandler(this.sbModificar_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbAsignarPerfil);
            this.panelControl1.Size = new System.Drawing.Size(800, 63);
            this.panelControl1.Controls.SetChildIndex(this.sbAgregar, 0);
            this.panelControl1.Controls.SetChildIndex(this.sbModificar, 0);
            this.panelControl1.Controls.SetChildIndex(this.sbEliminar, 0);
            this.panelControl1.Controls.SetChildIndex(this.sbAsignarPerfil, 0);
            // 
            // gcData
            // 
            this.gcData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcData.Location = new System.Drawing.Point(0, 63);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(800, 387);
            this.gcData.TabIndex = 1;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvData.GridControl = this.gcData;
            this.gvData.Name = "gvData";
            this.gvData.OptionsDetail.EnableMasterViewMode = false;
            this.gvData.OptionsView.ColumnAutoWidth = false;
            this.gvData.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nombre";
            this.gridColumn1.FieldName = "nombre";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nombre Corto";
            this.gridColumn2.FieldName = "nombreCorto";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Estado";
            this.gridColumn3.FieldName = "estado";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // sbAsignarPerfil
            // 
            this.sbAsignarPerfil.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.sbAsignarPerfil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbAsignarPerfil.ImageOptions.SvgImage")));
            this.sbAsignarPerfil.Location = new System.Drawing.Point(264, 4);
            this.sbAsignarPerfil.Name = "sbAsignarPerfil";
            this.sbAsignarPerfil.Size = new System.Drawing.Size(78, 53);
            this.sbAsignarPerfil.TabIndex = 4;
            this.sbAsignarPerfil.Text = "Sub CC";
            // 
            // frmCentroCosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gcData);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmCentroCosto.IconOptions.Image")));
            this.Name = "frmCentroCosto";
            this.Text = "Centro de Costo";
            this.Load += new System.EventHandler(this.frmCentroCosto_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton sbAsignarPerfil;
    }
}