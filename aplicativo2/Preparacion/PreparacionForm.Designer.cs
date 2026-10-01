namespace SIGA.Preparacion
{
    partial class PreparacionForm
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            dataGridViewProductos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            label9 = new Label();
            dataGridViewPreparacion = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPreparacion).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 29);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(207, 5);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 9);
            label2.Name = "label2";
            label2.Size = new Size(188, 21);
            label2.TabIndex = 4;
            label2.Text = "<razon social del cliente>";
            // 
            // button2
            // 
            button2.Location = new Point(853, 5);
            button2.Name = "button2";
            button2.Size = new Size(164, 29);
            button2.TabIndex = 5;
            button2.Text = "Limpiar Filtros";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 64);
            label3.Name = "label3";
            label3.Size = new Size(241, 21);
            label3.TabIndex = 6;
            label3.Text = "Productos en Deposito del cliente";
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AllowUserToAddRows = false;
            dataGridViewProductos.AllowUserToDeleteRows = false;
            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Column1, dataGridViewTextBoxColumn3 });
            dataGridViewProductos.Location = new Point(12, 88);
            dataGridViewProductos.MultiSelect = false;
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersVisible = false;
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProductos.Size = new Size(728, 319);
            dataGridViewProductos.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "SKU";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column1
            // 
            Column1.HeaderText = "Cantidad en Stock";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Cantidad Disponible";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(746, 88);
            label4.Name = "label4";
            label4.Size = new Size(168, 21);
            label4.TabIndex = 10;
            label4.Text = "Producto Seleccionado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(746, 120);
            label5.Name = "label5";
            label5.Size = new Size(271, 21);
            label5.TabIndex = 11;
            label5.Text = "<descripcion producto seleccionado>";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(746, 157);
            label6.Name = "label6";
            label6.Size = new Size(150, 21);
            label6.TabIndex = 12;
            label6.Text = "Cantidad Disponible";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(746, 194);
            label7.Name = "label7";
            label7.Size = new Size(50, 21);
            label7.TabIndex = 13;
            label7.Text = "<nn>";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(746, 232);
            label8.Name = "label8";
            label8.Size = new Size(150, 21);
            label8.TabIndex = 14;
            label8.Text = "Cantidad A Preparar";
            label8.Click += label8_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(913, 229);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(108, 29);
            textBox2.TabIndex = 15;
            // 
            // button3
            // 
            button3.Location = new Point(746, 264);
            button3.Name = "button3";
            button3.Size = new Size(275, 37);
            button3.TabIndex = 16;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 410);
            label9.Name = "label9";
            label9.Size = new Size(302, 21);
            label9.TabIndex = 18;
            label9.Text = "Productos seleccionados para preparacion";
            // 
            // dataGridViewPreparacion
            // 
            dataGridViewPreparacion.AllowUserToAddRows = false;
            dataGridViewPreparacion.AllowUserToDeleteRows = false;
            dataGridViewPreparacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPreparacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPreparacion.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewButtonColumn1 });
            dataGridViewPreparacion.Location = new Point(12, 434);
            dataGridViewPreparacion.MultiSelect = false;
            dataGridViewPreparacion.Name = "dataGridViewPreparacion";
            dataGridViewPreparacion.RowHeadersVisible = false;
            dataGridViewPreparacion.RowHeadersWidth = 51;
            dataGridViewPreparacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPreparacion.Size = new Size(1009, 160);
            dataGridViewPreparacion.TabIndex = 19;
            dataGridViewPreparacion.CellContentClick += dataGridViewPreparacion_CellContentClick;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "SKU";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Descripción";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Cantidad";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Espacio Necesario";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.HeaderText = "ELIMINAR";
            dataGridViewButtonColumn1.MinimumWidth = 6;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.Text = "ELIMINAR";
            dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // button4
            // 
            button4.Location = new Point(769, 600);
            button4.Name = "button4";
            button4.Size = new Size(252, 42);
            button4.TabIndex = 20;
            button4.Text = "Confirmar Orden de Preparacion";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(511, 600);
            button5.Name = "button5";
            button5.Size = new Size(252, 42);
            button5.TabIndex = 21;
            button5.Text = "Cancelar";
            button5.UseVisualStyleBackColor = true;
            // 
            // PreparacionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 650);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(dataGridViewPreparacion);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dataGridViewProductos);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "PreparacionForm";
            Text = "Preparacion de Ordenes";
            Load += PreparacionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPreparacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Button button2;
        private Label label3;
        private DataGridView dataGridViewProductos;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private TextBox textBox2;
        private Button button3;
        private Label label9;
        private DataGridView dataGridViewPreparacion;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private Button button4;
        private Button button5;
    }
}