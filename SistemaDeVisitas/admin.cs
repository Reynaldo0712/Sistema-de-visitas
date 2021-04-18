using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVisitas
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        

       

        private void logout_Click(object sender, EventArgs e)
        {
            Form formul = new Form1();

            formul.Show();

            this.Hide();
            


        }

        private void usuario_Click(object sender, EventArgs e)
        {
            Form formul = new Usuarios();

            addForm(formul);



        }
        public void addForm(Form r)
        {
            if (panel2.Controls.Count > 0)
            {
                this.panel2.Controls.RemoveAt(0);
            }

            r.TopLevel = false;
            this.panel2.Controls.Add(r);
            r.Dock = DockStyle.Fill;
            r.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            Form formul = new adminconsultcs();

            addForm(formul);
        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form formul = new admin();

            formul.Show();
            this.Close();
          
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Form formul = new edificio();

            addForm(formul);
        }

         

    }
}
