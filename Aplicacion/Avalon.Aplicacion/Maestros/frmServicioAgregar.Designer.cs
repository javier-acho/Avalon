
namespace Avalon.Aplicacion.Maestros
{
    partial class frmServicioAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServicioAgregar));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.meDescripcion = new DevExpress.XtraEditors.MemoEdit();
            this.chkCompra = new DevExpress.XtraEditors.CheckEdit();
            this.chkVenta = new DevExpress.XtraEditors.CheckEdit();
            this.teNombreServicio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.teCodigoServicio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNombreServicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCodigoServicio.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbGuardar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 254);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(553, 52);
            this.panelControl1.TabIndex = 13;
            // 
            // sbGuardar
            // 
            this.sbGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbGuardar.ImageOptions.SvgImage")));
            this.sbGuardar.Location = new System.Drawing.Point(453, 6);
            this.sbGuardar.Name = "sbGuardar";
            this.sbGuardar.Size = new System.Drawing.Size(95, 34);
            this.sbGuardar.TabIndex = 11;
            this.sbGuardar.Text = "Guardar";
            this.sbGuardar.Click += new System.EventHandler(this.sbGuardar_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.xtraTabControl1);
            this.panelControl2.Location = new System.Drawing.Point(0, 64);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(553, 190);
            this.panelControl2.TabIndex = 20;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(549, 186);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(547, 161);
            this.xtraTabPage1.Text = "General";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.meDescripcion);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(547, 161);
            this.xtraTabPage2.Text = "Comentarios";
            // 
            // meDescripcion
            // 
            this.meDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.meDescripcion.Location = new System.Drawing.Point(0, 0);
            this.meDescripcion.Name = "meDescripcion";
            this.meDescripcion.Size = new System.Drawing.Size(547, 221);
            this.meDescripcion.TabIndex = 0;
            // 
            // chkCompra
            // 
            this.chkCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCompra.Location = new System.Drawing.Point(371, 12);
            this.chkCompra.Name = "chkCompra";
            this.chkCompra.Properties.Caption = "Para Compra";
            this.chkCompra.Size = new System.Drawing.Size(89, 20);
            this.chkCompra.TabIndex = 29;
            // 
            // chkVenta
            // 
            this.chkVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkVenta.Location = new System.Drawing.Point(466, 12);
            this.chkVenta.Name = "chkVenta";
            this.chkVenta.Properties.Caption = "Para Venta";
            this.chkVenta.Size = new System.Drawing.Size(75, 20);
            this.chkVenta.TabIndex = 28;
            // 
            // teNombreServicio
            // 
            this.teNombreServicio.Location = new System.Drawing.Point(60, 38);
            this.teNombreServicio.Name = "teNombreServicio";
            this.teNombreServicio.Size = new System.Drawing.Size(287, 20);
            this.teNombreServicio.TabIndex = 27;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Nombre";
            // 
            // teCodigoServicio
            // 
            this.teCodigoServicio.Location = new System.Drawing.Point(60, 12);
            this.teCodigoServicio.Name = "teCodigoServicio";
            this.teCodigoServicio.Size = new System.Drawing.Size(92, 20);
            this.teCodigoServicio.TabIndex = 23;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Codigo";
            // 
            // frmServicioAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 306);
            this.Controls.Add(this.chkCompra);
            this.Controls.Add(this.chkVenta);
            this.Controls.Add(this.teNombreServicio);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.teCodigoServicio);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmServicioAgregar.IconOptions.Image")));
            this.Name = "frmServicioAgregar";
            this.Text = "Nuevo Servicio";
            this.Load += new System.EventHandler(this.frmServicioAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNombreServicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCodigoServicio.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbGuardar;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.MemoEdit meDescripcion;
        private DevExpress.XtraEditors.CheckEdit chkCompra;
        private DevExpress.XtraEditors.CheckEdit chkVenta;
        private DevExpress.XtraEditors.TextEdit teNombreServicio;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit teCodigoServicio;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}