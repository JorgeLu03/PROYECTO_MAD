namespace PROYECTO_MAD.PANTALLAS
{
    partial class Percepciones_y_deducciones
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_BUSC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_PERC = new System.Windows.Forms.TextBox();
            this.TB_DED = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TB_MOTIV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_ELIM = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(307, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // TB_BUSC
            // 
            this.TB_BUSC.Location = new System.Drawing.Point(134, 323);
            this.TB_BUSC.Name = "TB_BUSC";
            this.TB_BUSC.Size = new System.Drawing.Size(165, 22);
            this.TB_BUSC.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Percepción";
            // 
            // TB_PERC
            // 
            this.TB_PERC.Location = new System.Drawing.Point(368, 341);
            this.TB_PERC.Name = "TB_PERC";
            this.TB_PERC.Size = new System.Drawing.Size(107, 22);
            this.TB_PERC.TabIndex = 5;
            // 
            // TB_DED
            // 
            this.TB_DED.Location = new System.Drawing.Point(508, 341);
            this.TB_DED.Name = "TB_DED";
            this.TB_DED.Size = new System.Drawing.Size(107, 22);
            this.TB_DED.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Deducción";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Añadir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TB_MOTIV
            // 
            this.TB_MOTIV.Location = new System.Drawing.Point(439, 396);
            this.TB_MOTIV.Name = "TB_MOTIV";
            this.TB_MOTIV.Size = new System.Drawing.Size(107, 22);
            this.TB_MOTIV.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Motivo";
            // 
            // BTN_ELIM
            // 
            this.BTN_ELIM.Location = new System.Drawing.Point(520, 424);
            this.BTN_ELIM.Name = "BTN_ELIM";
            this.BTN_ELIM.Size = new System.Drawing.Size(75, 23);
            this.BTN_ELIM.TabIndex = 11;
            this.BTN_ELIM.Text = "Eliminar";
            this.BTN_ELIM.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(406, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(307, 249);
            this.dataGridView2.TabIndex = 12;
            // 
            // Percepciones_y_deducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 541);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BTN_ELIM);
            this.Controls.Add(this.TB_MOTIV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_DED);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TB_PERC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_BUSC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Percepciones_y_deducciones";
            this.Text = "Percepciones_y_deducciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Percepciones_y_deducciones_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_BUSC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_PERC;
        private System.Windows.Forms.TextBox TB_DED;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TB_MOTIV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_ELIM;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}