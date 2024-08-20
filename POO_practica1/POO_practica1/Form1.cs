using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO_practica1.Productos;
using Productos;  // llamamos a namespace Productos

namespace POO_practica1   
{
    public partial class Form1 : Form   // se creo la clase
    {
        Telefono Movistar = new Telefono();  // aca creamos un objeto telefono, dentro del namaspace Productos 
        Telefono Claro = new Telefono("Samsung");
        Telefono Personal = new Telefono("Motorolla", "Azul", "Tactil");

        Persona p = new Persona(); // objeto creado


        public Form1()   // se creo el metodo, con el mismo nombre, esto se llama metodo constructor
        {
            InitializeComponent();
        }

        private void btn_llamar_Click(object sender, EventArgs e)
        {
            //Movistar.Llamar();  // llamamos al metodo constructor por defecto dentro del objeto
            //Movistar.Marca = "Samsung"; // aca le decimos variables dentro de la clase public marca que cambie el valor a samsung, y la muestra 
            //Movistar.Llamar();
            //Claro.Llamar();  // llamamos a metodo constructor con parametro
            //Personal.Llamar();  // llamamos a metodo contructor con los 3 parametros

            //MessageBox.Show(Movistar.MandarMensajes("Jose", "Hola a todos estoy probando tecnologia binaria")); // aca llamamos al metodo y le pedimos que lo muestre

            //MessageBox.Show(Operaciones.Suma(100, 350).ToString()); // llamamos al metodo statico no inicializado en ningun objeto

           
            p.Pais = "Argentina";
            p.Nid = "2764";
            MessageBox.Show(p.Nombre);
            MessageBox.Show(p.Pais);
            MessageBox.Show(p.Nid);

        }
    }
}

