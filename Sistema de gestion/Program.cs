using System;

namespace Sistema_Gestion;

class Sistema_De_Gestion_Para_Una_Clinica_Medica
{





    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("BIENVENIDO AL SISTEMA DE GESTION PARA LA CLINICA \"THE MEDIC CENTER\" \n ");
            Console.WriteLine("Modulos\n ");
            Console.WriteLine("1.- Modulo de Pacientes\t 2.- Modulo de Medicos\t 3.- Modulo de citas\t 4.- Modulo de Consultas\t 5.- Modulo de Administracion\n");
            Console.WriteLine("6.- Salir ");
            int Opcion = int.Parse(Console.ReadLine());
            break;

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
                case 5:
                    break;
                case 6:
                    break;
                default:

            }

        }
    }
}