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
            this.id_percepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_percepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.es_porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_NOM = new System.Windows.Forms.TextBox();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.BTN_ELIM = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_BUSCAR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGD = new System.Windows.Forms.DataGridView();
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.DGP.Location = new System.Drawing.Point(7, 25);
            this.DGP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGP.Name = "DGP";
            this.DGP.RowHeadersWidth = 51;
            this.DGP.RowTemplate.Height = 24;
            this.DGP.Size = new System.Drawing.Size(647, 268);
            this.DGP.TabIndex = 0;
            this.DGP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGP_CellClick);
            // 
            // id_percepcion
            // 
            this.id_percepcion.DataPropertyName = "id_percepcion";
            this.id_percepcion.HeaderText = "ID PERCEPCION";
            this.id_percepcion.MinimumWidth = 6;
            this.id_percepcion.Name = "id_percepcion";
            this.id_percepcion.Visible = false;
            this.id_percepcion.Width = 125;
            // 
            // nombre_percepcion
            // 
            this.nombre_percepcion.DataPropertyName = "nombre_percepcion";
            this.nombre_percepcion.HeaderText = "NOMBRE";
            this.nombre_percepcion.MinimumWidth = 6;
            this.nombre_percepcion.Name = "nombre_percepcion";
            this.nombre_percepcion.Width = 200;
            // 
            // es_porcentaje
            // 
            this.es_porcentaje.DataPropertyName = "es_porcentaje";
            this.es_porcentaje.HeaderText = "ES PORCENTAJE";
            this.es_porcentaje.MinimumWidth = 6;
            this.es_porcentaje.Name = "es_porcentaje";
            this.es_porcentaje.Width = 125;
            // 
            // monto
            // 
            this.monto.DataPropertyName = "monto";
            this.monto.HeaderText = "MONTO";
            this.monto.MinimumWidth = 6;
            this.monto.Name = "monto";
            this.monto.Width = 125;
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "ACTIVO";
            this.activo.MinimumWidth = 6;
            this.activo.Name = "activo";
            this.activo.Visible = false;
            this.activo.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // TB_NOM
            // 
            this.TB_NOM.Location = new System.Drawing.Point(233, 428);
            this.TB_NOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_NOM.Name = "TB_NOM";
            this.TB_NOM.Size = new System.Drawing.Size(243, 22);
            this.TB_NOM.TabIndex = 5;
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.Location = new System.Drawing.Point(253, 546);
            this.BTN_ADD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(75, 23);
            this.BTN_ADD.TabIndex = 6;
            this.BTN_ADD.Text = "Añadir";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            this.BTN_ADD.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_ELIM
            // 
            this.BTN_ELIM.Location = new System.Drawing.Point(389, 546);
            this.BTN_ELIM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_ELIM.Name = "BTN_ELIM";
            this.BTN_ELIM.Size = new System.Drawing.Size(75, 23);
            this.BTN_ELIM.TabIndex = 11;
            this.BTN_ELIM.Text = "Eliminar";
            this.BTN_ELIM.UseVisualStyleBackColor = true;
            this.BTN_ELIM.Click += new System.EventHandler(this.BTN_ELIM_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGP);
            this.groupBox1.Location = new System.Drawing.Point(19, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(660, 311);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Percepciones:";
            // 
            // TB_BUSCAR
            // 
            this.TB_BUSCAR.Location = new System.Drawing.Point(100, 15);
            this.TB_BUSCAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_BUSCAR.Name = "TB_BUSCAR";
            this.TB_BUSCAR.Size = new System.Drawing.Size(289, 22);
            this.TB_BUSCAR.TabIndex = 13;
            this.TB_BUSCAR.TextChanged += new System.EventHandler(this.TB_BUSCAR_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Buscar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGD);
            this.groupBox2.Location = new System.Drawing.Point(691, 58);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(660, 311);
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
            this.DGD.Location = new System.Drawing.Point(7, 25);
            this.DGD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGD.Name = "DGD";
            this.DGD.RowHeadersWidth = 51;
            this.DGD.RowTemplate.Height = 24;
            this.DGD.Size = new System.Drawing.Size(647, 268);
            this.DGD.TabIndex = 0;
            this.DGD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGD_CellClick);
            // 
            // id_deduccion
            // 
            this.id_deduccion.DataPropertyName = "id_deduccion";
            this.id_deduccion.HeaderText = "ID PERCEPCION";
            this.id_deduccion.MinimumWidth = 6;
            this.id_deduccion.Name = "id_deduccion";
            this.id_deduccion.Visible = false;
            this.id_deduccion.Width = 125;
            // 
            // nombre_decuccion
            // 
            this.nombre_decuccion.DataPropertyName = "nombre_deduccion";
            this.nombre_decuccion.HeaderText = "NOMBRE";
            this.nombre_decuccion.MinimumWidth = 6;
            this.nombre_decuccion.Name = "nombre_decuccion";
            this.nombre_decuccion.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "es_porcentaje";
            this.dataGridViewTextBoxColumn3.HeaderText = "ES PORCENTAJE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "monto";
            this.dataGridViewTextBoxColumn4.HeaderText = "MONTO";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "activo";
            this.dataGridViewTextBoxColumn5.HeaderText = "ACTIVO";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // CB_REG
            // 
            this.CB_REG.FormattingEnabled = true;
            this.CB_REG.Items.AddRange(new object[] {
            "Percepcion",
            "Deduccion"});
            this.CB_REG.Location = new System.Drawing.Point(233, 393);
            this.CB_REG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB_REG.Name = "CB_REG";
            this.CB_REG.Size = new System.Drawing.Size(243, 24);
            this.CB_REG.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 396);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Registro:";
            // 
            // CB_POR
            // 
            this.CB_POR.AutoSize = true;
            this.CB_POR.Location = new System.Drawing.Point(233, 463);
            this.CB_POR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CB_POR.Name = "CB_POR";
            this.CB_POR.Size = new System.Drawing.Size(112, 20);
            this.CB_POR.TabIndex = 17;
            this.CB_POR.Text = "Es porcentaje";
            this.CB_POR.UseVisualStyleBackColor = true;
            // 
            // TB_CANT
            // 
            this.TB_CANT.Location = new System.Drawing.Point(233, 494);
            this.TB_CANT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_CANT.Name = "TB_CANT";
            this.TB_CANT.Size = new System.Drawing.Size(243, 22);
            this.TB_CANT.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cantidad:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.checkedListBox1.Location = new System.Drawing.Point(583, 409);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(105, 208);
            this.checkedListBox1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 386);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mes:";
            // 
            // Percepciones_y_deducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
    }
}