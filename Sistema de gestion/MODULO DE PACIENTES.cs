using Sistema_Gestion;
using System;
using System.Collections.Generic;


namespace Sistema_de_gestion
{
    class Modulo_De_Pacientes
    {
        private List<Paciente> listaDePacientes = new List<Paciente>();
        private Dictionary<int, Paciente> pacientesPorId = new Dictionary<int, Paciente>();
        private Dictionary<int, Paciente> historialPorId = new Dictionary<int, Paciente>();

        public void ModuloPacientes()
        {

            
            while (true)
            {
                Console.WriteLine("\n=== Módulo de Pacientes ===");
                Console.WriteLine("1.- Alta de paciente\t2.- Baja de paciente\t3.- Modificación de datos\t4.- Regresar al Menú Principal");

                if (!int.TryParse(Console.ReadLine(), out int opcion))
                {
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        AltaPaciente();
                        break;
                    case 2:
                        Console.WriteLine("Baja de paciente aún no implementada.");
                        break;
                    case 3:
                        Console.WriteLine("Modificación de paciente aún no implementada.");
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
        public void AltaPaciente()
        {
            Paciente p = new Paciente();
            Console.WriteLine("Ingrese la información del paciente");

            Console.Write("Nombre: ");
            p.Nombre = Console.ReadLine();

            while (true)
            {
                Console.Write("Edad: ");
                if (int.TryParse(Console.ReadLine(), out int edad))
                {
                    p.Edad = edad;
                    break;
                }
                Console.WriteLine("Por favor, ingrese un número válido para la edad.");
            }

            Console.Write("Dirección: ");
            p.Direccion = Console.ReadLine();

            Console.Write("Teléfono: ");
            p.Telefono = Console.ReadLine();

            Console.Write("Correo: ");
            p.Correo = Console.ReadLine();

            Console.Write("Historial: ");
            p.Historial = Console.ReadLine();

            Console.Write("Médico: ");
            p.Medico = Console.ReadLine();

            listaDePacientes.Add(p);
            int id = pacientesPorId.Count + 1;
            p.Id = id;
            pacientesPorId[id] = p;
            historialPorId[id] = p;

            Console.WriteLine($"Paciente agregado con ID: {id}");
        }
    }
}
