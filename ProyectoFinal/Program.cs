using System;
using System.Collections.Generic;
using System.Drawing;


namespace ProyectoFinal
{
    // Estructura de datos modificada a Segundos
    public class ResultadoAlgoritmo
    {
        public string Nombre { get; set; }
        public int CantidadElementos { get; set; }
        public double TiempoSegundos { get; set; } // Cambio: Segundos
        public string Tipo { get; set; } // "Busqueda" o "Ordenamiento"
    }

    public static class DatosGlobales
    {
        public static List<ResultadoAlgoritmo> Resultados = new List<ResultadoAlgoritmo>();
        public static Color ColorFondo = Color.WhiteSmoke;
    }

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Asegúrate de que tu Form inicial sea FrmHome o FrmPrincipal según tu proyecto
            Application.Run(new FrmPrincipal());
        }
    }
}