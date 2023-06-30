using Farmacia.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class ventana_agregar : Form
    {
        public ventana_agregar(string id, string nombre, string descripcion, double precio, int cantidad, string fecha)
        {
            InitializeComponent();

            //Asignamos los valores del registro que seleccionamos 
            txt_nombre.Text = nombre;
            txt_id.Text = id;
            txt_descripcion.Text = descripcion;
            txt_cantidad.Text = cantidad.ToString();
            txt_precio.Text = precio.ToString();
            txt_fecha.Text = fecha;
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_fecha_TextChanged(object sender, EventArgs e)
        {

        }



        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ventana_ventas_Load(object sender, EventArgs e)
        {

        }

        private void ventana_ventas_Load_1(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string[] pedirDatos() //Se usara en la ventana de ventana_farmacia para saber el id, cantidad vendida y el precio final
        {
            string[] lista = new string[3];
            lista[0] = txt_id.Text;
            lista[1] = string.Concat(txt_cantidad_agregar.Value);


            return lista;
        }

        private void bt_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
            txt_nombre.Text = "";
            txt_id.Text = "";
            txt_descripcion.Text = "";
            txt_cantidad.Text = "";
            txt_precio.Text = "";
            txt_fecha.Text = "";
            txt_cantidad_agregar.Value = 0;
        }

        private void bt_calcular_venta_Click(object sender, EventArgs e)
        {
            if (txt_cantidad_agregar.Value != 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Digite la cantidad a registrar del producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
