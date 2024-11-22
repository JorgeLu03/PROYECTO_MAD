namespace PROYECTO_MAD.PANTALLAS
{
    partial class Reporte_nómina
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
            this.BTN_GENREPORTE = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DTP_FECHAREPORTE = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_FILTRO = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_GENREPORTE
            // 
            this.BTN_GENREPORTE.Location = new System.Drawing.Point(322, 457);
            this.BTN_GENREPORTE.Name = "BTN_GENREPORTE";
            this.BTN_GENREPORTE.Size = new System.Drawing.Size(98, 48);
            this.BTN_GENREPORTE.TabIndex = 8;
            this.BTN_GENREPORTE.Text = "Generar reporte";
            this.BTN_GENREPORTE.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(85, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(630, 247);
            this.dataGridView1.TabIndex = 7;
            // 
            // DTP_FECHAREPORTE
            // 
            this.DTP_FECHAREPORTE.Location = new System.Drawing.Point(85, 70);
            this.DTP_FECHAREPORTE.Name = "DTP_FECHAREPORTE";
            this.DTP_FECHAREPORTE.Size = new System.Drawing.Size(200, 22);
            this.DTP_FECHAREPORTE.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha";
            // 
            // BTN_FILTRO
            // 
            this.BTN_FILTRO.Location = new System.Drawing.Point(331, 50);
            this.BTN_FILTRO.Name = "BTN_FILTRO";
            this.BTN_FILTRO.Size = new System.Drawing.Size(78, 31);
            this.BTN_FILTRO.TabIndex = 9;
            this.BTN_FILTRO.Text = "Filtrar";
            this.BTN_FILTRO.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sueldo bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sueldo neto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 409);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 22);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(491, 409);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 22);
            this.textBox2.TabIndex = 13;
            // 
            // Reporte_nómina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 542);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_FILTRO);
            this.Controls.Add(this.BTN_GENREPORTE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DTP_FECHAREPORTE);
            this.Controls.Add(this.label1);
            this.Name = "Reporte_nómina";
            this.Text = "Reporte_nómina";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reporte_nómina_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_GENREPORTE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker DTP_FECHAREPORTE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_FILTRO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}