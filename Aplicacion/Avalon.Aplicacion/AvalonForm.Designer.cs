
namespace Avalon.Aplicacion
{
    partial class AvalonForm
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
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Avalon.Aplicacion.WaitForm1), true, true);
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // AvalonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 303);
            this.IconOptions.Image = global::Avalon.Aplicacion.Properties.Resources.logoAA_3;
            this.Name = "AvalonForm";
            this.Text = "AvalonForm";
            this.Load += new System.EventHandler(this.AvalonForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}