using System;

namespace Sistema_Gestion
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaDeGestionClinica gestion = new SistemaDeGestionClinica();

            while (true)
            {
                Console.WriteLine("\n=== BIENVENIDO AL SISTEMA DE GESTIÓN \"THE MEDIC CENTER\" ===");
                Console.WriteLine("1.- Módulo de Pacientes\t2.- Módulo de Médicos\t3.- Módulo de Citas\t4.- Módulo de Consultas\t5.- Módulo de Administración\t6.- Salir");
                Console.Write("Opción: ");

                if (!int.TryParse(Console.ReadLine(), out int opcion))
                {
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        gestion.ModuloPacientes();
                        break;
                    case 2:
                        SistemaDeGestionClinica.ModuloMedicos();
                        break;
                    case 3:
                        SistemaDeGestionClinica.ModuloCitas();
                        break;
                    case 4:
                        SistemaDeGestionClinica.ModuloConsultas();
                        break;
                    case 5:
                        SistemaDeGestionClinica.ModuloAdministracion();
                        break;
                    case 6:
                        Console.WriteLine("Gracias por usar el sistema de gestión \"THE MEDIC CENTER\"");
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}
