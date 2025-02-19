using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalon.Aplicacion.Maestros
{
    public partial class frmServicioAgregar : AvalonForm
    {
        string tipoEvento = "";
        int idServicio;
        public frmServicioAgregar(string tipoEvento, int idServicio = -1)
        {
            InitializeComponent();
            this.tipoEvento = tipoEvento;
            this.idServicio = idServicio;
        }
    }
}
