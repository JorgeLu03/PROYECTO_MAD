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
            this.DG_3 = new System.Windows.Forms.DataGridView();
            this.CB_NOMPUES = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_3)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_EDIT
            // 
            this.BTN_EDIT.Location = new System.Drawing.Point(375, 319);
            this.BTN_EDIT.Name = "BTN_EDIT";
            this.BTN_EDIT.Size = new System.Drawing.Size(64, 26);
            this.BTN_EDIT.TabIndex = 19;
            this.BTN_EDIT.Text = "Editar";
            this.BTN_EDIT.UseVisualStyleBackColor = true;
            this.BTN_EDIT.Click += new System.EventHandler(this.BTN_EDIT_Click);
            // 
            // BTN_ELIM
            // 
            this.BTN_ELIM.Location = new System.Drawing.Point(375, 361);
            this.BTN_ELIM.Name = "BTN_ELIM";
            this.BTN_ELIM.Size = new System.Drawing.Size(64, 26);
            this.BTN_ELIM.TabIndex = 18;
            this.BTN_ELIM.Text = "Eliminar";
            this.BTN_ELIM.UseVisualStyleBackColor = true;
            this.BTN_ELIM.Click += new System.EventHandler(this.BTN_ELIM_Click);
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.Location = new System.Drawing.Point(375, 277);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(64, 26);
            this.BTN_ADD.TabIndex = 17;
            this.BTN_ADD.Text = "Agregar";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // TB_SALARIO
            // 
            this.TB_SALARIO.Location = new System.Drawing.Point(41, 368);
            this.TB_SALARIO.Name = "TB_SALARIO";
            this.TB_SALARIO.Size = new System.Drawing.Size(214, 22);
            this.TB_SALARIO.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nivel salarial";
            // 
            // TB_PUESTO
            // 
            this.TB_PUESTO.Location = new System.Drawing.Point(41, 316);
            this.TB_PUESTO.Name = "TB_PUESTO";
            this.TB_PUESTO.Size = new System.Drawing.Size(214, 22);
            this.TB_PUESTO.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre del Puesto";
            // 
            // DG_3
            // 
            this.DG_3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_3.Location = new System.Drawing.Point(41, 25);
            this.DG_3.Name = "DG_3";
            this.DG_3.RowHeadersWidth = 51;
            this.DG_3.RowTemplate.Height = 24;
            this.DG_3.Size = new System.Drawing.Size(431, 166);
            this.DG_3.TabIndex = 10;
            this.DG_3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_3_CellClick);
            this.DG_3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CB_NOMPUES
            // 
            this.CB_NOMPUES.FormattingEnabled = true;
            this.CB_NOMPUES.Location = new System.Drawing.Point(41, 262);
            this.CB_NOMPUES.Name = "CB_NOMPUES";
            this.CB_NOMPUES.Size = new System.Drawing.Size(214, 24);
            this.CB_NOMPUES.TabIndex = 20;
            this.CB_NOMPUES.SelectedIndexChanged += new System.EventHandler(this.CB_NOMPUES_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Departamento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 25);
            this.button1.TabIndex = 22;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Puestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_NOMPUES);
            this.Controls.Add(this.BTN_EDIT);
            this.Controls.Add(this.BTN_ELIM);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.TB_SALARIO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_PUESTO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DG_3);
            this.Name = "Puestos";
            this.Text = "Puestos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Puestos_FormClosed);
            this.Load += new System.EventHandler(this.Puestos_Load);
            this.Click += new System.EventHandler(this.Puestos_Click);
            ((System.ComponentModel.ISupportInitialize)(this.DG_3)).EndInit();
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
        private System.Windows.Forms.DataGridView DG_3;
        private System.Windows.Forms.ComboBox CB_NOMPUES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}