namespace PROYECTO_MAD.PANTALLAS
{
    partial class Reporte_Gral_Nómina
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
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_FILTRO = new System.Windows.Forms.Button();
            this.DTP_FECHAREPORTE = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_GENREPORTE = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // BTN_FILTRO
            // 
            this.BTN_FILTRO.Location = new System.Drawing.Point(484, 57);
            this.BTN_FILTRO.Name = "BTN_FILTRO";
            this.BTN_FILTRO.Size = new System.Drawing.Size(78, 31);
            this.BTN_FILTRO.TabIndex = 1;
            this.BTN_FILTRO.Text = "Filtrar";
            this.BTN_FILTRO.UseVisualStyleBackColor = true;
            // 
            // DTP_FECHAREPORTE
            // 
            this.DTP_FECHAREPORTE.Location = new System.Drawing.Point(107, 86);
            this.DTP_FECHAREPORTE.Name = "DTP_FECHAREPORTE";
            this.DTP_FECHAREPORTE.Size = new System.Drawing.Size(200, 22);
            this.DTP_FECHAREPORTE.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(630, 247);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BTN_GENREPORTE
            // 
            this.BTN_GENREPORTE.Location = new System.Drawing.Point(285, 461);
            this.BTN_GENREPORTE.Name = "BTN_GENREPORTE";
            this.BTN_GENREPORTE.Size = new System.Drawing.Size(98, 48);
            this.BTN_GENREPORTE.TabIndex = 4;
            this.BTN_GENREPORTE.Text = "Generar reporte";
            this.BTN_GENREPORTE.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(336, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 5;
            // 
            // Reporte_Gral_Nómina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 544);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BTN_GENREPORTE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DTP_FECHAREPORTE);
            this.Controls.Add(this.BTN_FILTRO);
            this.Controls.Add(this.label1);
            this.Name = "Reporte_Gral_Nómina";
            this.Text = "Reporte_Gral_Nómina";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reporte_Gral_Nómina_FormClosed);
            this.Load += new System.EventHandler(this.Reporte_Gral_Nómina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_FILTRO;
        private System.Windows.Forms.DateTimePicker DTP_FECHAREPORTE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_GENREPORTE;
        private System.Windows.Forms.ListBox listBox1;
    }
}