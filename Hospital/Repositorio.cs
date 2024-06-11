using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Repositorio<T> where T : Persona
    {
        private List<T> items = new List<T>();

        public void Agregar(T item)
        {
            items.Add(item);
        }
        public List<T> ObtenerTodos()
        {
            return new List<T>(items);
        }
        public void ListaPacientesDeMedico(string id)
        {
           
            foreach (var item in items)
            {
                if (item.DNI == id)
                    Console.WriteLine(item.ToString());
            }
        }
        public T ObtenerPorID(string id)
        {
            return items.Find(i => i.DNI == id);
        }
        public void Eliminar(string id)
        {
            var item = ObtenerPorID(id);
            if (item != null)
            {
                items.Remove(item);
            }
        }
        
    }
}
