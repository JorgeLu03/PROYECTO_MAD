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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Mes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_GENREPORTE
            // 
            this.BTN_GENREPORTE.Location = new System.Drawing.Point(614, 284);
            this.BTN_GENREPORTE.Name = "BTN_GENREPORTE";
            this.BTN_GENREPORTE.Size = new System.Drawing.Size(98, 48);
            this.BTN_GENREPORTE.TabIndex = 8;
            this.BTN_GENREPORTE.Text = "Generar reporte";
            this.BTN_GENREPORTE.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sueldo bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sueldo neto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(580, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 22);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(580, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 22);
            this.textBox2.TabIndex = 13;
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
            this.DG_1.Location = new System.Drawing.Point(15, 45);
            this.DG_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DG_1.Name = "DG_1";
            this.DG_1.RowHeadersWidth = 51;
            this.DG_1.RowTemplate.Height = 24;
            this.DG_1.Size = new System.Drawing.Size(537, 330);
            this.DG_1.TabIndex = 14;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(580, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // Mes
            // 
            this.Mes.AutoSize = true;
            this.Mes.Location = new System.Drawing.Point(577, 43);
            this.Mes.Name = "Mes";
            this.Mes.Size = new System.Drawing.Size(33, 16);
            this.Mes.TabIndex = 16;
            this.Mes.Text = "Mes";
            // 
            // Reporte_nómina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 436);
            this.Controls.Add(this.Mes);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DG_1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTN_GENREPORTE);
            this.Name = "Reporte_nómina";
            this.Text = "Reporte_nómina";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reporte_nómina_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DG_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_GENREPORTE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Mes;
    }
}