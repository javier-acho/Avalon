﻿
namespace Avalon.Aplicacion.Seguridad
{
    partial class frmMantenimientoPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimientoPerfil));
            this.sbAsignarPerfil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
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
            this.panelControl1.Controls.Add(this.sbAsignarPerfil);
            this.panelControl1.Size = new System.Drawing.Size(800, 63);
            this.panelControl1.Controls.SetChildIndex(this.sbAgregar, 0);
            this.panelControl1.Controls.SetChildIndex(this.sbModificar, 0);
            this.panelControl1.Controls.SetChildIndex(this.sbEliminar, 0);
            this.panelControl1.Controls.SetChildIndex(this.sbAsignarPerfil, 0);
            // 
            // sbAsignarPerfil
            // 
            this.sbAsignarPerfil.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.sbAsignarPerfil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbAsignarPerfil.ImageOptions.SvgImage")));
            this.sbAsignarPerfil.Location = new System.Drawing.Point(264, 5);
            this.sbAsignarPerfil.Name = "sbAsignarPerfil";
            this.sbAsignarPerfil.Size = new System.Drawing.Size(78, 53);
            this.sbAsignarPerfil.TabIndex = 4;
            this.sbAsignarPerfil.Text = "Asignar Perfil";
            // 
            // frmMantenimientoPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmMantenimientoPerfil.IconOptions.Image")));
            this.Name = "frmMantenimientoPerfil";
            this.Text = "frmMantenimientoPerfil";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbAsignarPerfil;
    }
}