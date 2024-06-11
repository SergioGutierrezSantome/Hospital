using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Paciente : Persona
    {
        
        public string asignacionmedico;
        public List<Paciente> paciente = new List<Paciente>();
        public Paciente(string dNI, string nombre, string correo, string telefono, string asignacionmedico):base(dNI,nombre,correo,telefono)
        {
         
            this.asignacionmedico = asignacionmedico;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine($"[Paciente] {ToString()}");
        }
        public void Agregar(Paciente pacientes)
        {
                paciente.Add(pacientes);
            
        }
        public override string ToString()
        {
            return $"DNI:{DNI} Nombre: {nombre} Correo: {correo}  Telefono: {telefono} medico asignado: {asignacionmedico}";
        }
    }
    
}
