using System;
using System.Windows.Forms;
using sysmed.UI;
using sysmed.Tests;

namespace sysmed
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // Si se pasa el parámetro "--test" o "-t", la aplicación corre en modo de simulación y pruebas automáticas
            if (args.Length > 0 && (args[0] == "--test" || args[0] == "-t"))
            {
                bool success = OrderTests.RunTests();
                // Retornamos código de salida adecuado (0 si éxito, 1 si fallo)
                Environment.Exit(success ? 0 : 1);
                return;
            }

            // Ejecución normal de la interfaz gráfica
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}