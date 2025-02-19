using Avalon.Aplicacion.Ayuda;
using Avalon.Utiles;
using Avalon.ViewModel.Seguridad;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalon.Aplicacion
{
    public partial class frmPrincipal : AvalonForm
    {
        public bool Autorizado { get; set; }
        public frmPrincipal()
        {
            IniciarSistema();
        }
        public async Task IniciarSistema()
        {
            while (Logear())
            {
                Autorizado = true;
                InitializeComponent();
                barStaticItem1.Caption = $"Logeado al sistema AVALON con el usuario : {Global.nombreUsuario} ({Global.nombreCompleto})";
                try
                {
                    splashScreenManager1.ShowWaitForm();
                    splashScreenManager1.SetWaitFormCaption("Cargando Menu");
                    splashScreenManager1.SetWaitFormDescription("Espere...conectando con el servidor");
                    await CargarMenu();
                    splashScreenManager1.CloseWaitForm();
                    return;
                }
                catch (Exception ex)
                {
                    Error(ex);
                }
            }
        }

        private async Task CargarMenu()
        {
            try
            {
                //Traemos los datos
                UsuarioViewModel modelo = new UsuarioViewModel();
                modelo.nomUsu = Global.nombreUsuario;
                var dtMenu = await Utiles.HelperApi.Execute<UsuarioViewModel, DataTable>(Constante.DATA_MENU, "post", modelo);

                //Creamos el Menu
                foreach (DataRow fila in dtMenu.AsEnumerable().Where(x => x["padre"] == DBNull.Value).OrderBy(x => Convert.ToInt32(x["orden"])))
                {
                    NavBarGroup group = new NavBarGroup();
                    group.Name = fila["nombre"].ToString();
                    group.Caption = fila["nombre"].ToString();

                    string modulo = fila["nombre"].ToString();
                    var menuHijos = dtMenu.AsEnumerable().Where(x => x["padre"].ToString() == fila["id"].ToString()).CopyToDataTable();

                    TreeList tl = new TreeList();
                    tl.Columns.AddField("codigo");
                    tl.Columns["codigo"].Visible = false;
                    tl.Columns.AddField("modulo");
                    tl.Columns["modulo"].Visible = false;
                    tl.Columns.AddField("arbol");
                    tl.Columns["arbol"].Visible = true;
                    tl.Columns["arbol"].OptionsColumn.AllowEdit = false;
                    //tl.Columns["arbol"].OptionsFilter.AutoFilterCondition = DevExpress.XtraTreeList.Columns.AutoFilterCondition.Contains;
                    tl.OptionsView.ShowColumns = false;
                    tl.Dock = DockStyle.Fill;
                    tl.OptionsView.ShowHorzLines = false;
                    tl.OptionsView.ShowVertLines = false;
                    //tl.OptionsView.ShowAutoFilterRow = true;
                    tl.OptionsView.ShowIndicator = false;
                    tl.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
                    tl.OptionsBehavior.EnableFiltering = true;
                    tl.OptionsBehavior.AllowIncrementalSearch = true;
                    tl.OptionsBehavior.ExpandNodesOnIncrementalSearch = true;
                    //tl.OptionsFilter.FilterMode = FilterMode.Smart;
                    tl.OptionsSelection.InvertSelection = true;
                    //tl.SelectImageList = imageCollection1;
                    tl.KeyDown += new KeyEventHandler(tl_KeyDown);
                    tl.DoubleClick += new EventHandler(tl_DoubleClick);

                    TreeView tree = new TreeView();
                    foreach (DataRow f in menuHijos.Rows)
                    {
                        string codigoMenu = f["id"].ToString();
                        string nombreMenu = f["nombre"].ToString();

                        AgregarNodo(tree.Nodes, codigoMenu, nombreMenu, modulo, dtMenu);
                    }

                    NavBarGroupControlContainer container = new NavBarGroupControlContainer();
                    group.GroupStyle = NavBarGroupStyle.ControlContainer;

                    group.ControlContainer = container;
                    group.Visible = true;

                    GeneraTreeList(tree.Nodes, null, tl);

                    navMenu.Controls.Add(container);
                    container.Controls.Add(tl);

                    navMenu.Groups.Add(group);
                }
                navMenu.ResetStyles();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void tl_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                TreeList tl = (TreeList)sender;
                if (tl != null)
                {
                    TreeList trvw = tl;
                    string texto = trvw.FocusedNode.GetDisplayText("arbol");
                    string modulo = trvw.FocusedNode.GetDisplayText("modulo");
                    string codigo = trvw.FocusedNode.GetDisplayText("codigo");
                    AbrirVentana(modulo, codigo);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void AbrirVentana(string modulo, string codigo)
        {
            switch (modulo)
            {
                case "Configuracion": InvocaFormularioProduccion(codigo); break;
                case "Maestros": InvocaFormularioProduccion(codigo); break;
               
                default: break;
            }
        }

        private void InvocaFormularioProduccion(string id)
        {
            try
            {
                string appExterna = "";
                AvalonForm formulario = null;
                splashScreenManager1.ShowWaitForm();
                switch (id)
                {
                    case "2": formulario = new Seguridad.frmUsuario(); break;
                    case "11": formulario = new Maestros.frmSocioNegocio(); break;
                    case "12": formulario = null; break;
                    case "13": formulario = new Maestros.frmProducto("P"); break;
                    case "14": formulario = new Maestros.frmProducto("S"); break;
                    case "15": formulario = null; break;
                    case "16": formulario = null; break;
                    case "17": formulario = null; break;

                    default: break;
                }
                if (formulario != null)
                {
                    formulario.MdiParent = this;
                    formulario.FormBorderStyle = this.FormBorderStyle;
                    formulario.Show();
                    splashScreenManager1.CloseWaitForm();
                }
                else
                    splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void tl_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    tl_DoubleClick(this, null);
                    break;
            }
        }

        private void AgregarNodo(TreeNodeCollection nodes, string codigoMenu, string nombreMenu, string modulo, DataTable dtMenu)
        {
            bool esPadre = dtMenu.AsEnumerable().Where(x => x["padre"].ToString() == codigoMenu).Count() > 0;
            if (!nodes.ContainsKey(codigoMenu) || esPadre)
            {
                TreeNode hijo = new TreeNode(codigoMenu);
                hijo.Tag = modulo;
                hijo.Name = codigoMenu;
                hijo.Text = nombreMenu;
                nodes.Add(hijo);
                if (esPadre)
                {
                    var hijos = dtMenu.AsEnumerable().Where(x => x["Padre"].ToString() == codigoMenu).CopyToDataTable();
                    foreach (DataRow h in hijos.Rows)
                    {
                        string codigoMenuH = h["id"].ToString();
                        string nombreMenuH = h["nombre"].ToString();
                        AgregarNodo(nodes[codigoMenu].Nodes, codigoMenuH, nombreMenuH, modulo, dtMenu);
                    }
                }
            }
        }
        private void GeneraTreeList(TreeNodeCollection collection, TreeListNode nodoPadre, TreeList tl)
        {
            foreach (TreeNode node in collection)
            {
                TreeListNode nodoHijo;

                if (node.Parent == null)
                    nodoHijo = tl.AppendNode(null, null);
                else
                    nodoHijo = tl.AppendNode(null, nodoPadre);


                nodoHijo.SetValue("arbol", node.Text);
                nodoHijo.SetValue("codigo", node.Name);
                nodoHijo.SetValue("modulo", node.Tag);
                //nodoHijo.StateImageIndex = 3;
                //nodoHijo.SelectImageIndex = 4;

                if (node.GetNodeCount(true) > 0)
                    GeneraTreeList(node.Nodes, nodoHijo, tl);
            }
        }
        private bool Logear()
        {
            bool salida = false;
            try
            {
                Seguridad.frmLogin login = new Seguridad.frmLogin();
                var resultado = login.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    salida = true;
                }
            }
            catch (Exception ex)
            {
                Error(ex);
            }
            return salida;
        }
    }
}
