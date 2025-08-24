using System;

namespace Sistema_Gestion;

class Paciente()
{
    //Datos Personales de los Pacientes 
    private string Nombre { get; set; }
    private int Edad { get; set; }
    private string Direccion { get; set; }
    private int Telefono { get; set; }
    private string Correo { get; set; }
    private string Historial { get; set; }
    private string Medico { get; set; }
}

class Sistema_De_Gestion_Para_Una_Clinica_Medica
{
    // private List<Paciente> listaPacientes = new List<Paciente>();
    private List<Paciente> listaPacientes = new List<Paciente>();




    // Modulo de Pacientes
    public void Alta_Paciente()
    {
        
    }




    //Modulos 
    public void Pacientes()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Modulo de Pacientes");
            Console.WriteLine();
            Console.WriteLine("1.- Alta de paciente\t 2.- Baja de pacientes\t 3.- Modificacion de datos\t 4.- Regresar al Menu Principal\n");
            if (!int.TryParse(Console.ReadLine(), out int Opcion))
            {
                Console.WriteLine("Opción inválida. Intente de nuevo.");
                continue;
            }
            switch (Opcion)
            {
                case 1:
                    
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine();
                    break;


            }
        }

    }
    static void Medicos()
    {
               Console.WriteLine("Modulo de Medicos");
    }
    static void Citas()
    {
               Console.WriteLine("Modulo de Citas");
    }
    static void Consultas()
    {
               Console.WriteLine("Modulo de Consultas");
    }
    static void Administracion()
    {
               Console.WriteLine("Modulo de Administracion");
    }




    static void Main(string[] args)
        
    {
        Sistema_De_Gestion_Para_Una_Clinica_Medica Gestion = new Sistema_De_Gestion_Para_Una_Clinica_Medica( );
        while (true)
        {
            Console.WriteLine("BIENVENIDO AL SISTEMA DE GESTION PARA LA CLINICA \"THE MEDIC CENTER\" \n ");
            Console.WriteLine("Modulos\n ");
            Console.WriteLine("1.- Modulo de Pacientes\t 2.- Modulo de Medicos\t 3.- Modulo de citas\t 4.- Modulo de Consultas\t 5.- Modulo de Administracion \t 6.- Salir\n");
            Console.Write("Opcion: ");
            if (!int.TryParse(Console.ReadLine(), out int Opcion))
            {
                Console.WriteLine("Opción inválida. Intente de nuevo.");
                continue;
            }

            switch (Opcion)
            {
                case 1:
                    Gestion.Pacientes();
                    break;
                case 2:
                    Medicos();
                    break;
                case 3:
                    Citas();
                    break;
                case 4:
                    Consultas();
                    break;
                case 5:
                    Administracion();
                    break;
                case 6:
                    Console.WriteLine("Gracias por usar el sistema de gestion de la clinica \"THE MEDIC CENTER\" ");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }
        }
    }
}