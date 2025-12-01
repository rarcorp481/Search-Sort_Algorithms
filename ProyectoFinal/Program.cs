using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public class ResultadoAlgoritmo
    {
        public string Nombre { get; set; }
        public int CantidadElementos { get; set; }
        public double TiempoSegundos { get; set; }
        public long Pasos { get; set; } // <--- ESTA ES LA CLAVE DE TU GRÁFICA
        public string Tipo { get; set; }
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
            Application.Run(new FrmPrincipal());
        }
    }
}