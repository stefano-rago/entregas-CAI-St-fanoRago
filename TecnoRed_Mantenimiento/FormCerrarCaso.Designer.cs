namespace TecnoRed_Mantenimiento
{
    partial class FormCerrarCaso
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
            dataGridView1 = new DataGridView();
            IDCaso = new DataGridViewTextBoxColumn();
            Empleado = new DataGridViewTextBoxColumn();
            Problema = new DataGridViewTextBoxColumn();
            TécnicoAsignado = new DataGridViewTextBoxColumn();
            TrabajoRealizado = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDCaso, Empleado, Problema, TécnicoAsignado, TrabajoRealizado, Estado });
            dataGridView1.Location = new Point(75, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(643, 64);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IDCaso
            // 
            IDCaso.HeaderText = "IDCaso";
            IDCaso.Name = "IDCaso";
            // 
            // Empleado
            // 
            Empleado.HeaderText = "Empleado";
            Empleado.Name = "Empleado";
            // 
            // Problema
            // 
            Problema.HeaderText = "Problema";
            Problema.Name = "Problema";
            // 
            // TécnicoAsignado
            // 
            TécnicoAsignado.HeaderText = "TécnicoAsignado";
            TécnicoAsignado.Name = "TécnicoAsignado";
            // 
            // TrabajoRealizado
            // 
            TrabajoRealizado.HeaderText = "Trabajo Realizado";
            TrabajoRealizado.Name = "TrabajoRealizado";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // button1
            // 
            button1.Location = new Point(75, 369);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Cerrar caso";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 190);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(643, 127);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(191, 369);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 32);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 4;
            label1.Text = "Casos reparados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 160);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 5;
            label2.Text = "Observaciones finales ";
            // 
            // FormCerrarCaso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "FormCerrarCaso";
            Text = "Form Coordinador Cierre Del Caso";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IDCaso;
        private DataGridViewTextBoxColumn Empleado;
        private DataGridViewTextBoxColumn Problema;
        private DataGridViewTextBoxColumn TécnicoAsignado;
        private DataGridViewTextBoxColumn TrabajoRealizado;
        private DataGridViewTextBoxColumn Estado;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}