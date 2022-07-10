using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBox_TimePicker
{
    public class Estudiante
    {
        private string nombre;
        public string Nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public Estudiante(string nombre)
        {
            this.nombre = nombre;
        }

        public Estudiante() { }
    }
}
