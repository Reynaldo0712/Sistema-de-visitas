using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace SistemaDeVisitas
{
    public partial class adminconsultcs : Form
    {
        Entidad enti = new Entidad();
        Negocio nego = new Negocio();
        ComboBox combo = new ComboBox();
        public adminconsultcs()
        {
            InitializeComponent();
             nego.select(comboBox1);
            llenar();
        }
        public void llenar()
        {
            DataTable dat = nego.llenargrids();

            dataGridView1.DataSource = dat;



        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            enti.Edificio = int.Parse(comboBox1.Text);
            nego.buscarvisi(enti.Edificio);
            busc(enti.Edificio);
        }


        public void busc(int edificio)
        {
           DataTable dat = nego.buscarvisi(edificio);
           dataGridView1.DataSource = dat;


        }
    }
}
