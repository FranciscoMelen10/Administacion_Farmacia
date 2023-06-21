using Farmacia.Datos;
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

        //Intancia del objeto de Medicamentos
        Medicamentos medi = new Medicamentos();
        int n = 0;

        public ventana_farmacia()
        {
            InitializeComponent();
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

        private void button3_Click_1(object sender, EventArgs e)
        {
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
                && txt_cantidad.Text == "" && txt_precio.Text == "" && txt_fecha.Text == "")
            {
                MessageBox.Show("Llena los campos vacios");
            } else
            {
                MessageBox.Show("Se guardo con exito el medicamento "+ txt_nombre.Text);

                int n = tb_medicamentos.Rows.Add();

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

        private void limpiarCampos()
        {
            txt_id.Text = "";
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
            txt_cantidad.Text = "";
            txt_precio.Text = "";
            txt_fecha.Text = "";
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {

            if (n != -1)
            {
                tb_medicamentos.Rows.RemoveAt(n);
            }
        }

        private void tb_medicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.RowIndex;

            if(a != -1)
            {
                DataGridViewCellCollection row = tb_medicamentos.Rows[a].Cells;

                txt_id.Text = Convert.ToString(row[0].Value);
                txt_nombre.Text = Convert.ToString(row[1].Value);
                txt_descripcion.Text = Convert.ToString(row[2].Value);
                txt_cantidad.Text = Convert.ToString(row[3].Value);
                txt_precio.Text = Convert.ToString(row[4].Value);
                txt_fecha.Text = Convert.ToString(row[5].Value);
            }
        }
    }
}
