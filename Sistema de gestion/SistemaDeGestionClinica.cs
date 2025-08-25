using Sistema_de_gestion;
using System;
using System.Collections.Generic;

namespace Sistema_Gestion
{
    public class SistemaDeGestionClinica
    {
        private Modulo_De_Pacientes moduloPacientes = new Modulo_De_Pacientes();
        public void ModuloPacientes() => moduloPacientes.ModuloPacientes();

        // Otros módulos
        public static void ModuloMedicos() => Console.WriteLine("=== Módulo de Médicos ===");
        public static void ModuloCitas() => Console.WriteLine("=== Módulo de Citas ===");
        public static void ModuloConsultas() => Console.WriteLine("=== Módulo de Consultas ===");
        public static void ModuloAdministracion() => Console.WriteLine("=== Módulo de Administración ===");
    }
}
