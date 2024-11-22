namespace PROYECTO_MAD.PANTALLAS
{
    partial class Reporte_Puesto_y_dpt
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
            this.BTN_REPPUES = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DTP_FECHAREPORTE = new System.Windows.Forms.DateTimePicker();
            this.BTN_FILTRO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BTN_REPDEP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_REPPUES
            // 
            this.BTN_REPPUES.Location = new System.Drawing.Point(108, 375);
            this.BTN_REPPUES.Name = "BTN_REPPUES";
            this.BTN_REPPUES.Size = new System.Drawing.Size(129, 48);
            this.BTN_REPPUES.TabIndex = 9;
            this.BTN_REPPUES.Text = "Generar reporte puesto";
            this.BTN_REPPUES.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(339, 241);
            this.dataGridView1.TabIndex = 8;
            // 
            // DTP_FECHAREPORTE
            // 
            this.DTP_FECHAREPORTE.Location = new System.Drawing.Point(296, 79);
            this.DTP_FECHAREPORTE.Name = "DTP_FECHAREPORTE";
            this.DTP_FECHAREPORTE.Size = new System.Drawing.Size(200, 22);
            this.DTP_FECHAREPORTE.TabIndex = 7;
            // 
            // BTN_FILTRO
            // 
            this.BTN_FILTRO.Location = new System.Drawing.Point(357, 26);
            this.BTN_FILTRO.Name = "BTN_FILTRO";
            this.BTN_FILTRO.Size = new System.Drawing.Size(78, 31);
            this.BTN_FILTRO.TabIndex = 6;
            this.BTN_FILTRO.Text = "Filtrar";
            this.BTN_FILTRO.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(449, 118);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(339, 241);
            this.dataGridView2.TabIndex = 10;
            // 
            // BTN_REPDEP
            // 
            this.BTN_REPDEP.Location = new System.Drawing.Point(567, 375);
            this.BTN_REPDEP.Name = "BTN_REPDEP";
            this.BTN_REPDEP.Size = new System.Drawing.Size(116, 48);
            this.BTN_REPDEP.TabIndex = 11;
            this.BTN_REPDEP.Text = "Generar reporte departamento";
            this.BTN_REPDEP.UseVisualStyleBackColor = true;
            // 
            // Reporte_Puesto_y_dpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_REPDEP);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BTN_REPPUES);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DTP_FECHAREPORTE);
            this.Controls.Add(this.BTN_FILTRO);
            this.Controls.Add(this.label1);
            this.Name = "Reporte_Puesto_y_dpt";
            this.Text = "Reporte_Puesto_y_dpt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reporte_Puesto_y_dpt_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_REPPUES;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker DTP_FECHAREPORTE;
        private System.Windows.Forms.Button BTN_FILTRO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BTN_REPDEP;
    }
}