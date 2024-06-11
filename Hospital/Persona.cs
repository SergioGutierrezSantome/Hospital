using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public abstract class Persona
    {
        public List<Persona> persona = new List<Persona>();
        public string DNI;
        public string nombre;
        public string correo;
        public string telefono;
        

        
        public Persona(string dNI, string nombre, string correo, string telefono)
        {
            DNI = dNI;
            this.nombre = nombre;
            this.correo = correo;
            this.telefono = telefono;
        }

        public void Agregar(Persona personas)
        {
            persona.Add(personas);
        }
        public abstract void MostrarInfo();

    }
}
