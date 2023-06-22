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
        public ventana_ventas(string id, string nombre, string descripcion, double precio, int cantidad , string fecha)
        {
            InitializeComponent();
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

        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            bool verificar_numero; //Booleano para comprobar si el tipo de dato que registro el usuario es correcto
            int cantidad = 0; //Almacenara la variable de lo txt_cantidad, pero tenenmos que comprobar el tipo de variable que son
            int iva = 0; //Almacenara las variable de lo txt_iva, pero tenenmos que comprobar el tipo de variable que son
            int descuento = 0; //Almacenara las variable de lo txt_iva, pero tenenmos que comprobar el tipo de variable que son


            //Comprueba si la cantidad es un entero
            verificar_numero = int.TryParse(txt_cantidad.Text, out cantidad);

            if (txt_descuento.Text != "" && txt_iva.Text != "")
            {
                if (verificar_numero)
                {

                    //Reutilizamos la misma variable para confirmar si la variable es un número
                    verificar_numero = false;

                    //Comprueba si el descuento es un entero
                    verificar_numero = int.TryParse(txt_descuento.Text, out descuento);

                    if (verificar_numero)
                    {
                        //Reutilizamos la misma variable para confirmar si la variable es un número
                        verificar_numero = false;

                        //Comprueba si el descuento es un entero
                        verificar_numero = int.TryParse(txt_iva.Text, out iva);

                        if (verificar_numero)
                        {                        
                            if (txt_cantidad_vender.Value > 0)
                            {
                                if (descuento >= 0)
                                {
                                    if (iva >= 0)
                                    {
                                       MessageBox.Show("Hik");
                                    }
                                    else
                                    {
                                       MessageBox.Show("El iva debe ser mayor o igual a 0, vuelva a intentarlo");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("El descuento debe ser mayor o igual a 0, vuelva a intentarlo");
                                }
                            }
                            else
                            {
                                MessageBox.Show("La cantida a vender debe ser mayor a 0, vuelva a intentarlo");
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("El iva que digito no es un numero valido, vuelva a intentarlo");
                        }

                    }
                    else
                    {
                        MessageBox.Show("El descuento que digito no es un numero valido, vuelva a intentarlo");

                    }
                }
                else
                {
                    MessageBox.Show("La cantidad que digito no es un numero valido, vuelva a intentarlo");

                }
            }
            else
            {
                MessageBox.Show("Llena los campos vacios");

            }

            bt_realizar_venta.Enabled = true;
        }

        private void ventana_ventas_Load(object sender, EventArgs e)
        {

        }
    }
}
