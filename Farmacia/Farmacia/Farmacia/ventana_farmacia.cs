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
using System.Xml.Serialization;


namespace Farmacia
{
    public partial class ventana_farmacia : Form
    {

        //Instacia de una lista de objetos con Medicamentos
        List<Medicamentos> medicamentos = new List<Medicamentos>();

        //Intancia del objeto de Medicamentos
        Medicamentos medi = new Medicamentos();

        //Control de las filas de la tabla
        int n = 0;

        public ventana_farmacia() // inicializa los componentes de la ventana y rellena la tabla con el metodo de "llenarTabla" con datos de ejemplo
        {
            InitializeComponent();
            llenarTabla();
        }




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ventana_farmacia_Load(object sender, EventArgs e)
        {

        }

        public void button3_Click_1(object sender, EventArgs e)
        {
            if (txt_id.Text == "" && txt_nombre.Text == "" && txt_descripcion.Text == ""
                && txt_cantidad.Text == "" && txt_precio.Text == "" && txt_fecha.Text == "") //Comprueba que ningun campo este vacio
            {
                MessageBox.Show("Llena los campos vacios");
            }
            else
            {
                if (controlador_medicamento())
                {
                    ventana_ventas formulario_ventas = new ventana_ventas(txt_id.Text, txt_nombre.Text,
                    txt_descripcion.Text, double.Parse(txt_precio.Text), int.Parse(txt_cantidad.Text), txt_fecha.Text); //Pasar por parametro los datos seleccionados para poder hacer la venta 

                    formulario_ventas.ShowDialog();
                }

            }
                
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (txt_id.Text == "" && txt_nombre.Text == "" && txt_descripcion.Text == ""
                && txt_cantidad.Text == "" && txt_precio.Text == "" && txt_fecha.Text == "") //Comprueba que ningun campo este vacio
            {
                MessageBox.Show("Llena los campos vacios");
            } else
            {

                if (controlador_medicamento()) //Este if sirve para comprobar si el usuario digito bien los datos a los text fields correspondientes
                {
                    MessageBox.Show("Se guardo con exito el medicamento " + txt_nombre.Text); //Mensaje en pantalla

                    int n = tb_medicamentos.Rows.Add(); //Fila que selecciono el usuario en la tabla de medicamentos

                    tb_medicamentos.Rows[n].Cells[0].Value = txt_id.Text;
                    tb_medicamentos.Rows[n].Cells[1].Value = txt_nombre.Text;
                    tb_medicamentos.Rows[n].Cells[2].Value = txt_descripcion.Text;
                    tb_medicamentos.Rows[n].Cells[3].Value = txt_cantidad.Text;
                    tb_medicamentos.Rows[n].Cells[4].Value = txt_precio.Text;
                    tb_medicamentos.Rows[n].Cells[5].Value = txt_fecha.Text;
                    tb_medicamentos.Rows[n].Cells[6].Value = 0;
                    limpiarCampos();
                }
                
            }
            
        }



        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id.Text == "" && txt_nombre.Text == "" && txt_descripcion.Text == ""
              && txt_cantidad.Text == "" && txt_precio.Text == "" && txt_fecha.Text == "") //Comprueba que ningun campo este vacio
                {
                    MessageBox.Show("Llena los campos vacios");
                }
                else
                {
                    if (n != -1)
                    {
                        MessageBox.Show("Se elimino el medicamento: " + txt_nombre.Text);
                        tb_medicamentos.Rows.RemoveAt(n); //En la fila seleccionada por el usuario, la elimina completamente
                        n = 0; //Se asigna en 0 para que el usuario pueda elegir nuevamente otro registro de la tabla
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar un registro");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error de" + ex);
            }
    
        }

        private void tb_medicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex; //Asignarle el valor de la posicion en donde el usuario selecciono

            if(n != -1)
            {
                Console.WriteLine("Fila seleccionada:" + n);
                DataGridViewCellCollection row = tb_medicamentos.Rows[n].Cells;

                txt_id.Text = Convert.ToString(row[0].Value);
                txt_nombre.Text = Convert.ToString(row[1].Value);
                txt_descripcion.Text = Convert.ToString(row[2].Value);
                txt_cantidad.Text = Convert.ToString(row[3].Value);
                txt_precio.Text = Convert.ToString(row[4].Value);
                txt_fecha.Text = Convert.ToString(row[5].Value);
            }
        }

        private void limpiarCampos()
        {
            //Limpia los text fields y facilitar el uso del programa
            txt_id.Text = "";
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
            txt_cantidad.Text = "";
            txt_precio.Text = "";
            txt_fecha.Text = "";
        }

        private bool controlador_medicamento()
        {
            bool controlador = false; //Se retornara en la funcion para agregar los datos a la tabla correctamente
            try
            {
                bool verificar_numero; //Booleano para comprobar si el tipo de dato que registro el usuario es correcto
                int cantidad = 0; //Almacenara la variable de lo txt_cantidad, pero tenenmos que comprobar el tipo de variable que son
                double precio = 0; //Almacenara las variable de lo txt_precio, pero tenenmos que comprobar el tipo de variable que son

                //Comprueba si la cantidad es un entero
                verificar_numero = int.TryParse(txt_cantidad.Text, out cantidad);

                if (verificar_numero) {

                    //Reutilizamos la misma variable para confirmar si la variable es un número
                    verificar_numero = false;

                    //Comprueba si el precio es un double
                    verificar_numero = double.TryParse(txt_precio.Text, out precio);

                    if (verificar_numero)
                    {
                        if (cantidad >= 0)
                        {
                            if (precio >= 0)
                            {
                                controlador = true; // Como el controlador esta en verdadero, entonces todos los datos que digito el usuario son correctos y podra agregar ese medicamento a la tabla
                            }
                            else
                            {
                                MessageBox.Show("El precio debe ser mayor de 0, vuelva a intentarlo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("La cantida debe ser mayor a 0, vuelva a intentarlo");

                        }
                    }
                    else
                    {
                        MessageBox.Show("El precio que digito no es un numero valido, vuelva a intentarlo");
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad que digito no es un numero valido, vuelva a intentarlo");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error de" +ex);
            }
            
            return controlador;

        }

        private void llenarTabla()
        {
            // Arreglo de string para generar datos de ejemplo con el nombre
            string[] nombre = new string[10];
            nombre[0] = "Paracetamol";
            nombre[1] = "Ibuprofeno";
            nombre[2] = "Amoxicilina";
            nombre[3] = "Omeprazol";
            nombre[4] = "Aspirina";
            nombre[5] = "Diazepam";
            nombre[6] = "Loratadina";
            nombre[7] = "Simvastatina";
            nombre[8] = "Metformina";
            nombre[9] = "Atorvastatina";

            // Arreglo de string para generar datos de ejemplo con descripción
            string[] descripcion = new string[10];
            descripcion[0] = "Medicamento para aliviar el dolor y reducir la fiebre.";
            descripcion[1] = "Antiinflamatorio no esteroideo utilizado para aliviar el dolor y la inflamación.";
            descripcion[2] = "Antibiótico de amplio espectro utilizado para tratar infecciones bacterianas.";
            descripcion[3] = "Inhibidor de la bomba de protones utilizado para reducir la producción de ácido estomacal.";
            descripcion[4] = "Analgésico y antipirético utilizado para aliviar el dolor y reducir la fiebre.";
            descripcion[5] = "Benzodiazepina utilizada como ansiolítico y relajante muscular.";
            descripcion[6] = "Antihistamínico utilizado para aliviar los síntomas de las alergias.";
            descripcion[7] = "Estatina utilizada para reducir los niveles de colesterol en sangre.";
            descripcion[8] = "Medicamento antidiabético utilizado para tratar la diabetes tipo 2.";
            descripcion[9] = "Estatina utilizada para reducir los niveles de colesterol en sangre.";




            //Arreglo de string para generar datos de ejemplo con la fecha
            String[] fecha = new string[10];
            fecha[0] = "10/2/22";
            fecha[1] = "11/5/21";
            fecha[2] = "20/1/23";
            fecha[3] = "11/2/20";
            fecha[4] = "4/5/23";
            fecha[5] = "1/9/20";
            fecha[6] = "11/3/23";
            fecha[7] = "17/10/23";
            fecha[8] = "29/12/21";
            fecha[9] = "10/11/23";


            //Arreglo de string para generar datos de ejemplo con la cantidad de productos
            int[] cantidad = new int[10];
            cantidad[0] = 10;
            cantidad[1] = 20;
            cantidad[2] = 11;
            cantidad[3] = 22;
            cantidad[4] = 42;
            cantidad[5] = 100;
            cantidad[6] = 122;
            cantidad[7] = 54;
            cantidad[8] = 23;
            cantidad[9] = 51;


            //Arreglo de string para generar datos de ejemplo de cada precio unitario
            int[] precio_unitario = new int[10];
            precio_unitario[0] = 100;
            precio_unitario[1] = 20;
            precio_unitario[2] = 12;
            precio_unitario[3] = 22;
            precio_unitario[4] = 65;
            precio_unitario[5] = 10;
            precio_unitario[6] = 20;
            precio_unitario[7] = 54;
            precio_unitario[8] = 40;
            precio_unitario[9] = 50;

            for (int i = 0; i < nombre.Length; i++)
            {
                medi = new Medicamentos();

                medi.Id = "M00"+(i+1);
                medi.Nombre = nombre[i];
                medi.Descripcion = descripcion[i];
                medi.Cantidad = cantidad[i];
                medi.Precio_unitario = precio_unitario[i];
                medi.Fecha_ingreso = fecha[i];

                medicamentos.Add(medi);
            }


            foreach (Medicamentos me in medicamentos)
            {
                int n = tb_medicamentos.Rows.Add();

                tb_medicamentos.Rows[n].Cells[0].Value = me.Id;
                tb_medicamentos.Rows[n].Cells[1].Value = me.Nombre;
                tb_medicamentos.Rows[n].Cells[2].Value = me.Descripcion;
                tb_medicamentos.Rows[n].Cells[3].Value = me.Cantidad;
                tb_medicamentos.Rows[n].Cells[4].Value = me.Precio_unitario;
                tb_medicamentos.Rows[n].Cells[5].Value = me.Fecha_ingreso;
                tb_medicamentos.Rows[n].Cells[6].Value = 0;
            }

        }

    }
}
