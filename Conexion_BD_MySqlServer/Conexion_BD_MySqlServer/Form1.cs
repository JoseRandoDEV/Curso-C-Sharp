using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Conexion_BD_MySqlServer
{
    public partial class Form1 : Form
    {
        static string conexionstring = "server=localhost ; port=3306 ; user=root ; password=Jose25957620 ; database=bd_mysql_c";
        MySqlConnection conexion = new MySqlConnection(conexionstring);


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show("La conexion a la Base de Datos: " + conexion.Database + " ha sido Exitosa..");
        }

        private void btn_desconectar_Click(object sender, EventArgs e)
        {
            conexion.Close();
            MessageBox.Show("Se ha Desconectado a la Base de datos...");
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            if (txt_buscar.Text == "")
            {
                string query = "select * from personas";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgv_texto.DataSource = tabla;
            }
            else
            {
                string query = "select * from personas where Pais = '"+txt_buscar.Text+"' ";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                MySqlDataAdapter data = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgv_texto.DataSource = tabla;
            }
        }

        public void consulta()
        {
            string query = "select * from personas";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            MySqlDataAdapter data = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dgv_texto.DataSource = tabla;
        }

        

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string cadena = "INSERT INTO personas (Nombre, Edad , Pais , NID) values  ('"+text_nombre.Text+"','"+text_edad.Text+"','"+text_pais.Text+"','"+text_nid.Text+"') ";

            MySqlCommand comando = new MySqlCommand(cadena,conexion);
            comando.ExecuteNonQuery();    // insertar los nuevos campos

            MessageBox.Show("La persona: " + text_nombre.Text + " Se agrego Correctamente");

            text_nombre.Text = "";   // esto es para limpiar los campos
            text_pais.Text = "";
            text_edad.Text = "";
            text_nid.Text = "";

            consulta();  // actualizamos el view
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            // delete from personas where Nombre = ''

            int flag = 0;
            string cadena = "delete from personas where Nombre = '"+text_nombre.Text+"'";
            MySqlCommand comando = new MySqlCommand(cadena, conexion);
            flag = comando.ExecuteNonQuery();    // si el resdultado es positivo nos da un 1, y si es negativo nos da 0

            if (flag == 1)
            {
                MessageBox.Show("Se realizo el delete correctamente..");
            }
            else
            {
                MessageBox.Show("No se encontro al la persona a eliminar");
            }
            text_nombre.Text = "";   // esto es para limpiar los campos
            consulta();  // actualizamos el view
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string cadena = "update personas set Nombre = '"+text_nombre.Text+"' , Edad = '"+text_edad.Text+"' , Pais = '"+text_pais.Text+"' , NID = '"+text_nid.Text+"' WHERE Nombre = '"+text_nombreabuscar.Text+"'";
            MySqlCommand comando = new MySqlCommand(cadena, conexion);
            flag = comando.ExecuteNonQuery();    // si el resdultado es positivo nos da un 1, y si es negativo nos da 0

            if (flag == 1)
            {
                MessageBox.Show("Se realizo la actualizacion correctamente..");
            }
            else
            {
                MessageBox.Show("No se encontro al la persona a actualizar");
            }
            text_nombre.Text = "";   // esto es para limpiar los campos
            text_pais.Text = "";
            text_edad.Text = "";
            text_nid.Text = "";
            text_nombreabuscar.Text = "";

            consulta();  // actualizamos el view
        }
    }
    
}
