using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Datos
    {
        //SAUL WAS HEREs
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        SqlCommand comando;
        Entidad enti = new Entidad();
        
         public DataTable login(string UserName, string Password)
        {

        con.Open();


            comando = new SqlCommand("lg_visitas", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", UserName);
            comando.Parameters.AddWithValue("@contraseña", Password);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
       
        public void crear(string UserName, string Password, string tipo_user, string nombre, string apellido, DateTime fecha)
        {

            con.Open();


            comando = new SqlCommand("crear", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", UserName);
            comando.Parameters.AddWithValue("@contraseña", Password);
            comando.Parameters.AddWithValue("@tipo_usuario", tipo_user);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.ExecuteNonQuery();

            con.Close();
        }

        public void register(string nombre, string apellido,string carrera, string correo, int Edificio, string Hora, string motivo,string Aula,string tipo_visita)
        {

            con.Open();


            comando = new SqlCommand("registro", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@carrera", carrera);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@Edificio", Edificio);
            comando.Parameters.AddWithValue("@Hora", Hora);
            comando.Parameters.AddWithValue("@motivo", motivo);
            comando.Parameters.AddWithValue("@Aula", Aula);
            comando.Parameters.AddWithValue("@tipo_visita", tipo_visita);
            comando.ExecuteNonQuery();
            con.Close();

        }
        public DataTable BuscarVisita(int id)
        {



            con.Open();
            SqlCommand comando = new SqlCommand("BuscarVisita", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@id", id));

            comando.ExecuteNonQuery();

            SqlDataAdapter data1 = new SqlDataAdapter(comando);

            DataTable dat1 = new DataTable();

            data1.Fill(dat1);
            con.Close();
            return dat1;




        }
        public DataTable borrar(int id)
        {



            con.Open();
            SqlCommand comando = new SqlCommand("borrar", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@id", id));

            comando.ExecuteNonQuery();

            SqlDataAdapter data1 = new SqlDataAdapter(comando);

            DataTable dat1 = new DataTable();

            data1.Fill(dat1);
            con.Close();
            return dat1;




        }

        public DataTable Mostrar()
        {

            SqlCommand comando = new SqlCommand("llenar", con);

            comando.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable dat = new DataTable();

            data.Fill(dat);

            return dat;



        }

        public void editar(string UserName, string Password, string tipo_user, string nombre, string apellido, DateTime fecha,int id)
        {



            con.Open();
            comando = new SqlCommand("editar", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", UserName);
            comando.Parameters.AddWithValue("@contraseña", Password);
            comando.Parameters.AddWithValue("@tipo_usuario", tipo_user);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            con.Close();
        }







        public void Seleccionar(ComboBox combo)
        {
            combo.Items.Clear();
            con.Open();
            SqlCommand comando = new SqlCommand("Registrar2", con);
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                combo.Items.Add(dr[1].ToString());
            }
            con.Close();
            combo.Items.Insert(0, "Seleccione el edificio");
            combo.SelectedIndex = 0;
        }
        public void Seleccionar2(ComboBox combo)
        {
            combo.Items.Clear();
            con.Open();
            SqlCommand comando = new SqlCommand("Registrar1", con);
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                combo.Items.Add(dr[1].ToString());
            }
            con.Close();
            combo.Items.Insert(0, "Seleccione el aula");
            combo.SelectedIndex = 0;
        }




        public void guardaredi(int edificio)
        {



            con.Open();
            comando = new SqlCommand("guardaredi", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@edificio", edificio);
            comando.ExecuteNonQuery();

            con.Close();
        }

        public void guardaraula(string aula)
        {



            con.Open();
            comando = new SqlCommand("guardaraula", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@aula", aula);
            comando.ExecuteNonQuery();

            con.Close();
        }




        
        public DataTable llenarlos()
        {

            SqlCommand comando = new SqlCommand("llenarlos", con);

            comando.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable dat = new DataTable();

            data.Fill(dat);

            return dat;



        }


        public DataTable buscarVisi(int edificio)
        {

            SqlCommand comando = new SqlCommand("buscarVisi", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@edificio", edificio);
            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable dat = new DataTable();

            data.Fill(dat);

            return dat;



        }

        public void Seleccionar3(ComboBox combo)
        {
            combo.Items.Clear();
            con.Open();
            SqlCommand comando = new SqlCommand("Registrar2", con);
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                combo.Items.Add(dr[1].ToString());
            }
            con.Close();
            combo.Items.Insert(0, "Seleccione el edificio");
            combo.SelectedIndex = 0;
        }

      


        public DataTable llenargrid()
        {

            SqlCommand comando = new SqlCommand("llenargrid", con);

            comando.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable dat = new DataTable();

            data.Fill(dat);

            return dat;



        }

        public void modifcar(int id, int edfi)
        {

            con.Open();
            comando = new SqlCommand("modif", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@edificio", edfi);
            comando.ExecuteNonQuery();

            con.Close();


        }
        public void modifcar2(int id, string aula)
        {

            con.Open();
            comando = new SqlCommand("modif2", con);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@aula", aula);
            comando.ExecuteNonQuery();

            con.Close();


        }
    }
}
