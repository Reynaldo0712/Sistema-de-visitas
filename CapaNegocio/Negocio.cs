using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidad;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class Negocio
    {

        Datos dat = new Datos();
        Entidad enti = new Entidad();


        public DataTable logins(string UserName, string Password)
        {
            return dat.login(UserName, Password);

        }

        public void crearuser(string UserName, string Password, string usertype, string Nombre, string Apellido, DateTime Fecha)
        {
                        dat.crear(UserName, Password, usertype, Nombre, Apellido, Fecha);

        }
        public void registers(string nombre, string apellido, string carrera, string correo, int Edificio, string Hora,  string motivo, string Aula, string tipo_visita)
        {

            dat.register(nombre, apellido, carrera, correo, Edificio, Hora, motivo,  Aula, tipo_visita);


        }
        public DataTable mostrars()
        {


            return dat.Mostrar();

        }
        public DataTable buscar(int id)
        {
            return dat.BuscarVisita(id);
        }
        public DataTable borrars(int id)
        {
            return dat.borrar(id);
        }

        public void actualizar(string UserName, string Password, string tipo_user, string nombre, string apellido, DateTime fecha, int id)
        {

            dat.editar(UserName,  Password,  tipo_user,  nombre,  apellido,  fecha,id);

        }

        public void obtener1(ComboBox combo)
        {

            dat.Seleccionar(combo);


        }
        public void obtener2(ComboBox combo)
        {

            dat.Seleccionar2(combo);

        }


        public void guardaredi(int edificio)
        {

            dat.guardaredi(edificio);
        }

        public void guardaraula(string aula)
        {

            dat.guardaraula(aula);
        }

        public DataTable Datos()
        {

            return dat.llenarlos();

        }


        public DataTable buscarvisi(int edificio)
        {
            return dat.buscarVisi(edificio);
        }

        public void select(ComboBox combo)
        {
            dat.Seleccionar3(combo);
        }

        public DataTable llenargrids()
        {
            return dat.llenargrid();

        }

        public void modif(int id, int edif)
        {

            dat.modifcar(id, edif);

        }

        public void modif2(int id ,string aula)
        {


            dat.modifcar2(id, aula);


        }
    }
}
