using System;
using Sistema_Gestion;

namespace Sistema_Gestion;

class Paciente()
{
    \
    
    //Datos Personales de los Pacientes 
    public Nombre { get; set; }
    public int Edad { get; set; }
    public string Direccion { get; set; }
    public int Telefono { get; set; }
    public string Correo { get; set; }
    public string Historial { get; set; }
    public string Medico { get; set; }
}

class Sistema_De_Gestion_Para_Una_Clinica_Medica
{
    // private List<Paciente> listaPacientes = new List<Paciente>();
    private List<Paciente> listaPacientes = new List<Paciente>();
    private Dictionary<int, Paciente> id_Paciente = new Dictionary<int, Paciente>();
    private Dictionary<Paciente> Historial_Paciente = new Dictionary<Paciente>



    // Modulo de Pacientes
    public void Alta_Paciente()
    {
        Paciente p = new Paciente();

        Console.WriteLine("Ingrese la informacion del paciente");
    
        Console.WriteLine("Nombre: ");
        p.Nombre = int.Parse(Console.ReadLine());
        Console.WriteLine("Edad");
        p.Edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Direccion:");
        p.Direccion = int.Parse(Console.ReadLine());
        Console.WriteLine("Telefono:");
        p.Telefono = int.Parse(Console.ReadLine());
        Console.WriteLine("Correo:");
        p.Correo = int.Parse(Console.ReadLine());
        Console.WriteLine("Historial:");
        p.Historial = int.Parse(Console.ReadLine());
        Console.WriteLine("Medico:");
        p.Medico = int.Parse(Console.ReadLine());

        listaPacientes.Add(p);
        int id = id_Paciente.Count + 1;
        Historial_Paciente[id] = p;

        Console.WriteLine($"✅ Paciente agregado con ID: {id}");



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