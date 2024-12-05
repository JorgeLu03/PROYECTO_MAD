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
            this.TB_BUSCAR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.id_puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proporcion_sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_3)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_EDIT
            // 
            this.BTN_EDIT.Location = new System.Drawing.Point(265, 351);
            this.BTN_EDIT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_EDIT.Name = "BTN_EDIT";
            this.BTN_EDIT.Size = new System.Drawing.Size(48, 21);
            this.BTN_EDIT.TabIndex = 19;
            this.BTN_EDIT.Text = "Editar";
            this.BTN_EDIT.UseVisualStyleBackColor = true;
            this.BTN_EDIT.Click += new System.EventHandler(this.BTN_EDIT_Click);
            // 
            // BTN_ELIM
            // 
            this.BTN_ELIM.Location = new System.Drawing.Point(265, 385);
            this.BTN_ELIM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_ELIM.Name = "BTN_ELIM";
            this.BTN_ELIM.Size = new System.Drawing.Size(48, 21);
            this.BTN_ELIM.TabIndex = 18;
            this.BTN_ELIM.Text = "Eliminar";
            this.BTN_ELIM.UseVisualStyleBackColor = true;
            this.BTN_ELIM.Click += new System.EventHandler(this.BTN_ELIM_Click);
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.Location = new System.Drawing.Point(265, 317);
            this.BTN_ADD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(48, 21);
            this.BTN_ADD.TabIndex = 17;
            this.BTN_ADD.Text = "Agregar";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // TB_SALARIO
            // 
            this.TB_SALARIO.Location = new System.Drawing.Point(15, 391);
            this.TB_SALARIO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_SALARIO.Name = "TB_SALARIO";
            this.TB_SALARIO.Size = new System.Drawing.Size(162, 20);
            this.TB_SALARIO.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 372);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nivel salarial";
            // 
            // TB_PUESTO
            // 
            this.TB_PUESTO.Location = new System.Drawing.Point(15, 349);
            this.TB_PUESTO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_PUESTO.Name = "TB_PUESTO";
            this.TB_PUESTO.Size = new System.Drawing.Size(162, 20);
            this.TB_PUESTO.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre del Puesto";
            // 
            // DG_3
            // 
            this.DG_3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_puesto,
            this.id_departamento,
            this.nombre_puesto,
            this.proporcion_sueldo,
            this.activo});
            this.DG_3.Location = new System.Drawing.Point(11, 42);
            this.DG_3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DG_3.Name = "DG_3";
            this.DG_3.RowHeadersWidth = 51;
            this.DG_3.RowTemplate.Height = 24;
            this.DG_3.Size = new System.Drawing.Size(383, 219);
            this.DG_3.TabIndex = 10;
            this.DG_3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_3_CellClick);
            // 
            // CB_NOMPUES
            // 
            this.CB_NOMPUES.FormattingEnabled = true;
            this.CB_NOMPUES.Location = new System.Drawing.Point(15, 297);
            this.CB_NOMPUES.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CB_NOMPUES.Name = "CB_NOMPUES";
            this.CB_NOMPUES.Size = new System.Drawing.Size(162, 21);
            this.CB_NOMPUES.TabIndex = 20;
            this.CB_NOMPUES.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 278);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Departamento";
            this.label1.Visible = false;
            // 
            // TB_BUSCAR
            // 
            this.TB_BUSCAR.Location = new System.Drawing.Point(61, 13);
            this.TB_BUSCAR.Name = "TB_BUSCAR";
            this.TB_BUSCAR.Size = new System.Drawing.Size(218, 20);
            this.TB_BUSCAR.TabIndex = 23;
            this.TB_BUSCAR.TextChanged += new System.EventHandler(this.TB_BUSCAR_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Buscar:";
            // 
            // id_puesto
            // 
            this.id_puesto.DataPropertyName = "id_puesto";
            this.id_puesto.HeaderText = "ID";
            this.id_puesto.Name = "id_puesto";
            // 
            // id_departamento
            // 
            this.id_departamento.DataPropertyName = "id_departamento";
            this.id_departamento.HeaderText = "ID DEPARTAMENTO";
            this.id_departamento.Name = "id_departamento";
            this.id_departamento.Visible = false;
            // 
            // nombre_puesto
            // 
            this.nombre_puesto.DataPropertyName = "nombre_puesto";
            this.nombre_puesto.HeaderText = "NOMBRE";
            this.nombre_puesto.Name = "nombre_puesto";
            // 
            // proporcion_sueldo
            // 
            this.proporcion_sueldo.DataPropertyName = "proporcion_sueldo";
            this.proporcion_sueldo.HeaderText = "PROPORCION SUELDO";
            this.proporcion_sueldo.Name = "proporcion_sueldo";
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "ACTIVO";
            this.activo.Name = "activo";
            this.activo.Visible = false;
            // 
            // Puestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 422);
            this.Controls.Add(this.TB_BUSCAR);
            this.Controls.Add(this.label4);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Puestos";
            this.Text = "Puestos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Puestos_FormClosed);
            this.Load += new System.EventHandler(this.Puestos_Load);
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
        private System.Windows.Forms.TextBox TB_BUSCAR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn proporcion_sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
    }
}