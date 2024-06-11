using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Administrativo : Persona
    {
        public List<Administrativo> administrativo = new List<Administrativo>();
        public Administrativo(string dNI, string nombre, string correo, string telefono):base(dNI,nombre,correo,telefono)
        {

        }
        public void Agregar(Administrativo administrativos)
        {
            administrativo.Add(administrativos);

        }
        public override void MostrarInfo()
        {
            Console.WriteLine($"[Administrativo] {ToString()}");
        }
        public override string ToString()
        {
            return $"DNI:{DNI} Nombre: {nombre} Correo: {correo}  Telefono: {telefono}";
        }
    }
}
