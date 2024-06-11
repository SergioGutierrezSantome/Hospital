using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Medico : Persona
    {
        public List<Medico> medicos = new List<Medico>();
        public string especialidad;
        public Medico(string dNI, string nombre, string correo, string telefono,string especialidad) : base(dNI, nombre, correo, telefono)
        {
            this.especialidad = especialidad;   
        }

        public void Agregar(Medico medico)
        {
            medicos.Add(medico);
        }
       
            
         
        public override void MostrarInfo()
        {
            Console.WriteLine($"[Medico] {ToString()}");
        }
        public override string ToString()
        {
            return $" DNI:{DNI} Nombre: {nombre} Correo: {correo}  Telefono: {telefono}";
        }
    }
}
