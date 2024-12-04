namespace PROYECTO_MAD.PANTALLAS
{
    partial class Departamentos
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
            this.DG_2 = new System.Windows.Forms.DataGridView();
            this.TB_DEP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_SUELDO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.BTN_ELIM = new System.Windows.Forms.Button();
            this.BTN_EDIT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_2)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_2
            // 
            this.DG_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_2.Location = new System.Drawing.Point(12, 12);
            this.DG_2.Name = "DG_2";
            this.DG_2.RowHeadersWidth = 51;
            this.DG_2.RowTemplate.Height = 24;
            this.DG_2.Size = new System.Drawing.Size(431, 166);
            this.DG_2.TabIndex = 0;
            this.DG_2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_2_CellClick);
            this.DG_2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TB_DEP
            // 
            this.TB_DEP.Location = new System.Drawing.Point(12, 260);
            this.TB_DEP.Name = "TB_DEP";
            this.TB_DEP.Size = new System.Drawing.Size(231, 22);
            this.TB_DEP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del Departamento";
            // 
            // TB_SUELDO
            // 
            this.TB_SUELDO.Location = new System.Drawing.Point(12, 312);
            this.TB_SUELDO.Name = "TB_SUELDO";
            this.TB_SUELDO.Size = new System.Drawing.Size(231, 22);
            this.TB_SUELDO.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sueldo";
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.Location = new System.Drawing.Point(346, 237);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(64, 26);
            this.BTN_ADD.TabIndex = 7;
            this.BTN_ADD.Text = "Agregar";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // BTN_ELIM
            // 
            this.BTN_ELIM.Location = new System.Drawing.Point(346, 321);
            this.BTN_ELIM.Name = "BTN_ELIM";
            this.BTN_ELIM.Size = new System.Drawing.Size(64, 26);
            this.BTN_ELIM.TabIndex = 8;
            this.BTN_ELIM.Text = "Eliminar";
            this.BTN_ELIM.UseVisualStyleBackColor = true;
            this.BTN_ELIM.Click += new System.EventHandler(this.BTN_ELIM_Click);
            // 
            // BTN_EDIT
            // 
            this.BTN_EDIT.Location = new System.Drawing.Point(346, 276);
            this.BTN_EDIT.Name = "BTN_EDIT";
            this.BTN_EDIT.Size = new System.Drawing.Size(64, 26);
            this.BTN_EDIT.TabIndex = 9;
            this.BTN_EDIT.Text = "Editar";
            this.BTN_EDIT.UseVisualStyleBackColor = true;
            this.BTN_EDIT.Click += new System.EventHandler(this.BTN_EDIT_Click);
            // 
            // Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.BTN_EDIT);
            this.Controls.Add(this.BTN_ELIM);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.TB_SUELDO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_DEP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DG_2);
            this.Name = "Departamentos";
            this.Text = "Departamentos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Departamentos_FormClosed);
            this.Load += new System.EventHandler(this.Departamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_2;
        private System.Windows.Forms.TextBox TB_DEP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_SUELDO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.Button BTN_ELIM;
        private System.Windows.Forms.Button BTN_EDIT;
    }
}