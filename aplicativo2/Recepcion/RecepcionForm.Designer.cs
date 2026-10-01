namespace SIGA.Recepcion
{
    partial class RecepcionForm
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
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            dataGridViewProductos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            buttonCancelar = new Button();
            txtCantidad = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            button3 = new Button();
            label7 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            label8 = new Label();
            button6 = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
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
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(207, 6);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 3;
            label2.Text = "Remito";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(76, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 29);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(39, 21);
            label3.TabIndex = 5;
            label3.Text = "SKU";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(76, 121);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 29);
            textBox3.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(658, 162);
            button2.Name = "button2";
            button2.Size = new Size(130, 42);
            button2.TabIndex = 7;
            button2.Text = "Agregar SKU";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AllowUserToAddRows = false;
            dataGridViewProductos.AllowUserToDeleteRows = false;
            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewButtonColumn1 });
            dataGridViewProductos.Location = new Point(12, 215);
            dataGridViewProductos.MultiSelect = false;
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersVisible = false;
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProductos.Size = new Size(776, 316);
            dataGridViewProductos.TabIndex = 8;
            dataGridViewProductos.CellContentClick += dataGridViewProductos_CellContentClick;
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
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Espacio Necesario";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.HeaderText = "";
            dataGridViewButtonColumn1.MinimumWidth = 6;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.Text = "Eliminar";
            dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // buttonCancelar
            // 
            buttonCancelar.DialogResult = DialogResult.Cancel;
            buttonCancelar.Location = new Point(417, 545);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(104, 42);
            buttonCancelar.TabIndex = 10;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(209, 170);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 29);
            txtCantidad.TabIndex = 13;
            txtCantidad.Text = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 173);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 12;
            label4.Text = "Cantidad Remito";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(462, 170);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 29);
            textBox4.TabIndex = 15;
            textBox4.Text = "1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(350, 173);
            label5.Name = "label5";
            label5.Size = new Size(106, 21);
            label5.TabIndex = 14;
            label5.Text = "Cantidad Real";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(320, 125);
            label6.Name = "label6";
            label6.Size = new Size(167, 21);
            label6.TabIndex = 16;
            label6.Text = "<Descripcion de SKU>";
            // 
            // button3
            // 
            button3.Location = new Point(207, 121);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 17;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(561, 10);
            label7.Name = "label7";
            label7.Size = new Size(227, 21);
            label7.TabIndex = 18;
            label7.Text = "Espacio disponible <nnnn m3>";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(209, 52);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 29);
            textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(340, 52);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 29);
            textBox6.TabIndex = 20;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(471, 52);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 29);
            textBox7.TabIndex = 21;
            // 
            // button4
            // 
            button4.DialogResult = DialogResult.Cancel;
            button4.Enabled = false;
            button4.Location = new Point(232, 546);
            button4.Name = "button4";
            button4.Size = new Size(168, 42);
            button4.TabIndex = 23;
            button4.Text = "Nota de Diferencia";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.DialogResult = DialogResult.OK;
            button5.Enabled = false;
            button5.Location = new Point(12, 545);
            button5.Name = "button5";
            button5.Size = new Size(214, 42);
            button5.TabIndex = 22;
            button5.Text = "Nota por Falta de Espacio";
            button5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(417, 10);
            label8.Name = "label8";
            label8.Size = new Size(118, 21);
            label8.TabIndex = 24;
            label8.Text = "<Razon social>";
            // 
            // button6
            // 
            button6.DialogResult = DialogResult.Cancel;
            button6.Location = new Point(527, 546);
            button6.Name = "button6";
            button6.Size = new Size(261, 42);
            button6.TabIndex = 10;
            button6.Text = "Confirmar Orden de Recepcion";
            button6.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(566, 10);
            label9.Name = "label9";
            label9.Size = new Size(118, 21);
            label9.TabIndex = 24;
            label9.Text = "<Razon social>";
            // 
            // RecepcionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(800, 606);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(txtCantidad);
            Controls.Add(label4);
            Controls.Add(button6);
            Controls.Add(buttonCancelar);
            Controls.Add(dataGridViewProductos);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "RecepcionForm";
            Text = "Recepción de Mercaderias <Deposito XXX>";
            Load += RecepcionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button button2;
        private Button buttonGenerarAleatorios;
        private DataGridView dataGridViewProductos;
        private Button buttonCancelar;
        private TextBox txtCantidad;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private Button button3;
        private Label label7;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private Button button4;
        private Button button5;
        private Label label8;
        private Button button6;
        private Label label9;
    }
}