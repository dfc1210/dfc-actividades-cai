namespace SIGA
{
    partial class OpcionesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRecepcion = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnRecepcion
            // 
            btnRecepcion.Location = new Point(150, 129);
            btnRecepcion.Name = "btnRecepcion";
            btnRecepcion.Size = new Size(263, 52);
            btnRecepcion.TabIndex = 0;
            btnRecepcion.Text = "Recepción de Mercaderias";
            btnRecepcion.UseVisualStyleBackColor = true;
            btnRecepcion.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(552, 35);
            label1.TabIndex = 1;
            label1.Text = "SIGA - Sistema Integral de Gestón de Almacenes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(262, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 29);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 86);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 4;
            label2.Text = "Depósito";
            // 
            // button1
            // 
            button1.Location = new Point(150, 187);
            button1.Name = "button1";
            button1.Size = new Size(263, 52);
            button1.TabIndex = 5;
            button1.Text = "Preparacion de Ordenes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // OpcionesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(btnRecepcion);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OpcionesForm";
            Text = "SIGA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRecepcion;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Button button1;
    }
}
