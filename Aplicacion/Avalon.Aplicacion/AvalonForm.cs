using DevExpress.XtraEditors;
using System;

namespace Avalon.Aplicacion
{
    public partial class AvalonForm : XtraForm
    {
        public AvalonForm()// : base()
        {
            
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            InitializeComponent();
        }
        public void Error(Exception ex)
        {
            if (splashScreenManager1.IsSplashFormVisible)
                splashScreenManager1.CloseWaitForm();
            XtraMessageBox.Show(ex.Message, "Mensaje", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }
        public void Error(string msg)
        {
            XtraMessageBox.Show(msg, "Mensaje", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }
        public void Mensaje(string msg)
        {
            XtraMessageBox.Show(msg, "Mensaje", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        private void AvalonForm_Load(object sender, EventArgs e)
        {
            this.IconOptions.Image = Properties.Resources.logoAA_3;
        }
    }
}
