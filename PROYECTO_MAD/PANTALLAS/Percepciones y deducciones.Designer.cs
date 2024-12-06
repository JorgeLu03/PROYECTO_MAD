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
            this.DGP = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_NOM = new System.Windows.Forms.TextBox();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.BTN_ELIM = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_BUSCAR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGD = new System.Windows.Forms.DataGridView();
            this.id_percepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_percepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.es_porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_deduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_decuccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CB_REG = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_POR = new System.Windows.Forms.CheckBox();
            this.TB_CANT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGD)).BeginInit();
            this.SuspendLayout();
            // 
            // DGP
            // 
            this.DGP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_percepcion,
            this.nombre_percepcion,
            this.es_porcentaje,
            this.monto,
            this.activo});
            this.DGP.Location = new System.Drawing.Point(5, 20);
            this.DGP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGP.Name = "DGP";
            this.DGP.RowHeadersWidth = 51;
            this.DGP.RowTemplate.Height = 24;
            this.DGP.Size = new System.Drawing.Size(485, 218);
            this.DGP.TabIndex = 0;
            this.DGP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGP_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 351);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // TB_NOM
            // 
            this.TB_NOM.Location = new System.Drawing.Point(175, 348);
            this.TB_NOM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_NOM.Name = "TB_NOM";
            this.TB_NOM.Size = new System.Drawing.Size(183, 20);
            this.TB_NOM.TabIndex = 5;
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.Location = new System.Drawing.Point(190, 444);
            this.BTN_ADD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(56, 19);
            this.BTN_ADD.TabIndex = 6;
            this.BTN_ADD.Text = "Añadir";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            this.BTN_ADD.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_ELIM
            // 
            this.BTN_ELIM.Location = new System.Drawing.Point(292, 444);
            this.BTN_ELIM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_ELIM.Name = "BTN_ELIM";
            this.BTN_ELIM.Size = new System.Drawing.Size(56, 19);
            this.BTN_ELIM.TabIndex = 11;
            this.BTN_ELIM.Text = "Eliminar";
            this.BTN_ELIM.UseVisualStyleBackColor = true;
            this.BTN_ELIM.Click += new System.EventHandler(this.BTN_ELIM_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGP);
            this.groupBox1.Location = new System.Drawing.Point(14, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 253);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Percepciones:";
            // 
            // TB_BUSCAR
            // 
            this.TB_BUSCAR.Location = new System.Drawing.Point(75, 12);
            this.TB_BUSCAR.Name = "TB_BUSCAR";
            this.TB_BUSCAR.Size = new System.Drawing.Size(218, 20);
            this.TB_BUSCAR.TabIndex = 13;
            this.TB_BUSCAR.TextChanged += new System.EventHandler(this.TB_BUSCAR_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Buscar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGD);
            this.groupBox2.Location = new System.Drawing.Point(518, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 253);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deducciones:";
            // 
            // DGD
            // 
            this.DGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_deduccion,
            this.nombre_decuccion,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.DGD.Location = new System.Drawing.Point(5, 20);
            this.DGD.Margin = new System.Windows.Forms.Padding(2);
            this.DGD.Name = "DGD";
            this.DGD.RowHeadersWidth = 51;
            this.DGD.RowTemplate.Height = 24;
            this.DGD.Size = new System.Drawing.Size(485, 218);
            this.DGD.TabIndex = 0;
            this.DGD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGD_CellClick);
            // 
            // id_percepcion
            // 
            this.id_percepcion.DataPropertyName = "id_percepcion";
            this.id_percepcion.HeaderText = "ID PERCEPCION";
            this.id_percepcion.Name = "id_percepcion";
            this.id_percepcion.Visible = false;
            // 
            // nombre_percepcion
            // 
            this.nombre_percepcion.DataPropertyName = "nombre_percepcion";
            this.nombre_percepcion.HeaderText = "NOMBRE";
            this.nombre_percepcion.Name = "nombre_percepcion";
            this.nombre_percepcion.Width = 200;
            // 
            // es_porcentaje
            // 
            this.es_porcentaje.DataPropertyName = "es_porcentaje";
            this.es_porcentaje.HeaderText = "ES PORCENTAJE";
            this.es_porcentaje.Name = "es_porcentaje";
            // 
            // monto
            // 
            this.monto.DataPropertyName = "monto";
            this.monto.HeaderText = "MONTO";
            this.monto.Name = "monto";
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "ACTIVO";
            this.activo.Name = "activo";
            this.activo.Visible = false;
            // 
            // id_deduccion
            // 
            this.id_deduccion.DataPropertyName = "id_deduccion";
            this.id_deduccion.HeaderText = "ID PERCEPCION";
            this.id_deduccion.Name = "id_deduccion";
            this.id_deduccion.Visible = false;
            // 
            // nombre_decuccion
            // 
            this.nombre_decuccion.DataPropertyName = "nombre_deduccion";
            this.nombre_decuccion.HeaderText = "NOMBRE";
            this.nombre_decuccion.Name = "nombre_decuccion";
            this.nombre_decuccion.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "es_porcentaje";
            this.dataGridViewTextBoxColumn3.HeaderText = "ES PORCENTAJE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "monto";
            this.dataGridViewTextBoxColumn4.HeaderText = "MONTO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "activo";
            this.dataGridViewTextBoxColumn5.HeaderText = "ACTIVO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // CB_REG
            // 
            this.CB_REG.FormattingEnabled = true;
            this.CB_REG.Items.AddRange(new object[] {
            "Percepcion",
            "Deduccion"});
            this.CB_REG.Location = new System.Drawing.Point(175, 319);
            this.CB_REG.Name = "CB_REG";
            this.CB_REG.Size = new System.Drawing.Size(183, 21);
            this.CB_REG.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Registro:";
            // 
            // CB_POR
            // 
            this.CB_POR.AutoSize = true;
            this.CB_POR.Location = new System.Drawing.Point(175, 376);
            this.CB_POR.Name = "CB_POR";
            this.CB_POR.Size = new System.Drawing.Size(91, 17);
            this.CB_POR.TabIndex = 17;
            this.CB_POR.Text = "Es porcentaje";
            this.CB_POR.UseVisualStyleBackColor = true;
            // 
            // TB_CANT
            // 
            this.TB_CANT.Location = new System.Drawing.Point(175, 401);
            this.TB_CANT.Margin = new System.Windows.Forms.Padding(2);
            this.TB_CANT.Name = "TB_CANT";
            this.TB_CANT.Size = new System.Drawing.Size(183, 20);
            this.TB_CANT.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 404);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cantidad:";
            // 
            // Percepciones_y_deducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 499);
            this.Controls.Add(this.TB_CANT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CB_POR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CB_REG);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TB_BUSCAR);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTN_ELIM);
            this.Controls.Add(this.BTN_ADD);
            this.Controls.Add(this.TB_NOM);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Percepciones_y_deducciones";
            this.Text = "Percepciones_y_deducciones";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Percepciones_y_deducciones_FormClosed);
            this.Load += new System.EventHandler(this.Percepciones_y_deducciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_NOM;
        private System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.Button BTN_ELIM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_BUSCAR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_percepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_percepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn es_porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_deduccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_decuccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox CB_REG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CB_POR;
        private System.Windows.Forms.TextBox TB_CANT;
        private System.Windows.Forms.Label label7;
    }
}