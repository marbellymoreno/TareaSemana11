namespace TareaSemana11_EliminarClienteDapper
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPostres = new System.Windows.Forms.DataGridView();
            this.btnEliminarPostre = new System.Windows.Forms.Button();
            this.tboxPrecio = new System.Windows.Forms.TextBox();
            this.tboxDescripcion = new System.Windows.Forms.TextBox();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.tboxDessertID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxObtenerID = new System.Windows.Forms.TextBox();
            this.btnObtenerId = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObtenerTodos = new System.Windows.Forms.Button();
            this.textBoxCalorias = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimeFV = new System.Windows.Forms.DateTimePicker();
            this.radioButtonEstado = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostres)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPostres
            // 
            this.dgvPostres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostres.Location = new System.Drawing.Point(22, 22);
            this.dgvPostres.Name = "dgvPostres";
            this.dgvPostres.RowHeadersWidth = 82;
            this.dgvPostres.Size = new System.Drawing.Size(740, 681);
            this.dgvPostres.TabIndex = 0;
            // 
            // btnEliminarPostre
            // 
            this.btnEliminarPostre.Location = new System.Drawing.Point(1144, 509);
            this.btnEliminarPostre.Name = "btnEliminarPostre";
            this.btnEliminarPostre.Size = new System.Drawing.Size(310, 55);
            this.btnEliminarPostre.TabIndex = 34;
            this.btnEliminarPostre.Text = "Eliminar Postre";
            this.btnEliminarPostre.UseVisualStyleBackColor = true;
            this.btnEliminarPostre.Click += new System.EventHandler(this.btnEliminarPostre_Click);
            // 
            // tboxPrecio
            // 
            this.tboxPrecio.Location = new System.Drawing.Point(1018, 247);
            this.tboxPrecio.Name = "tboxPrecio";
            this.tboxPrecio.Size = new System.Drawing.Size(436, 31);
            this.tboxPrecio.TabIndex = 30;
            // 
            // tboxDescripcion
            // 
            this.tboxDescripcion.Location = new System.Drawing.Point(1018, 193);
            this.tboxDescripcion.Name = "tboxDescripcion";
            this.tboxDescripcion.Size = new System.Drawing.Size(436, 31);
            this.tboxDescripcion.TabIndex = 29;
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(1018, 137);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(436, 31);
            this.tboxNombre.TabIndex = 28;
            // 
            // tboxDessertID
            // 
            this.tboxDessertID.Location = new System.Drawing.Point(1018, 87);
            this.tboxDessertID.Name = "tboxDessertID";
            this.tboxDessertID.Size = new System.Drawing.Size(436, 31);
            this.tboxDessertID.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(805, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(805, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(805, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(805, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha Vencimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(805, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "DessertsID";
            // 
            // tboxObtenerID
            // 
            this.tboxObtenerID.Location = new System.Drawing.Point(1018, 601);
            this.tboxObtenerID.Name = "tboxObtenerID";
            this.tboxObtenerID.Size = new System.Drawing.Size(436, 31);
            this.tboxObtenerID.TabIndex = 21;
            // 
            // btnObtenerId
            // 
            this.btnObtenerId.Location = new System.Drawing.Point(810, 648);
            this.btnObtenerId.Name = "btnObtenerId";
            this.btnObtenerId.Size = new System.Drawing.Size(644, 55);
            this.btnObtenerId.TabIndex = 20;
            this.btnObtenerId.Text = "Buscar";
            this.btnObtenerId.UseVisualStyleBackColor = true;
            this.btnObtenerId.Click += new System.EventHandler(this.btnObtenerId_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(805, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "DessertsID";
            // 
            // btnObtenerTodos
            // 
            this.btnObtenerTodos.Location = new System.Drawing.Point(810, 509);
            this.btnObtenerTodos.Name = "btnObtenerTodos";
            this.btnObtenerTodos.Size = new System.Drawing.Size(310, 55);
            this.btnObtenerTodos.TabIndex = 18;
            this.btnObtenerTodos.Text = "Obtener Postres";
            this.btnObtenerTodos.UseVisualStyleBackColor = true;
            this.btnObtenerTodos.Click += new System.EventHandler(this.btnObtenerTodos_Click);
            // 
            // textBoxCalorias
            // 
            this.textBoxCalorias.Location = new System.Drawing.Point(1018, 456);
            this.textBoxCalorias.Name = "textBoxCalorias";
            this.textBoxCalorias.Size = new System.Drawing.Size(436, 31);
            this.textBoxCalorias.TabIndex = 40;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(1018, 403);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(436, 31);
            this.textBoxStock.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(805, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(805, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Stock";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(805, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "Calorias";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1056, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 25);
            this.label10.TabIndex = 41;
            this.label10.Text = "MICHELLES BAKERY";
            // 
            // dateTimeFV
            // 
            this.dateTimeFV.Location = new System.Drawing.Point(1018, 303);
            this.dateTimeFV.Name = "dateTimeFV";
            this.dateTimeFV.Size = new System.Drawing.Size(436, 31);
            this.dateTimeFV.TabIndex = 42;
            // 
            // radioButtonEstado
            // 
            this.radioButtonEstado.AutoSize = true;
            this.radioButtonEstado.Location = new System.Drawing.Point(1018, 352);
            this.radioButtonEstado.Name = "radioButtonEstado";
            this.radioButtonEstado.Size = new System.Drawing.Size(102, 29);
            this.radioButtonEstado.TabIndex = 43;
            this.radioButtonEstado.TabStop = true;
            this.radioButtonEstado.Text = "Activo";
            this.radioButtonEstado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 737);
            this.Controls.Add(this.radioButtonEstado);
            this.Controls.Add(this.dateTimeFV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxCalorias);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEliminarPostre);
            this.Controls.Add(this.tboxPrecio);
            this.Controls.Add(this.tboxDescripcion);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.tboxDessertID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxObtenerID);
            this.Controls.Add(this.btnObtenerId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObtenerTodos);
            this.Controls.Add(this.dgvPostres);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPostres;
        private System.Windows.Forms.Button btnEliminarPostre;
        private System.Windows.Forms.TextBox tboxPrecio;
        private System.Windows.Forms.TextBox tboxDescripcion;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.TextBox tboxDessertID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxObtenerID;
        private System.Windows.Forms.Button btnObtenerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObtenerTodos;
        private System.Windows.Forms.TextBox textBoxCalorias;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimeFV;
        private System.Windows.Forms.RadioButton radioButtonEstado;
    }
}

