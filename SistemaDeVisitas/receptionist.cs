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
    public partial class receptionist : Form
    {
        Entidad enti = new Entidad();
        Negocio nego = new Negocio();
        ComboBox combo = new ComboBox();
        ComboBox combo1 = new ComboBox();

        public receptionist()
        {
            InitializeComponent();
            nego.obtener1(comboBox1);
            nego.obtener2(comboBox2);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form formul = new Form1();

            formul.Show();

            this.Hide();
        }



        private void btncargar_Click(object sender, EventArgs e)
        {

            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    pictureBox1.Load(this.openFileDialog1.FileName);
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show("imagen no disponible" + EX.ToString());
            }



        }

        private void btnsave_Click(object sender, EventArgs e)
        {


            enti.Nombre = txtname.Text;
            enti.Apellido = txtlast.Text;
            enti.Carrera = txtcareer.Text;
            enti.Correo = txtemail.Text;
            enti.Edificio = int.Parse(comboBox1.Text);
            enti.Hora = dateTimePicker1.Text;
            enti.Motivo = richTextBox1.Text;
            enti.Aula = comboBox2.Text;
            string valor = string.Empty;


            if (radioButton1.Checked == true)
            {

                valor = "Estudiante";

            }
            else if (radioButton2.Checked == true)
            {
                valor = "Visitante";
            }

            nego.registers(enti.Nombre, enti.Apellido, enti.Carrera, enti.Correo, enti.Edificio, enti.Hora,  enti.Motivo, enti.Aula, valor);
            mostrar();
            limpiar();
            MessageBox.Show("Datos guardados");

        }

        public void limpiar()
        {
            txtname.Clear();
            txtcareer.Clear();
            txtemail.Clear();
            richTextBox1.Clear();
            txtlast.Clear();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }
        private void receptionist_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        public void mostrar()
        {
            DataTable dat = nego.Datos();
            dataGridView1.DataSource = dat;
        
        }
    }

}
