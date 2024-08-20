using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        // esto es un comentario de una sola linea

        /* todo lo que esta entre
         * este codigo 
         * es un comentario */

        

        [STAThread]
        static void Main()
        {

            // VARIABLES Y LOS TIPOS DE DATOS

            string Nombre = "Jose";  // asignamos a una variable string el nombre jose
            MessageBox.Show(Nombre); // crea una caja de msj de solo texto con el msj jose

            int num1 = 12;       // le indicamos que va a ser un numero entero
            uint num2 = 24;      // le decimos que el numero va a ser siempre positivo
            float num3 = 35.5f;  // le indicamos que es un numero float, solo ese numero sin redondeo
            double num4 = 45.50; // le decimos que 
            decimal num5 = 64564.5484123m; // le decimos que va a ser un numero decimal con la m al final
            byte num6 = 255;     // como maximo 255, con 256 da error
            bool acceso = true;  // muestra true o false


            MessageBox.Show(num1.ToString());  // lo utilizamos para mostrar el msj que no es un texto

            MessageBox.Show(acceso.ToString());  // muestra true, sirva para hacer comparaciones y validaciones

            DateTime fecha = DateTime.Today;

            MessageBox.Show(fecha.ToString()); // mustra la fecha entera, con hora 00:00:00
            MessageBox.Show(fecha.ToShortDateString().ToString()); // muestra la fecha en formato corto
            MessageBox.Show(fecha.Year.ToString()); // muestra el año solo
            MessageBox.Show(fecha.Month.ToString()); // muestra el mes solo
            //-----------------------------------------------------------------------------------------------------
            //int num7 = 12;
            //int num8 = 12;
            //int num9 = 12;
            //int num10 = 12;           // declaramos las variables en dos lineas
            //int num11 = 12;

            int num7, num8, num9, num10, num11;
            num7 = 12; num8 = 10; num9 = 11; num10 = 15; num11 = 20;

            //-----------------------------------------------------------------------------------------------------
            //---------------CONSTANTES--------------------

            const string dato = " Hola soy jose";  // asigno a una variabla dato un string pero si le pongo const, no varia nunca

            //dato = "Ya no soy mas jose";     // le cambio el string a una variable dato

            MessageBox.Show(dato);          // se muestra la ultima actualizacion

            





            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());  // ejecuta el form principal
        }
    }
}

