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
    public partial class ventana_ventas : Form
    {
        public ventana_ventas(string id, string nombre, string descripcion, double precio, int cantidad, string fecha)
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

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            bool verificar_numero; //Booleano para comprobar si el tipo de dato que registro el usuario es correcto
            int cantidad = int.Parse(txt_cantidad.Text); //Almacenara la variable de lo txt_cantidad, pero tenenmos que comprobar el tipo de variable que son
            double iva = 0.15; //Almacenara las variable de lo txt_iva, pero tenenmos que comprobar el tipo de variable que son
            int descuento; //Almacenara las variable de lo txt_iva, pero tenenmos que comprobar el tipo de variable que son



            if (txt_descuento.Text != "")
            {
                if (cantidad >= txt_cantidad_vender.Value)
                {

                    //Reutilizamos la misma variable para confirmar si la variable es un número
                    verificar_numero = false;

                    //Comprueba si el descuento es un entero
                    verificar_numero = int.TryParse(txt_descuento.Text, out descuento);

                    if (verificar_numero)

                    {
                        descuento = int.Parse(txt_descuento.Text); //Como confirmamos que el dato que digito el txt_descuento es un numero entonces le asignamos ese valor

                        if (txt_cantidad_vender.Value > 0) //Comprueba que el usuario digito un numero correcto en la cantidad de medicamentos a vender
                        {
                            if (descuento >= 0 && descuento <= 100)
                            {

                                // Validaciones de los campos de descuento e iva

                                double total_venta = ((int)txt_cantidad_vender.Value * double.Parse(txt_precio.Text));//Variable para sacar el total de los gastos del iva y descuentos digitado
                                txt_sub_total.Text = total_venta.ToString(); // Agregamos el sub total al txt_sub_total

                                if (check_iva.Checked) //Si se le va agregar el iva al medicamento
                                {
                                    //Calculamos el iva total de la venta total
                                    double iva_total = total_venta * iva;

                                    //Agregamor el total en el txt_iva_total
                                    txt_total_iva.Text = iva_total.ToString();
                                }
                                else
                                {
                                    //Calculamos el iva total de la venta total
                                    double iva_total = 0;

                                    //Agregamor el total en el txt_iva_total
                                    txt_total_iva.Text = iva_total.ToString();
                                }

                                if (descuento > 0)
                                {
                                    //Calculamos el iva total de la venta total
                                    double descuento_total = total_venta * ((double)descuento / 100);

                                    //Agregamor el total en el txt_iva_total
                                    txt_total_descuento.Text = descuento_total.ToString();
                                }
                                else
                                {
                                    //Calculamos el descuento total de la venta total
                                    double descuento_total = 0;

                                    //Agregamor el total en el txt_iva_total
                                    txt_total_descuento.Text = descuento_total.ToString();
                                }

                                total_venta = total_venta - double.Parse(txt_total_descuento.Text); // Aplicamos el descuento al sub total
                                total_venta = total_venta + double.Parse(txt_total_iva.Text); // Aplicamos el iva al sub total

                                txt_total.Text = total_venta.ToString();
                                bt_realizar_venta.Enabled = true;

                            }
                            else
                            {
                                MessageBox.Show("El descuento debe ser mayor o igual a 0 y menor o igual a 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }

                        else
                        {
                            MessageBox.Show("La cantida a vender debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("El descuento que digito no es un numero valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    MessageBox.Show("La cantidad a vender debe ser menor o igual que la cantidad incial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Llena los campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

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
            lista[1] = string.Concat(txt_cantidad_vender.Value);
            lista[2] = txt_total.Text;


            return lista;
        }
    }
}
