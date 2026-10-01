namespace Actividad2
{
    partial class AsignacionFlotaForm
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
            listView1 = new ListView();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 21);
            label1.TabIndex = 0;
            label1.Text = "Lista de Reservas Pendientes";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Location = new Point(12, 33);
            listView1.Name = "listView1";
            listView1.Size = new Size(400, 256);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 311);
            label2.Name = "label2";
            label2.Size = new Size(218, 21);
            label2.TabIndex = 0;
            label2.Text = "Lista de Vehículos Disponibles";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 335);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(208, 29);
            comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(12, 390);
            button1.Name = "button1";
            button1.Size = new Size(197, 29);
            button1.TabIndex = 3;
            button1.Text = "Confirmar Asignación";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(215, 390);
            button2.Name = "button2";
            button2.Size = new Size(197, 29);
            button2.TabIndex = 3;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // AsignacionFlotaForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 437);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AsignacionFlotaForm";
            Text = "AutoRent Express - Asignacion Flota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private Label label2;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}