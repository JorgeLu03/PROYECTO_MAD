namespace PROYECTO_MAD.PANTALLAS
{
    partial class Principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.TB_NOM = new System.Windows.Forms.TextBox();
            this.TB_CURP = new System.Windows.Forms.TextBox();
            this.TB_EMAIL = new System.Windows.Forms.TextBox();
            this.DTP_FECHNAC = new System.Windows.Forms.DateTimePicker();
            this.ELIMINAR = new System.Windows.Forms.Button();
            this.AGREGAR = new System.Windows.Forms.Button();
            this.MODIFY = new System.Windows.Forms.Button();
            this.TB_DOM = new System.Windows.Forms.TextBox();
            this.TB_PSW = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_TEL = new System.Windows.Forms.TextBox();
            this.TB_BANCO = new System.Windows.Forms.TextBox();
            this.TB_NUMCUENTA = new System.Windows.Forms.TextBox();
            this.TB_RFC = new System.Windows.Forms.TextBox();
            this.TB_NSS = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CB_PUESTO = new System.Windows.Forms.ComboBox();
            this.CB_DPTO = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TB_APMAT = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TB_APPAT = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TB_USER = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TB_BUSCAR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 362);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CURP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 608);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 321);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de nacimiento:";
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
            this.DG_1.Location = new System.Drawing.Point(211, 49);
            this.DG_1.Margin = new System.Windows.Forms.Padding(2);
            this.DG_1.Name = "DG_1";
            this.DG_1.RowHeadersWidth = 51;
            this.DG_1.RowTemplate.Height = 24;
            this.DG_1.Size = new System.Drawing.Size(660, 555);
            this.DG_1.TabIndex = 2;
            this.DG_1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_1_CellClick);
            // 
            // id_empleado
            // 
            this.id_empleado.DataPropertyName = "id_empleado";
            this.id_empleado.HeaderText = "NUMERO EMPLEADO";
            this.id_empleado.Name = "id_empleado";
            // 
            // id_empresa
            // 
            this.id_empresa.DataPropertyName = "id_empresa";
            this.id_empresa.HeaderText = "ID EMPRESA";
            this.id_empresa.Name = "id_empresa";
            this.id_empresa.Visible = false;
            // 
            // id_departamento
            // 
            this.id_departamento.DataPropertyName = "id_departamento";
            this.id_departamento.HeaderText = "DEPARTAMENTO";
            this.id_departamento.Name = "id_departamento";
            this.id_departamento.Visible = false;
            // 
            // id_puesto
            // 
            this.id_puesto.DataPropertyName = "id_puesto";
            this.id_puesto.HeaderText = "PUESTO";
            this.id_puesto.Name = "id_puesto";
            this.id_puesto.Visible = false;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "USUARIO";
            this.usuario.Name = "usuario";
            // 
            // contrasena
            // 
            this.contrasena.DataPropertyName = "contrasena";
            this.contrasena.HeaderText = "CONTRASEÑA";
            this.contrasena.Name = "contrasena";
            this.contrasena.Visible = false;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            // 
            // apellido_paterno
            // 
            this.apellido_paterno.DataPropertyName = "apellido_paterno";
            this.apellido_paterno.HeaderText = "APELLIDO PATERNO";
            this.apellido_paterno.Name = "apellido_paterno";
            // 
            // apellido_materno
            // 
            this.apellido_materno.DataPropertyName = "apellido_materno";
            this.apellido_materno.HeaderText = "APELLIDO MATERNO";
            this.apellido_materno.Name = "apellido_materno";
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.DataPropertyName = "fecha_nacimiento";
            this.fecha_nacimiento.HeaderText = "FECHA NACIMIENTO";
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            // 
            // curp
            // 
            this.curp.DataPropertyName = "curp";
            this.curp.HeaderText = "CURP";
            this.curp.Name = "curp";
            // 
            // nss
            // 
            this.nss.DataPropertyName = "nss";
            this.nss.HeaderText = "NSS";
            this.nss.Name = "nss";
            // 
            // rfc
            // 
            this.rfc.DataPropertyName = "rfc";
            this.rfc.HeaderText = "RFC";
            this.rfc.Name = "rfc";
            // 
            // domicilio
            // 
            this.domicilio.DataPropertyName = "domicilio";
            this.domicilio.HeaderText = "DOMICILIO";
            this.domicilio.Name = "domicilio";
            // 
            // banco
            // 
            this.banco.DataPropertyName = "banco";
            this.banco.HeaderText = "BANCO";
            this.banco.Name = "banco";
            // 
            // numero_cuenta
            // 
            this.numero_cuenta.DataPropertyName = "numero_cuenta";
            this.numero_cuenta.HeaderText = "CUENTA";
            this.numero_cuenta.Name = "numero_cuenta";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "EMAIL";
            this.email.Name = "email";
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.Name = "telefono";
            // 
            // fecha_contratacion
            // 
            this.fecha_contratacion.DataPropertyName = "fecha_contratacion";
            this.fecha_contratacion.HeaderText = "FECHA CONTRATACION";
            this.fecha_contratacion.Name = "fecha_contratacion";
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "ACTIVO";
            this.activo.Name = "activo";
            this.activo.Visible = false;
            // 
            // TB_NOM
            // 
            this.TB_NOM.Location = new System.Drawing.Point(22, 215);
            this.TB_NOM.Margin = new System.Windows.Forms.Padding(2);
            this.TB_NOM.Name = "TB_NOM";
            this.TB_NOM.Size = new System.Drawing.Size(163, 20);
            this.TB_NOM.TabIndex = 7;
            // 
            // TB_CURP
            // 
            this.TB_CURP.Location = new System.Drawing.Point(22, 379);
            this.TB_CURP.Margin = new System.Windows.Forms.Padding(2);
            this.TB_CURP.Name = "TB_CURP";
            this.TB_CURP.Size = new System.Drawing.Size(163, 20);
            this.TB_CURP.TabIndex = 11;
            // 
            // TB_EMAIL
            // 
            this.TB_EMAIL.Location = new System.Drawing.Point(22, 625);
            this.TB_EMAIL.Margin = new System.Windows.Forms.Padding(2);
            this.TB_EMAIL.Name = "TB_EMAIL";
            this.TB_EMAIL.Size = new System.Drawing.Size(163, 20);
            this.TB_EMAIL.TabIndex = 17;
            // 
            // DTP_FECHNAC
            // 
            this.DTP_FECHNAC.Location = new System.Drawing.Point(22, 338);
            this.DTP_FECHNAC.Margin = new System.Windows.Forms.Padding(2);
            this.DTP_FECHNAC.Name = "DTP_FECHNAC";
            this.DTP_FECHNAC.Size = new System.Drawing.Size(163, 20);
            this.DTP_FECHNAC.TabIndex = 10;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.Location = new System.Drawing.Point(611, 666);
            this.ELIMINAR.Margin = new System.Windows.Forms.Padding(2);
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.Size = new System.Drawing.Size(70, 19);
            this.ELIMINAR.TabIndex = 9;
            this.ELIMINAR.Text = "ELIMINAR";
            this.ELIMINAR.UseVisualStyleBackColor = true;
            this.ELIMINAR.Click += new System.EventHandler(this.ELIMINAR_Click);
            // 
            // AGREGAR
            // 
            this.AGREGAR.Location = new System.Drawing.Point(451, 666);
            this.AGREGAR.Margin = new System.Windows.Forms.Padding(2);
            this.AGREGAR.Name = "AGREGAR";
            this.AGREGAR.Size = new System.Drawing.Size(70, 19);
            this.AGREGAR.TabIndex = 10;
            this.AGREGAR.Text = "AGREGAR";
            this.AGREGAR.UseVisualStyleBackColor = true;
            this.AGREGAR.Click += new System.EventHandler(this.AGREGAR_Click);
            // 
            // MODIFY
            // 
            this.MODIFY.Location = new System.Drawing.Point(531, 666);
            this.MODIFY.Margin = new System.Windows.Forms.Padding(2);
            this.MODIFY.Name = "MODIFY";
            this.MODIFY.Size = new System.Drawing.Size(70, 19);
            this.MODIFY.TabIndex = 11;
            this.MODIFY.Text = "MODIFICAR";
            this.MODIFY.UseVisualStyleBackColor = true;
            this.MODIFY.Click += new System.EventHandler(this.MODIFY_Click);
            // 
            // TB_DOM
            // 
            this.TB_DOM.Location = new System.Drawing.Point(22, 502);
            this.TB_DOM.Margin = new System.Windows.Forms.Padding(2);
            this.TB_DOM.Name = "TB_DOM";
            this.TB_DOM.Size = new System.Drawing.Size(163, 20);
            this.TB_DOM.TabIndex = 14;
            // 
            // TB_PSW
            // 
            this.TB_PSW.Location = new System.Drawing.Point(22, 174);
            this.TB_PSW.Margin = new System.Windows.Forms.Padding(2);
            this.TB_PSW.Name = "TB_PSW";
            this.TB_PSW.Size = new System.Drawing.Size(163, 20);
            this.TB_PSW.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 157);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Contraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Puesto:";
            // 
            // TB_TEL
            // 
            this.TB_TEL.Location = new System.Drawing.Point(22, 666);
            this.TB_TEL.Margin = new System.Windows.Forms.Padding(2);
            this.TB_TEL.Name = "TB_TEL";
            this.TB_TEL.Size = new System.Drawing.Size(163, 20);
            this.TB_TEL.TabIndex = 18;
            // 
            // TB_BANCO
            // 
            this.TB_BANCO.Location = new System.Drawing.Point(22, 543);
            this.TB_BANCO.Margin = new System.Windows.Forms.Padding(2);
            this.TB_BANCO.Name = "TB_BANCO";
            this.TB_BANCO.Size = new System.Drawing.Size(163, 20);
            this.TB_BANCO.TabIndex = 15;
            // 
            // TB_NUMCUENTA
            // 
            this.TB_NUMCUENTA.Location = new System.Drawing.Point(22, 584);
            this.TB_NUMCUENTA.Margin = new System.Windows.Forms.Padding(2);
            this.TB_NUMCUENTA.Name = "TB_NUMCUENTA";
            this.TB_NUMCUENTA.Size = new System.Drawing.Size(163, 20);
            this.TB_NUMCUENTA.TabIndex = 16;
            // 
            // TB_RFC
            // 
            this.TB_RFC.Location = new System.Drawing.Point(22, 461);
            this.TB_RFC.Margin = new System.Windows.Forms.Padding(2);
            this.TB_RFC.Name = "TB_RFC";
            this.TB_RFC.Size = new System.Drawing.Size(163, 20);
            this.TB_RFC.TabIndex = 13;
            // 
            // TB_NSS
            // 
            this.TB_NSS.Location = new System.Drawing.Point(22, 420);
            this.TB_NSS.Margin = new System.Windows.Forms.Padding(2);
            this.TB_NSS.Name = "TB_NSS";
            this.TB_NSS.Size = new System.Drawing.Size(163, 20);
            this.TB_NSS.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 567);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Número de cuenta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 403);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "NSS:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 649);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Teléfono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 444);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "RFC:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 526);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Banco:";
            // 
            // CB_PUESTO
            // 
            this.CB_PUESTO.FormattingEnabled = true;
            this.CB_PUESTO.Location = new System.Drawing.Point(22, 91);
            this.CB_PUESTO.Margin = new System.Windows.Forms.Padding(2);
            this.CB_PUESTO.Name = "CB_PUESTO";
            this.CB_PUESTO.Size = new System.Drawing.Size(163, 21);
            this.CB_PUESTO.TabIndex = 4;
            // 
            // CB_DPTO
            // 
            this.CB_DPTO.FormattingEnabled = true;
            this.CB_DPTO.Location = new System.Drawing.Point(22, 49);
            this.CB_DPTO.Margin = new System.Windows.Forms.Padding(2);
            this.CB_DPTO.Name = "CB_DPTO";
            this.CB_DPTO.Size = new System.Drawing.Size(163, 21);
            this.CB_DPTO.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 32);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Departamento:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 485);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Domicilio:";
            // 
            // TB_APMAT
            // 
            this.TB_APMAT.Location = new System.Drawing.Point(22, 297);
            this.TB_APMAT.Margin = new System.Windows.Forms.Padding(2);
            this.TB_APMAT.Name = "TB_APMAT";
            this.TB_APMAT.Size = new System.Drawing.Size(163, 20);
            this.TB_APMAT.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 280);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Apellido materno:";
            // 
            // TB_APPAT
            // 
            this.TB_APPAT.Location = new System.Drawing.Point(22, 256);
            this.TB_APPAT.Margin = new System.Windows.Forms.Padding(2);
            this.TB_APPAT.Name = "TB_APPAT";
            this.TB_APPAT.Size = new System.Drawing.Size(163, 20);
            this.TB_APPAT.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 239);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Apellido paterno:";
            // 
            // TB_USER
            // 
            this.TB_USER.Location = new System.Drawing.Point(22, 133);
            this.TB_USER.Margin = new System.Windows.Forms.Padding(2);
            this.TB_USER.Name = "TB_USER";
            this.TB_USER.Size = new System.Drawing.Size(163, 20);
            this.TB_USER.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 116);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "Usuario:";
            // 
            // TB_BUSCAR
            // 
            this.TB_BUSCAR.Location = new System.Drawing.Point(268, 19);
            this.TB_BUSCAR.Name = "TB_BUSCAR";
            this.TB_BUSCAR.Size = new System.Drawing.Size(396, 20);
            this.TB_BUSCAR.TabIndex = 1;
            this.TB_BUSCAR.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Buscar:";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 774);
            this.Controls.Add(this.TB_BUSCAR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_USER);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TB_APPAT);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TB_APMAT);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CB_DPTO);
            this.Controls.Add(this.CB_PUESTO);
            this.Controls.Add(this.TB_TEL);
            this.Controls.Add(this.TB_BANCO);
            this.Controls.Add(this.TB_NUMCUENTA);
            this.Controls.Add(this.TB_RFC);
            this.Controls.Add(this.TB_NSS);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TB_DOM);
            this.Controls.Add(this.TB_PSW);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MODIFY);
            this.Controls.Add(this.AGREGAR);
            this.Controls.Add(this.ELIMINAR);
            this.Controls.Add(this.DTP_FECHNAC);
            this.Controls.Add(this.TB_EMAIL);
            this.Controls.Add(this.TB_CURP);
            this.Controls.Add(this.TB_NOM);
            this.Controls.Add(this.DG_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Principal";
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DG_1;
        private System.Windows.Forms.TextBox TB_NOM;
        private System.Windows.Forms.TextBox TB_CURP;
        private System.Windows.Forms.TextBox TB_EMAIL;
        private System.Windows.Forms.DateTimePicker DTP_FECHNAC;
        private System.Windows.Forms.Button ELIMINAR;
        private System.Windows.Forms.Button AGREGAR;
        private System.Windows.Forms.Button MODIFY;
        private System.Windows.Forms.TextBox TB_DOM;
        private System.Windows.Forms.TextBox TB_PSW;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_TEL;
        private System.Windows.Forms.TextBox TB_BANCO;
        private System.Windows.Forms.TextBox TB_NUMCUENTA;
        private System.Windows.Forms.TextBox TB_RFC;
        private System.Windows.Forms.TextBox TB_NSS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CB_PUESTO;
        private System.Windows.Forms.ComboBox CB_DPTO;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TB_APMAT;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TB_APPAT;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TB_USER;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TB_BUSCAR;
        private System.Windows.Forms.Label label6;
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
    }
}