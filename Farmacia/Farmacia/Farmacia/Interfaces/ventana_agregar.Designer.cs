namespace Farmacia
{
    partial class ventana_agregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_salir = new System.Windows.Forms.Button();
            this.txt_cantidad_agregar = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.RichTextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_calcular_venta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad_agregar)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(12, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(296, 27);
            this.label9.TabIndex = 31;
            this.label9.Text = "Agregar más medicamentos";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.bt_salir);
            this.panel1.Controls.Add(this.txt_cantidad_agregar);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_fecha);
            this.panel1.Controls.Add(this.txt_precio);
            this.panel1.Controls.Add(this.txt_descripcion);
            this.panel1.Controls.Add(this.txt_cantidad);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bt_calcular_venta);
            this.panel1.Location = new System.Drawing.Point(19, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 339);
            this.panel1.TabIndex = 32;
            // 
            // bt_salir
            // 
            this.bt_salir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.bt_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.bt_salir.Image = global::Farmacia.Properties.Resources.cerrar_sesion;
            this.bt_salir.Location = new System.Drawing.Point(247, 286);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(148, 44);
            this.bt_salir.TabIndex = 51;
            this.bt_salir.Text = "Salir ";
            this.bt_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_salir.UseVisualStyleBackColor = false;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click_1);
            // 
            // txt_cantidad_agregar
            // 
            this.txt_cantidad_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cantidad_agregar.Location = new System.Drawing.Point(170, 248);
            this.txt_cantidad_agregar.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_cantidad_agregar.Name = "txt_cantidad_agregar";
            this.txt_cantidad_agregar.Size = new System.Drawing.Size(225, 20);
            this.txt_cantidad_agregar.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(15, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 20);
            this.label11.TabIndex = 49;
            this.label11.Text = "Cantidad a agregar:";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_fecha.Enabled = false;
            this.txt_fecha.Location = new System.Drawing.Point(143, 208);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(252, 20);
            this.txt_fecha.TabIndex = 37;
            // 
            // txt_precio
            // 
            this.txt_precio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_precio.Enabled = false;
            this.txt_precio.Location = new System.Drawing.Point(143, 131);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(252, 20);
            this.txt_precio.TabIndex = 36;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_descripcion.Enabled = false;
            this.txt_descripcion.Location = new System.Drawing.Point(143, 81);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(252, 36);
            this.txt_descripcion.TabIndex = 35;
            this.txt_descripcion.Text = "";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cantidad.Enabled = false;
            this.txt_cantidad.Location = new System.Drawing.Point(143, 167);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(252, 20);
            this.txt_cantidad.TabIndex = 34;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(143, 46);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(252, 20);
            this.txt_nombre.TabIndex = 33;
            // 
            // txt_id
            // 
            this.txt_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(143, 11);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(252, 20);
            this.txt_id.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(15, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(15, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Precio unitario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(15, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cantidad inicial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(15, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(15, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Id:";
            // 
            // bt_calcular_venta
            // 
            this.bt_calcular_venta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_calcular_venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(172)))), ((int)(((byte)(80)))));
            this.bt_calcular_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calcular_venta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.bt_calcular_venta.Image = global::Farmacia.Properties.Resources.save2;
            this.bt_calcular_venta.Location = new System.Drawing.Point(38, 288);
            this.bt_calcular_venta.Name = "bt_calcular_venta";
            this.bt_calcular_venta.Size = new System.Drawing.Size(148, 41);
            this.bt_calcular_venta.TabIndex = 11;
            this.bt_calcular_venta.Text = "Agregar medicamentos";
            this.bt_calcular_venta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bt_calcular_venta.UseVisualStyleBackColor = false;
            this.bt_calcular_venta.Click += new System.EventHandler(this.bt_calcular_venta_Click);
            // 
            // ventana_agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(462, 403);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Name = "ventana_agregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar medicamentos";
            this.Load += new System.EventHandler(this.ventana_ventas_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad_agregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.NumericUpDown txt_cantidad_agregar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.RichTextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_calcular_venta;
    }
}