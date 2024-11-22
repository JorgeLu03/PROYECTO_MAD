namespace PROYECTO_MAD.PANTALLAS
{
    partial class Puestos
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
            this.BTN_EDIT = new System.Windows.Forms.Button();
            this.BTN_ELIM = new System.Windows.Forms.Button();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.TB_SALARIO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_PUESTO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_IDPUES = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_EDIT
            // 
            this.BTN_EDIT.Location = new System.Drawing.Point(375, 292);
            this.BTN_EDIT.Name = "BTN_EDIT";
            this.BTN_EDIT.Size = new System.Drawing.Size(64, 26);
            this.BTN_EDIT.TabIndex = 19;
            this.BTN_EDIT.Text = "Editar";
            this.BTN_EDIT.UseVisualStyleBackColor = true;
            // 
            // BTN_ELIM
            // 
            this.BTN_ELIM.Location = new System.Drawing.Point(375, 334);
            this.BTN_ELIM.Name = "BTN_ELIM";
            this.BTN_ELIM.Size = new System.Drawing.Size(64, 26);
            this.BTN_ELIM.TabIndex = 18;
            this.BTN_ELIM.Text = "Eliminar";
            this.BTN_ELIM.UseVisualStyleBackColor = true;
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.Location = new System.Drawing.Point(375, 250);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(64, 26);
            this.BTN_ADD.TabIndex = 17;
            this.BTN_ADD.Text = "Agregar";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            // 
            // TB_SALARIO
            // 
            this.TB_SALARIO.Location = new System.Drawing.Point(51, 354);
            this.TB_SALARIO.Name = "TB_SALARIO";
            this.TB_SALARIO.Size = new System.Drawing.Size(214, 22);
            this.TB_SALARIO.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nivel salarial";
            // 
            // TB_PUESTO
            // 
            this.TB_PUESTO.Location = new System.Drawing.Point(51, 302);
            this.TB_PUESTO.Name = "TB_PUESTO";
            this.TB_PUESTO.Size = new System.Drawing.Size(214, 22);
            this.TB_PUESTO.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre del Puesto";
            // 
            // TB_IDPUES
            // 
            this.TB_IDPUES.Location = new System.Drawing.Point(51, 250);
            this.TB_IDPUES.Name = "TB_IDPUES";
            this.TB_IDPUES.Size = new System.Drawing.Size(214, 22);
            this.TB_IDPUES.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID Puesto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(431, 166);
            this.dataGridView1.TabIndex = 10;
            // 
            // Puestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.BTN_EDIT);
            this.Controls.Add(this.BTN_ELIM);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.TB_SALARIO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_PUESTO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_IDPUES);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Puestos";
            this.Text = "Puestos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Puestos_FormClosed);
            this.Load += new System.EventHandler(this.Puestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_EDIT;
        private System.Windows.Forms.Button BTN_ELIM;
        private System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.TextBox TB_SALARIO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_PUESTO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_IDPUES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}