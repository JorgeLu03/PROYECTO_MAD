namespace PROYECTO_MAD.PANTALLAS
{
    partial class Reporte_nómina
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
            this.BTN_GENREPORTE = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_BRUTO = new System.Windows.Forms.TextBox();
            this.TB_NETO = new System.Windows.Forms.TextBox();
            this.DG_1 = new System.Windows.Forms.DataGridView();
            this.id_empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_contratacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CB_MES = new System.Windows.Forms.ComboBox();
            this.Mes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DTP_AÑO = new System.Windows.Forms.DateTimePicker();
            this.DG_NOM = new System.Windows.Forms.DataGridView();
            this.TB_BUSCAR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.id_nomina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias_trabajados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldo_bruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldo_neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_NOM)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_GENREPORTE
            // 
            this.BTN_GENREPORTE.Location = new System.Drawing.Point(460, 285);
            this.BTN_GENREPORTE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_GENREPORTE.Name = "BTN_GENREPORTE";
            this.BTN_GENREPORTE.Size = new System.Drawing.Size(74, 39);
            this.BTN_GENREPORTE.TabIndex = 8;
            this.BTN_GENREPORTE.Text = "Generar reporte";
            this.BTN_GENREPORTE.UseVisualStyleBackColor = true;
            this.BTN_GENREPORTE.Click += new System.EventHandler(this.BTN_GENREPORTE_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sueldo bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sueldo neto";
            // 
            // TB_BRUTO
            // 
            this.TB_BRUTO.Location = new System.Drawing.Point(435, 193);
            this.TB_BRUTO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_BRUTO.Name = "TB_BRUTO";
            this.TB_BRUTO.Size = new System.Drawing.Size(140, 20);
            this.TB_BRUTO.TabIndex = 12;
            // 
            // TB_NETO
            // 
            this.TB_NETO.Location = new System.Drawing.Point(435, 252);
            this.TB_NETO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_NETO.Name = "TB_NETO";
            this.TB_NETO.Size = new System.Drawing.Size(140, 20);
            this.TB_NETO.TabIndex = 13;
            // 
            // DG_1
            // 
            this.DG_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_empleado,
            this.id_empresa,
            this.id_departamento,
            this.id_puesto,
            this.usuario,
            this.contrasena,
            this.nombre,
            this.apellido_paterno,
            this.apellido_materno,
            this.fecha_nacimiento,
            this.curp,
            this.nss,
            this.rfc,
            this.domicilio,
            this.banco,
            this.numero_cuenta,
            this.email,
            this.telefono,
            this.fecha_contratacion,
            this.activo});
            this.DG_1.Location = new System.Drawing.Point(11, 50);
            this.DG_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DG_1.Name = "DG_1";
            this.DG_1.RowHeadersWidth = 51;
            this.DG_1.RowTemplate.Height = 24;
            this.DG_1.Size = new System.Drawing.Size(403, 268);
            this.DG_1.TabIndex = 14;
            this.DG_1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_1_CellClick);
            // 
            // id_empleado
            // 
            this.id_empleado.DataPropertyName = "id_empleado";
            this.id_empleado.HeaderText = "NUMERO EMPLEADO";
            this.id_empleado.MinimumWidth = 6;
            this.id_empleado.Name = "id_empleado";
            this.id_empleado.Width = 125;
            // 
            // id_empresa
            // 
            this.id_empresa.DataPropertyName = "id_empresa";
            this.id_empresa.HeaderText = "ID EMPRESA";
            this.id_empresa.MinimumWidth = 6;
            this.id_empresa.Name = "id_empresa";
            this.id_empresa.Visible = false;
            this.id_empresa.Width = 125;
            // 
            // id_departamento
            // 
            this.id_departamento.DataPropertyName = "id_departamento";
            this.id_departamento.HeaderText = "DEPARTAMENTO";
            this.id_departamento.MinimumWidth = 6;
            this.id_departamento.Name = "id_departamento";
            this.id_departamento.Visible = false;
            this.id_departamento.Width = 125;
            // 
            // id_puesto
            // 
            this.id_puesto.DataPropertyName = "id_puesto";
            this.id_puesto.HeaderText = "PUESTO";
            this.id_puesto.MinimumWidth = 6;
            this.id_puesto.Name = "id_puesto";
            this.id_puesto.Visible = false;
            this.id_puesto.Width = 125;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "USUARIO";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.Visible = false;
            this.usuario.Width = 125;
            // 
            // contrasena
            // 
            this.contrasena.DataPropertyName = "contrasena";
            this.contrasena.HeaderText = "CONTRASEÑA";
            this.contrasena.MinimumWidth = 6;
            this.contrasena.Name = "contrasena";
            this.contrasena.Visible = false;
            this.contrasena.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 125;
            // 
            // apellido_paterno
            // 
            this.apellido_paterno.DataPropertyName = "apellido_paterno";
            this.apellido_paterno.HeaderText = "APELLIDO PATERNO";
            this.apellido_paterno.MinimumWidth = 6;
            this.apellido_paterno.Name = "apellido_paterno";
            this.apellido_paterno.Width = 125;
            // 
            // apellido_materno
            // 
            this.apellido_materno.DataPropertyName = "apellido_materno";
            this.apellido_materno.HeaderText = "APELLIDO MATERNO";
            this.apellido_materno.MinimumWidth = 6;
            this.apellido_materno.Name = "apellido_materno";
            this.apellido_materno.Width = 125;
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.DataPropertyName = "fecha_nacimiento";
            this.fecha_nacimiento.HeaderText = "FECHA NACIMIENTO";
            this.fecha_nacimiento.MinimumWidth = 6;
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            this.fecha_nacimiento.Visible = false;
            this.fecha_nacimiento.Width = 125;
            // 
            // curp
            // 
            this.curp.DataPropertyName = "curp";
            this.curp.HeaderText = "CURP";
            this.curp.MinimumWidth = 6;
            this.curp.Name = "curp";
            this.curp.Visible = false;
            this.curp.Width = 125;
            // 
            // nss
            // 
            this.nss.DataPropertyName = "nss";
            this.nss.HeaderText = "NSS";
            this.nss.MinimumWidth = 6;
            this.nss.Name = "nss";
            this.nss.Visible = false;
            this.nss.Width = 125;
            // 
            // rfc
            // 
            this.rfc.DataPropertyName = "rfc";
            this.rfc.HeaderText = "RFC";
            this.rfc.MinimumWidth = 6;
            this.rfc.Name = "rfc";
            this.rfc.Visible = false;
            this.rfc.Width = 125;
            // 
            // domicilio
            // 
            this.domicilio.DataPropertyName = "domicilio";
            this.domicilio.HeaderText = "DOMICILIO";
            this.domicilio.MinimumWidth = 6;
            this.domicilio.Name = "domicilio";
            this.domicilio.Visible = false;
            this.domicilio.Width = 125;
            // 
            // banco
            // 
            this.banco.DataPropertyName = "banco";
            this.banco.HeaderText = "BANCO";
            this.banco.MinimumWidth = 6;
            this.banco.Name = "banco";
            this.banco.Visible = false;
            this.banco.Width = 125;
            // 
            // numero_cuenta
            // 
            this.numero_cuenta.DataPropertyName = "numero_cuenta";
            this.numero_cuenta.HeaderText = "CUENTA";
            this.numero_cuenta.MinimumWidth = 6;
            this.numero_cuenta.Name = "numero_cuenta";
            this.numero_cuenta.Visible = false;
            this.numero_cuenta.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "EMAIL";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Visible = false;
            this.email.Width = 125;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.Visible = false;
            this.telefono.Width = 125;
            // 
            // fecha_contratacion
            // 
            this.fecha_contratacion.DataPropertyName = "fecha_contratacion";
            this.fecha_contratacion.HeaderText = "FECHA CONTRATACION";
            this.fecha_contratacion.MinimumWidth = 6;
            this.fecha_contratacion.Name = "fecha_contratacion";
            this.fecha_contratacion.Visible = false;
            this.fecha_contratacion.Width = 125;
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
            // CB_MES
            // 
            this.CB_MES.FormattingEnabled = true;
            this.CB_MES.Location = new System.Drawing.Point(435, 74);
            this.CB_MES.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CB_MES.Name = "CB_MES";
            this.CB_MES.Size = new System.Drawing.Size(140, 21);
            this.CB_MES.TabIndex = 15;
            this.CB_MES.SelectedIndexChanged += new System.EventHandler(this.CB_MES_SelectedIndexChanged);
            // 
            // Mes
            // 
            this.Mes.AutoSize = true;
            this.Mes.Location = new System.Drawing.Point(433, 48);
            this.Mes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mes.Name = "Mes";
            this.Mes.Size = new System.Drawing.Size(27, 13);
            this.Mes.TabIndex = 16;
            this.Mes.Text = "Mes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Año:";
            // 
            // DTP_AÑO
            // 
            this.DTP_AÑO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_AÑO.Location = new System.Drawing.Point(435, 134);
            this.DTP_AÑO.Name = "DTP_AÑO";
            this.DTP_AÑO.Size = new System.Drawing.Size(140, 20);
            this.DTP_AÑO.TabIndex = 18;
            // 
            // DG_NOM
            // 
            this.DG_NOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_NOM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_nomina,
            this.nombre_mes,
            this.Column1,
            this.fecha_pago,
            this.dias_trabajados,
            this.sueldo_bruto,
            this.sueldo_neto,
            this.dataGridViewTextBoxColumn20});
            this.DG_NOM.Location = new System.Drawing.Point(660, 48);
            this.DG_NOM.Margin = new System.Windows.Forms.Padding(2);
            this.DG_NOM.Name = "DG_NOM";
            this.DG_NOM.RowHeadersWidth = 51;
            this.DG_NOM.RowTemplate.Height = 24;
            this.DG_NOM.Size = new System.Drawing.Size(573, 268);
            this.DG_NOM.TabIndex = 19;
            // 
            // TB_BUSCAR
            // 
            this.TB_BUSCAR.Location = new System.Drawing.Point(64, 12);
            this.TB_BUSCAR.Name = "TB_BUSCAR";
            this.TB_BUSCAR.Size = new System.Drawing.Size(315, 20);
            this.TB_BUSCAR.TabIndex = 45;
            this.TB_BUSCAR.TextChanged += new System.EventHandler(this.TB_BUSCAR_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Buscar:";
            // 
            // id_nomina
            // 
            this.id_nomina.DataPropertyName = "id_nomina";
            this.id_nomina.HeaderText = "ID NOMINA";
            this.id_nomina.MinimumWidth = 6;
            this.id_nomina.Name = "id_nomina";
            this.id_nomina.Visible = false;
            this.id_nomina.Width = 125;
            // 
            // nombre_mes
            // 
            this.nombre_mes.DataPropertyName = "nombre_mes";
            this.nombre_mes.HeaderText = "Column2";
            this.nombre_mes.Name = "nombre_mes";
            this.nombre_mes.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_empleado";
            this.Column1.HeaderText = "ID EMPLEADO";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // fecha_pago
            // 
            this.fecha_pago.DataPropertyName = "fecha_pago";
            this.fecha_pago.HeaderText = "FECHA DE PAGO";
            this.fecha_pago.Name = "fecha_pago";
            // 
            // dias_trabajados
            // 
            this.dias_trabajados.DataPropertyName = "dias_trabajados";
            this.dias_trabajados.HeaderText = "DIAS TRABAJADOS";
            this.dias_trabajados.Name = "dias_trabajados";
            // 
            // sueldo_bruto
            // 
            this.sueldo_bruto.DataPropertyName = "sueldo_bruto";
            this.sueldo_bruto.HeaderText = "SUELDO BRUTO";
            this.sueldo_bruto.MinimumWidth = 6;
            this.sueldo_bruto.Name = "sueldo_bruto";
            this.sueldo_bruto.Width = 125;
            // 
            // sueldo_neto
            // 
            this.sueldo_neto.DataPropertyName = "sueldo_neto";
            this.sueldo_neto.HeaderText = "SUELDO NETO";
            this.sueldo_neto.MinimumWidth = 6;
            this.sueldo_neto.Name = "sueldo_neto";
            this.sueldo_neto.Width = 125;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "activo";
            this.dataGridViewTextBoxColumn20.HeaderText = "ACTIVO";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Visible = false;
            this.dataGridViewTextBoxColumn20.Width = 125;
            // 
            // Reporte_nómina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 354);
            this.Controls.Add(this.TB_BUSCAR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DG_NOM);
            this.Controls.Add(this.DTP_AÑO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mes);
            this.Controls.Add(this.CB_MES);
            this.Controls.Add(this.DG_1);
            this.Controls.Add(this.TB_NETO);
            this.Controls.Add(this.TB_BRUTO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_GENREPORTE);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Reporte_nómina";
            this.Text = "Reporte_nómina";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reporte_nómina_FormClosed);
            this.Load += new System.EventHandler(this.Reporte_nómina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_NOM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_GENREPORTE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_BRUTO;
        private System.Windows.Forms.TextBox TB_NETO;
        private System.Windows.Forms.DataGridView DG_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasena;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn curp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nss;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfc;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_contratacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.ComboBox CB_MES;
        private System.Windows.Forms.Label Mes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTP_AÑO;
        private System.Windows.Forms.DataGridView DG_NOM;
        private System.Windows.Forms.TextBox TB_BUSCAR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_nomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias_trabajados;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldo_bruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldo_neto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
    }
}