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
    public partial class edificio : Form
    {
        Entidad enti = new Entidad();
        Negocio nego = new Negocio();

        public edificio()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            enti.Edificio = int.Parse(textBox1.Text);
            enti.Aula = textBox2.Text;
            nego.guardaredi(enti.Edificio);
            nego.guardaraula(enti.Aula);
            textBox1.Clear();
            textBox2.Clear();
            MessageBox.Show("Edificio agregado");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            enti.Id = int.Parse(textBox1.Text);
            enti.Aula = textBox2.Text;

            nego.modif(enti.Id, enti.Edificio);
            nego.modif2(enti.Id, enti.Aula);


            MessageBox.Show("Datos actualizados");


        }

       

        

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Ingrese ID")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.White;
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Ingrese ID";
                textBox3.ForeColor = Color.White;
                textBox3.UseSystemPasswordChar = false;
            }
        }
    }
}
