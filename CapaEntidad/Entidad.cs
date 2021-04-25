using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaEntidad
{
    public class Entidad
    {

        private string userName;
        private string password;
        private string nombre;
        private string apellido;
        private DateTime fecha;
        private string tipo_user;
        private string carrera;
        private int edificio;
        private string hora;
        private string motivo;
        private string aula;
        private PictureBox foto;
        private string correo;
        private int id;
        
        private string tipo_visita;
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Tipo_user { get => tipo_user; set => tipo_user = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public int Edificio { get => edificio; set => edificio = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public string Aula { get => aula; set => aula = value; }
        public PictureBox Foto { get => foto; set => foto = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Id { get => id; set => id = value; }
        public string Tipo_visita { get => tipo_visita; set => tipo_visita = value; }
    }
}
