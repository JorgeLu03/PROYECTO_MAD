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
            this.id_departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldo_base_diario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_BUSCAR = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_2)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_2
            // 
            this.DG_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_departamento,
            this.nombre_departamento,
            this.sueldo_base_diario,
            this.id_empresa,
            this.activo});
            this.DG_2.Location = new System.Drawing.Point(9, 50);
            this.DG_2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DG_2.Name = "DG_2";
            this.DG_2.RowHeadersWidth = 51;
            this.DG_2.RowTemplate.Height = 24;
            this.DG_2.Size = new System.Drawing.Size(480, 190);
            this.DG_2.TabIndex = 0;
            this.DG_2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_2_CellClick);
            // 
            // TB_DEP
            // 
            this.TB_DEP.Location = new System.Drawing.Point(9, 313);
            this.TB_DEP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_DEP.Name = "TB_DEP";
            this.TB_DEP.Size = new System.Drawing.Size(174, 20);
            this.TB_DEP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 295);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del Departamento";
            // 
            // TB_SUELDO
            // 
            this.TB_SUELDO.Location = new System.Drawing.Point(9, 356);
            this.TB_SUELDO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_SUELDO.Name = "TB_SUELDO";
            this.TB_SUELDO.Size = new System.Drawing.Size(174, 20);
            this.TB_SUELDO.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 337);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sueldo";
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.Location = new System.Drawing.Point(260, 295);
            this.BTN_ADD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(48, 21);
            this.BTN_ADD.TabIndex = 7;
            this.BTN_ADD.Text = "Agregar";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // BTN_ELIM
            // 
            this.BTN_ELIM.Location = new System.Drawing.Point(260, 363);
            this.BTN_ELIM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_ELIM.Name = "BTN_ELIM";
            this.BTN_ELIM.Size = new System.Drawing.Size(48, 21);
            this.BTN_ELIM.TabIndex = 8;
            this.BTN_ELIM.Text = "Eliminar";
            this.BTN_ELIM.UseVisualStyleBackColor = true;
            this.BTN_ELIM.Click += new System.EventHandler(this.BTN_ELIM_Click);
            // 
            // BTN_EDIT
            // 
            this.BTN_EDIT.Location = new System.Drawing.Point(260, 326);
            this.BTN_EDIT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_EDIT.Name = "BTN_EDIT";
            this.BTN_EDIT.Size = new System.Drawing.Size(48, 21);
            this.BTN_EDIT.TabIndex = 9;
            this.BTN_EDIT.Text = "Editar";
            this.BTN_EDIT.UseVisualStyleBackColor = true;
            this.BTN_EDIT.Click += new System.EventHandler(this.BTN_EDIT_Click);
            // 
            // id_departamento
            // 
            this.id_departamento.DataPropertyName = "id_departamento";
            this.id_departamento.HeaderText = "ID";
            this.id_departamento.Name = "id_departamento";
            // 
            // nombre_departamento
            // 
            this.nombre_departamento.DataPropertyName = "nombre_departamento";
            this.nombre_departamento.HeaderText = "NOMBRE";
            this.nombre_departamento.Name = "nombre_departamento";
            this.nombre_departamento.Width = 200;
            // 
            // sueldo_base_diario
            // 
            this.sueldo_base_diario.DataPropertyName = "sueldo_base_diario";
            this.sueldo_base_diario.HeaderText = "SUELDO BASE";
            this.sueldo_base_diario.Name = "sueldo_base_diario";
            // 
            // id_empresa
            // 
            this.id_empresa.DataPropertyName = "id_empresa";
            this.id_empresa.HeaderText = "ID EMPRESA";
            this.id_empresa.Name = "id_empresa";
            this.id_empresa.Visible = false;
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "ACTIVO";
            this.activo.Name = "activo";
            this.activo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar:";
            // 
            // TB_BUSCAR
            // 
            this.TB_BUSCAR.Location = new System.Drawing.Point(58, 10);
            this.TB_BUSCAR.Name = "TB_BUSCAR";
            this.TB_BUSCAR.Size = new System.Drawing.Size(218, 20);
            this.TB_BUSCAR.TabIndex = 11;
            this.TB_BUSCAR.TextChanged += new System.EventHandler(this.TB_BUSCAR_TextChanged);
            // 
            // Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 423);
            this.Controls.Add(this.TB_BUSCAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_EDIT);
            this.Controls.Add(this.BTN_ELIM);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.TB_SUELDO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_DEP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DG_2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id_departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldo_base_diario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_BUSCAR;
    }
}