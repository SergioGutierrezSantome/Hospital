using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Program
    {
        static Repositorio<Administrativo> repositorioAdmin = new Repositorio<Administrativo>();
        static Repositorio<Medico> repositorioMedicos = new Repositorio<Medico>();
        static Repositorio<Paciente> repositorioPaciente = new Repositorio<Paciente>();
        static Repositorio<Persona> repositorioPersona = new Repositorio<Persona>();
        static void Main(string[] args)
        {
            int opc = 20;
            String nombre, DNI, correo, telefono,especialidad;
            
            List<Paciente> pacientes = repositorioPaciente.ObtenerTodos();
            List<Persona> personas = repositorioPersona.ObtenerTodos();

            while (opc != 0)
            {
                Console.WriteLine("Hospital");
                Console.WriteLine("1.Dar de alta un medico ");
                Console.WriteLine("2.Dar de alta un paciente, para un médico concreto");
                Console.WriteLine("3.Dar de alta personal administrativo");
                Console.WriteLine("4.Listar los médicos ");
                Console.WriteLine("5.Listar los pacientes de un medico ");
                Console.WriteLine("6. Eliminar a un paciente");
                Console.WriteLine("7.Ver la lista de personas del hospital");
                Console.WriteLine("0.SALIR");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("DNI");
                        DNI = Console.ReadLine();
                        Console.WriteLine("Nombre");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Correo Electronico");
                        correo = Console.ReadLine();
                        Console.WriteLine("Telefono");
                        telefono = Console.ReadLine();
                        Console.WriteLine("especialidad");
                        especialidad = Console.ReadLine();
                        Medico NuevoMedico = new Medico(DNI, nombre, correo, telefono, especialidad);
                        repositorioMedicos.Agregar(NuevoMedico);
                        repositorioPersona.Agregar(NuevoMedico);
                    break;
                    case 2:
                        Console.WriteLine("DNI");
                        DNI = Console.ReadLine();
                        Console.WriteLine("Nombre");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Correo Electronico");
                        correo = Console.ReadLine();
                        Console.WriteLine("Telefono");
                        telefono = Console.ReadLine();
                        String MedicoSeleccionado="";
                        List<Medico> medicos = repositorioMedicos.ObtenerTodos();
                        foreach (var medico in medicos)
                        {
                            medico.MostrarInfo();
                        }
                        Console.WriteLine("Que medico le asignamos al paciente");
                        MedicoSeleccionado = Console.ReadLine();
                        var MedicoAsignado = repositorioMedicos.ObtenerPorID(MedicoSeleccionado).DNI;
                        Console.WriteLine("Seleccionado: "+MedicoAsignado);
                        repositorioPaciente.Agregar(new Paciente(DNI, nombre, correo, telefono, MedicoAsignado!=null?MedicoAsignado:""));
                        repositorioPersona.Agregar(new Paciente(DNI, nombre, correo, telefono, MedicoAsignado != null ? MedicoAsignado : ""));
                    break;
                    case 3:          
                        Console.WriteLine("DNI");
                        DNI = Console.ReadLine();
                        Console.WriteLine("Nombre");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Correo Electronico");
                        correo = Console.ReadLine();
                        Console.WriteLine("Telefono");
                        telefono = Console.ReadLine();
                        repositorioAdmin.Agregar(new Administrativo(DNI, nombre, correo, telefono));
                    break;
                    case 4:
                        List<Medico> medicoss = repositorioMedicos.ObtenerTodos();
                        foreach (var medico in medicoss)
                        {
                            medico.MostrarInfo();
                        }
                        break;
                    case 6:
                        string DNII = "";
                        List<Paciente> pacientess = repositorioPaciente.ObtenerTodos();
                        foreach (var medico in pacientess)
                        {
                            medico.MostrarInfo();
                        }
                        Console.WriteLine("Selecciona el paciente que quieras borrar");
                        DNII = Console.ReadLine();
                        repositorioPaciente.Eliminar(DNII);
                    break;
                    case 5:
                        List<Medico> listmedicos = repositorioMedicos.ObtenerTodos();
                        List<Paciente> listpaciente = repositorioPaciente.ObtenerTodos();
                        foreach (var medico in listmedicos)
                        {
                            medico.MostrarInfo();
                        }
                        Console.WriteLine("selecciona un medico para ver sus pacientes");
                        DNII = Console.ReadLine();
                        repositorioPaciente.ListaPacientesDeMedico(DNII);

                        break;
                    case 7:
                        List<Paciente> listpacientes = repositorioPaciente.ObtenerTodos();
                        List<Medico> listmedico = repositorioMedicos.ObtenerTodos();
                        List<Administrativo> listadministrativo = repositorioAdmin.ObtenerTodos();

                        foreach (var paciente in listpacientes)
                        {
                            paciente.MostrarInfo();
                        }
                        foreach (var medico in listmedico)
                        {
                            medico.MostrarInfo();
                        }
                        foreach (var admin in listadministrativo)
                        {
                            admin.MostrarInfo();
                        }
                       

                        break;
                }
            }
        }
    }
}

