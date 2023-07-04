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
            try
            {

                if (txt_id.Text == "" || txt_nombre.Text == "" || txt_descripcion.Text == ""
                    || txt_cantidad.Text == "" || txt_precio.Text == "" || txt_fecha.Text == "") //Comprueba que ningun campo este vacio
                {
                    MessageBox.Show("Seleccione el registro que quiere realizar una venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (controlador_medicamento())
                    {
                        ventana_ventas formulario_ventas = new ventana_ventas(txt_id.Text, txt_nombre.Text,
                        txt_descripcion.Text, double.Parse(txt_precio.Text), int.Parse(txt_cantidad.Text), txt_fecha.Text); //Pasar por parametro los datos seleccionados para poder hacer la venta 

                        formulario_ventas.ShowDialog();

                        string[] lista;

                        lista = formulario_ventas.pedirDatos(); //Retorna el id, la cantidad que se vendio y la venta final 


                        if (int.Parse(lista[1]) != 0)
                        {
                            MessageBox.Show("Se ha vendido el total de " + lista[2] + "C$ del medicamento " + (txt_nombre.Text), "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information); //Mensaje en pantalla

                            foreach (Medicamentos me in medicamentos)
                            {
                                if (me.Id == lista[0])
                                {
                                    me.Cantidad -= int.Parse(lista[1]);
                                    me.Precio_total += double.Parse(lista[2]);
                                }
                            }

                            tabla_ventas();
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try
            {

                if (txt_id.Text == "" || txt_nombre.Text == "" || txt_descripcion.Text == ""
                    || txt_cantidad.Text == "" || txt_precio.Text == "" || txt_fecha.Text == "") //Comprueba que ningun campo este vacio
                {
                    MessageBox.Show("Seleccione el medicamento para agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (controlador_medicamento())
                    {
                        ventana_agregar formulario_agregar = new ventana_agregar(txt_id.Text, txt_nombre.Text,
                        txt_descripcion.Text, double.Parse(txt_precio.Text), int.Parse(txt_cantidad.Text), txt_fecha.Text); //Pasar por parametro los datos seleccionados para poder hacer la venta 

                        formulario_agregar.ShowDialog();

                        string[] lista;

                        lista = formulario_agregar.pedirDatos(); //Retorna el id y la cantidad que se agrego

                        if (int.Parse(lista[1]) != 0)
                        {
                            MessageBox.Show("Se han guardado la cantidad de " + lista[1] + " medicamentos de " + (txt_nombre.Text), "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information); //Mensaje en pantalla


                            foreach (Medicamentos me in medicamentos)
                            {
                                if (me.Id == lista[0])
                                {
                                    me.Cantidad += int.Parse(lista[1]);
                                }
                            }

                            tabla_ventas();
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void tabla_ventas() //Imprime los nuevos datos cuando se realiza una nueva venta
        {
            int n = 0;//Controlador de filas
            limpiarCampos();

            foreach (Medicamentos me in medicamentos)
            {
                tb_medicamentos.Rows[n].Cells[0].Value = me.Id;
                tb_medicamentos.Rows[n].Cells[1].Value = me.Nombre;
                tb_medicamentos.Rows[n].Cells[2].Value = me.Descripcion;
                tb_medicamentos.Rows[n].Cells[3].Value = me.Cantidad;
                tb_medicamentos.Rows[n].Cells[4].Value = me.Precio_unitario;
                tb_medicamentos.Rows[n].Cells[5].Value = me.Fecha_ingreso;
                tb_medicamentos.Rows[n].Cells[6].Value = me.Precio_total;
                n++;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e) //Agregar un medicamento
        {

            if (txt_id.Text == "" || txt_nombre.Text == "" || txt_descripcion.Text == ""
                || txt_cantidad.Text == "" || txt_precio.Text == "" || txt_fecha.Text == "") //Comprueba que ningun campo este vacio
            {
                MessageBox.Show("Llena los campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (controlador_medicamento()) //Este if sirve para comprobar si el usuario digito bien los datos a los text fields correspondientes
                {

                    if (existeMedicamento())
                    {
                        MessageBox.Show("Se guardo con exito el medicamento " + (txt_nombre.Text), "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information); //Mensaje en pantalla

                        int n = tb_medicamentos.Rows.Add(); //Fila que selecciono el usuario en la tabla de medicamentos

                        tb_medicamentos.Rows[n].Cells[0].Value = txt_id.Text;
                        tb_medicamentos.Rows[n].Cells[1].Value = txt_nombre.Text;
                        tb_medicamentos.Rows[n].Cells[2].Value = txt_descripcion.Text;
                        tb_medicamentos.Rows[n].Cells[3].Value = txt_cantidad.Text;
                        tb_medicamentos.Rows[n].Cells[4].Value = txt_precio.Text;
                        tb_medicamentos.Rows[n].Cells[5].Value = txt_fecha.Text;
                        tb_medicamentos.Rows[n].Cells[6].Value = 0;

                        medi = new Medicamentos();

                        medi.Id = txt_id.Text;
                        medi.Nombre = txt_nombre.Text;
                        medi.Descripcion = txt_descripcion.Text;
                        medi.Cantidad = int.Parse(txt_cantidad.Text);
                        medi.Precio_unitario = double.Parse(txt_precio.Text);
                        medi.Fecha_ingreso = txt_fecha.Text;
                        medi.Precio_total = 0;

                        medicamentos.Add(medi);

                        foreach (Medicamentos me in medicamentos)
                        {
                            Console.WriteLine(me.Nombre);

                        }
                        limpiarCampos();

                    }
                    else
                    {
                        MessageBox.Show("El registro que digito existe, digite otro nombre y ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }

            }

        }


        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id.Text == "" || txt_nombre.Text == "" || txt_descripcion.Text == ""
              || txt_cantidad.Text == "" || txt_precio.Text == "" || txt_fecha.Text == "") //Comprueba que ningun campo este vacio
                {
                    MessageBox.Show("Llena los campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (n != -1)
                    {
                        MessageBox.Show("Se elimino el medicamento: " + txt_nombre.Text, "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        int posicion = 0; // Buscara la posicion donde se encuentre el registro repetido
                        foreach (Medicamentos me in medicamentos)
                        {
                            if (txt_id.Text == me.Id)
                            {
                                MessageBox.Show("Numero del registro: " + posicion);
                                break;
                            }
                            posicion++;
                        }

                        medicamentos.RemoveAt(posicion);

                        tb_medicamentos.Rows.RemoveAt(n); //En la fila seleccionada por el usuario, la elimina completamente
                        n = 0; //Se asigna en 0 para que el usuario pueda elegir nuevamente otro registro de la tabla
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar un registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                if (verificar_numero)
                {

                    //Reutilizamos la misma variable para confirmar si la variable es un número
                    verificar_numero = false;

                    //Comprueba si el precio es un double
                    verificar_numero = double.TryParse(txt_precio.Text, out precio);

                    if (verificar_numero)
                    {
                        if (cantidad >= 0)
                        {
                            if (precio > 0)
                            {
                                controlador = true; // Como el controlador esta en verdadero, entonces todos los datos que digito el usuario son correctos y podra agregar ese medicamento a la tabla
                            }
                            else
                            {
                                MessageBox.Show("El precio debe ser mayor de 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("La cantida debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("El precio que digito no es un numero valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad que digito no es un numero valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error de" + ex);
            }

            return controlador;

        }

        private void llenarTabla()
        {
            // Arreglo de string para generar datos de ejemplo con el nombre
            string[] nombre = new string[15];
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
            nombre[10] = "Bupropion";
            nombre[11] = "Levotiroxina";
            nombre[12] = "Atenolol";
            nombre[13] = "Pregabalina";
            nombre[14] = "Furosemida";



            // Arreglo de string para generar datos de ejemplo con descripción
            string[] descripcion = new string[15];
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
            descripcion[10] = "Antidepresivo utilizado para tratar la depresión y como ayuda para dejar de fumar.";
            descripcion[11] = "Hormona tiroidea utilizada para reemplazar o suplementar la hormona tiroidea en pacientes con hipotiroidismo.";
            descripcion[12] = "Bloqueador beta utilizado para tratar la hipertensión arterial, la angina de pecho y los trastornos del ritmo cardíaco.";
            descripcion[13] = "Antiepiléptico y analgésico utilizado para tratar la epilepsia, el dolor neuropático y el trastorno de ansiedad generalizada.";
            descripcion[14] = "Diurético de asa utilizado para tratar la retención de líquidos y la hipertensión arterial.";




            //Arreglo de string para generar datos de ejemplo con la fecha
            String[] fecha = new string[15];
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
            fecha[10] = "1/9/20";
            fecha[11] = "11/3/23";
            fecha[12] = "17/10/23";
            fecha[13] = "29/12/21";
            fecha[14] = "10/11/23";


            //Arreglo de string para generar datos de ejemplo con la cantidad de productos
            int[] cantidad = new int[15];
            cantidad[0] = 10;
            cantidad[1] = 20;
            cantidad[2] = 11;
            cantidad[3] = 22;
            cantidad[4] = 47;
            cantidad[5] = 10;
            cantidad[6] = 122;
            cantidad[7] = 54;
            cantidad[8] = 23;
            cantidad[9] = 51;
            cantidad[10] = 12;
            cantidad[11] = 24;
            cantidad[12] = 3;
            cantidad[13] = 11;
            cantidad[14] = 6;



            //Arreglo de string para generar datos de ejemplo de cada precio unitario
            int[] precio_unitario = new int[15];
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
            precio_unitario[10] = 105;
            precio_unitario[11] = 25;
            precio_unitario[12] = 78;
            precio_unitario[13] = 13;
            precio_unitario[14] = 64;

            for (int i = 0; i < nombre.Length; i++)
            {
                medi = new Medicamentos();

                medi.Id = "M00" + (i + 1);
                medi.Nombre = nombre[i];
                medi.Descripcion = descripcion[i];
                medi.Cantidad = cantidad[i];
                medi.Precio_unitario = precio_unitario[i];
                medi.Fecha_ingreso = fecha[i];
                medi.Precio_total = 0;

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

        private bool existeMedicamento()
        {
            bool existe = true; // Buscara entre los registros guardados si hay un registro repetido
            foreach (Medicamentos me in medicamentos)
            {
                if (txt_id.Text == me.Id || txt_nombre.Text == me.Nombre)
                {
                    existe = false;
                    break;
                }
            }

            return existe;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_medicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                n = e.RowIndex; //Asignarle el valor de la posicion en donde el usuario selecciono

                if (n != -1)
                {
                    Console.WriteLine("Fila seleccionada:" + n);


                    // Asignar los valores de la fila a los TextBoxes
                    txt_id.Text = Convert.ToString(tb_medicamentos.Rows[n].Cells[0].Value);
                    txt_nombre.Text = Convert.ToString(tb_medicamentos.Rows[n].Cells[1].Value);
                    txt_descripcion.Text = Convert.ToString(tb_medicamentos.Rows[n].Cells[2].Value);
                    txt_cantidad.Text = Convert.ToString(tb_medicamentos.Rows[n].Cells[3].Value);
                    txt_precio.Text = Convert.ToString(tb_medicamentos.Rows[n].Cells[4].Value);
                    txt_fecha.Text = Convert.ToString(tb_medicamentos.Rows[n].Cells[5].Value);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en cllick de la tabla " + ex);
            }

        }
    }
}
