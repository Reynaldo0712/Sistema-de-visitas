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
    public partial class Form1 : Form
    {

        Entidad enti = new Entidad();
        Negocio nego = new Negocio();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "Usuario";
                textBox1.ForeColor = Color.White;
            }
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

            if (textBox1.Text == "Usuario")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Contraseña";
                textBox2.ForeColor = Color.White;
                textBox2.UseSystemPasswordChar = false;
            }

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Contraseña")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
                textBox2.UseSystemPasswordChar = true;
            }

        }

        private void login_Click(object sender, EventArgs e)
        {

            DataTable dat = new DataTable();
            enti.UserName = textBox1.Text;
            enti.Password = textBox2.Text;
             dat = nego.logins(enti.UserName, enti.Password);

            if (dat.Rows.Count > 0)
            {
                if (dat.Rows[0][3].ToString() == "admin")
                {
                    MessageBox.Show("Bienvenido " + enti.UserName);
                    this.Hide();
                    new admin().Show();
                }
                else if (dat.Rows[0][3].ToString() == "usuario")
                {
                    MessageBox.Show("Bienvenido " + enti.UserName);
                    this.Hide();
                    new receptionist().Show();
                }
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }




        }

        
    }
}
