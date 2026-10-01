namespace Actividad2
{
    partial class ContratoDevolucionForm
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            listView1 = new ListView();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            listView2 = new ListView();
            button2 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 254);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sección 1: Entrega de Vehículo (Retiro)";
            // 
            // button1
            // 
            button1.Location = new Point(534, 217);
            button1.Name = "button1";
            button1.Size = new Size(236, 29);
            button1.TabIndex = 0;
            button1.Text = "Firmar Contrato y Entregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(6, 66);
            listView1.Name = "listView1";
            listView1.Size = new Size(764, 156);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(12, 289);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 304);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sección 2: Recepción de Vehículo (Devolución y Pago)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(304, 21);
            label1.TabIndex = 2;
            label1.Text = "Reservas que ya tienen con Auto Asignado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 42);
            label2.Name = "label2";
            label2.Size = new Size(396, 21);
            label2.TabIndex = 0;
            label2.Text = "Vehículos que están actualmente en Estado \"Alquilados\"";
            // 
            // listView2
            // 
            listView2.Location = new Point(6, 55);
            listView2.Name = "listView2";
            listView2.Size = new Size(764, 156);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            button2.Location = new Point(534, 269);
            button2.Name = "button2";
            button2.Size = new Size(236, 29);
            button2.TabIndex = 2;
            button2.Text = "Procesar Pago y Recibir";
            button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(18, 235);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(137, 25);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "¿Tanque Lleno?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(161, 235);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(189, 25);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "¿Sin Daños / Rayones?";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(368, 235);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(157, 25);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "¿Vehículo Limpio?";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // ContratoDevolucionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 605);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ContratoDevolucionForm";
            Text = "AutoRent Express - Contrato Devolucion";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listView2;
        private Label label1;
        private Button button1;
        private ListView listView1;
        private GroupBox groupBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button2;
        private Label label2;
    }
}