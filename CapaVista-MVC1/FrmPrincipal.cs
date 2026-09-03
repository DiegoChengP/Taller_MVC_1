using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_MVC1;

namespace CapaVista_MVC1
{
    public partial class FrmPrincipal : Form
    {
        string nombreTabla = "tbl_aplicaciones";
        Controlador controlador = new Controlador();
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        public void actualizarDataGridView()
        {
            DataTable dtVista = controlador.llenarDgv(nombreTabla);
            dgvConsultaTabla.DataSource = dtVista;  
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            actualizarDataGridView();
        }
    }
}
