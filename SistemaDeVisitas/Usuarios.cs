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
    public partial class Usuarios : Form
    {

        Entidad enti = new Entidad();
        Negocio nego = new Negocio();
        public Usuarios()
        {
            InitializeComponent();
            Listado();
        }
        public void Listado()
        {
            DataTable dat = nego.mostrars();
            dataGridView1.DataSource = dat;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


           
                enti.UserName = txtuser.Text;
                enti.Password = txtpass.Text;
                enti.Nombre = txtname.Text;
                enti.Apellido = txtlast.Text;
                enti.Fecha = Convert.ToDateTime(dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
                enti.Tipo_user = comboBox1.Text;
                nego.crearuser(enti.UserName, enti.Password,enti.Tipo_user, enti.Nombre, enti.Apellido, enti.Fecha);
                limpiar();
                MessageBox.Show("Usuario creado con exito");
            



        }

        public void limpiar()
        {

            txtuser.Clear();
            txtpass.Clear();
            txtname.Clear();
            txtlast.Clear();
            comboBox1.SelectedIndex = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            enti.Id = int.Parse(txtid.Text);
            Listado2();
        }
        public void Listado2()
        {
            DataTable dat = nego.buscar(enti.Id);
            dataGridView1.DataSource = dat;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enti.Id = int.Parse(txtid.Text);
            Listado3();
            Listado();
            MessageBox.Show("Datos eliminados");
        }
        public void Listado3()
        {
            DataTable dat = nego.borrars(enti.Id);
            dataGridView1.DataSource = dat;
        }

        private void button2_Click(object sender, EventArgs e)
        {


            enti.UserName = txtuser.Text;
            enti.Password = txtpass.Text;
            enti.Nombre = txtname.Text;
            enti.Apellido = txtlast.Text;
            enti.Fecha = Convert.ToDateTime(dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
            enti.Tipo_user = comboBox1.Text;
            enti.Id = int.Parse(txtid.Text);
            nego.actualizar(enti.UserName, enti.Password, enti.Tipo_user, enti.Nombre, enti.Apellido, enti.Fecha,enti.Id);
            Listado();
            limpiar();
            MessageBox.Show("Usuario actualizado con exito");

        }

        private void txtid_Enter(object sender, EventArgs e)
        {
            if (txtid.Text == "Ingrese ID")
            {
                txtid.Text = "";
                txtid.ForeColor = Color.White;
                txtid.UseSystemPasswordChar = true;
            }

        }

        private void txtid_Leave(object sender, EventArgs e)
        {

            if (txtid.Text == "")
            {
                txtid.Text = "Ingrese ID";
                txtid.ForeColor = Color.White;
                txtid.UseSystemPasswordChar = false;
            }

        }
    }
}
