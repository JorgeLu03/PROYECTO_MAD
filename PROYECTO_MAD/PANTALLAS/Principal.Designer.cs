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
            this.TB_NOM = new System.Windows.Forms.TextBox();
            this.TB_CURP = new System.Windows.Forms.TextBox();
            this.TB_EMAIL = new System.Windows.Forms.TextBox();
            this.DTP_FECHNAC = new System.Windows.Forms.DateTimePicker();
            this.ELIMINAR = new System.Windows.Forms.Button();
            this.AGREGAR = new System.Windows.Forms.Button();
            this.MODIFY = new System.Windows.Forms.Button();
            this.TB_BUSCAR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_NUMEMP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.DG_1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "CURP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 703);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // DG_1
            // 
            this.DG_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_1.Location = new System.Drawing.Point(335, 39);
            this.DG_1.Name = "DG_1";
            this.DG_1.RowHeadersWidth = 51;
            this.DG_1.RowTemplate.Height = 24;
            this.DG_1.Size = new System.Drawing.Size(676, 504);
            this.DG_1.TabIndex = 4;
            this.DG_1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_1_CellClick);
            this.DG_1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_1_CellContentClick);
            // 
            // TB_NOM
            // 
            this.TB_NOM.Location = new System.Drawing.Point(30, 58);
            this.TB_NOM.Name = "TB_NOM";
            this.TB_NOM.Size = new System.Drawing.Size(216, 22);
            this.TB_NOM.TabIndex = 5;
            this.TB_NOM.TextChanged += new System.EventHandler(this.TB_NOM_TextChanged);
            // 
            // TB_CURP
            // 
            this.TB_CURP.Location = new System.Drawing.Point(30, 190);
            this.TB_CURP.Name = "TB_CURP";
            this.TB_CURP.Size = new System.Drawing.Size(216, 22);
            this.TB_CURP.TabIndex = 6;
            // 
            // TB_EMAIL
            // 
            this.TB_EMAIL.Location = new System.Drawing.Point(30, 234);
            this.TB_EMAIL.Name = "TB_EMAIL";
            this.TB_EMAIL.Size = new System.Drawing.Size(216, 22);
            this.TB_EMAIL.TabIndex = 7;
            // 
            // DTP_FECHNAC
            // 
            this.DTP_FECHNAC.Location = new System.Drawing.Point(30, 722);
            this.DTP_FECHNAC.Name = "DTP_FECHNAC";
            this.DTP_FECHNAC.Size = new System.Drawing.Size(216, 22);
            this.DTP_FECHNAC.TabIndex = 8;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.Location = new System.Drawing.Point(838, 567);
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.Size = new System.Drawing.Size(93, 23);
            this.ELIMINAR.TabIndex = 9;
            this.ELIMINAR.Text = "ELIMINAR";
            this.ELIMINAR.UseVisualStyleBackColor = true;
            this.ELIMINAR.Click += new System.EventHandler(this.ELIMINAR_Click);
            // 
            // AGREGAR
            // 
            this.AGREGAR.Location = new System.Drawing.Point(624, 567);
            this.AGREGAR.Name = "AGREGAR";
            this.AGREGAR.Size = new System.Drawing.Size(93, 23);
            this.AGREGAR.TabIndex = 10;
            this.AGREGAR.Text = "AGREGAR";
            this.AGREGAR.UseVisualStyleBackColor = true;
            this.AGREGAR.Click += new System.EventHandler(this.AGREGAR_Click);
            // 
            // MODIFY
            // 
            this.MODIFY.Location = new System.Drawing.Point(731, 567);
            this.MODIFY.Name = "MODIFY";
            this.MODIFY.Size = new System.Drawing.Size(93, 23);
            this.MODIFY.TabIndex = 11;
            this.MODIFY.Text = "MODIFICAR";
            this.MODIFY.UseVisualStyleBackColor = true;
            this.MODIFY.Click += new System.EventHandler(this.MODIFY_Click);
            // 
            // TB_BUSCAR
            // 
            this.TB_BUSCAR.Location = new System.Drawing.Point(453, 568);
            this.TB_BUSCAR.Name = "TB_BUSCAR";
            this.TB_BUSCAR.Size = new System.Drawing.Size(133, 22);
            this.TB_BUSCAR.TabIndex = 12;
            this.TB_BUSCAR.TextChanged += new System.EventHandler(this.TB_BUSCAR_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 571);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Buscar Empleado";
            // 
            // TB_NUMEMP
            // 
            this.TB_NUMEMP.Location = new System.Drawing.Point(30, 278);
            this.TB_NUMEMP.Name = "TB_NUMEMP";
            this.TB_NUMEMP.Size = new System.Drawing.Size(216, 22);
            this.TB_NUMEMP.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Número de empleado:";
            // 
            // TB_DOM
            // 
            this.TB_DOM.Location = new System.Drawing.Point(30, 458);
            this.TB_DOM.Name = "TB_DOM";
            this.TB_DOM.Size = new System.Drawing.Size(216, 22);
            this.TB_DOM.TabIndex = 23;
            this.TB_DOM.TextChanged += new System.EventHandler(this.TB_DOM_TextChanged);
            // 
            // TB_PSW
            // 
            this.TB_PSW.Location = new System.Drawing.Point(30, 322);
            this.TB_PSW.Name = "TB_PSW";
            this.TB_PSW.Size = new System.Drawing.Size(216, 22);
            this.TB_PSW.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Contraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Puesto:";
            // 
            // TB_TEL
            // 
            this.TB_TEL.Location = new System.Drawing.Point(30, 678);
            this.TB_TEL.Name = "TB_TEL";
            this.TB_TEL.Size = new System.Drawing.Size(216, 22);
            this.TB_TEL.TabIndex = 33;
            // 
            // TB_BANCO
            // 
            this.TB_BANCO.Location = new System.Drawing.Point(30, 590);
            this.TB_BANCO.Name = "TB_BANCO";
            this.TB_BANCO.Size = new System.Drawing.Size(216, 22);
            this.TB_BANCO.TabIndex = 32;
            // 
            // TB_NUMCUENTA
            // 
            this.TB_NUMCUENTA.Location = new System.Drawing.Point(30, 634);
            this.TB_NUMCUENTA.Name = "TB_NUMCUENTA";
            this.TB_NUMCUENTA.Size = new System.Drawing.Size(216, 22);
            this.TB_NUMCUENTA.TabIndex = 31;
            // 
            // TB_RFC
            // 
            this.TB_RFC.Location = new System.Drawing.Point(30, 546);
            this.TB_RFC.Name = "TB_RFC";
            this.TB_RFC.Size = new System.Drawing.Size(216, 22);
            this.TB_RFC.TabIndex = 30;
            // 
            // TB_NSS
            // 
            this.TB_NSS.Location = new System.Drawing.Point(30, 502);
            this.TB_NSS.Name = "TB_NSS";
            this.TB_NSS.Size = new System.Drawing.Size(216, 22);
            this.TB_NSS.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 615);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Número de cuenta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 483);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "NSS:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 659);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Teléfono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 527);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "RFC:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 571);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Banco:";
            // 
            // CB_PUESTO
            // 
            this.CB_PUESTO.FormattingEnabled = true;
            this.CB_PUESTO.Location = new System.Drawing.Point(30, 412);
            this.CB_PUESTO.Name = "CB_PUESTO";
            this.CB_PUESTO.Size = new System.Drawing.Size(216, 24);
            this.CB_PUESTO.TabIndex = 34;
            // 
            // CB_DPTO
            // 
            this.CB_DPTO.FormattingEnabled = true;
            this.CB_DPTO.Location = new System.Drawing.Point(30, 366);
            this.CB_DPTO.Name = "CB_DPTO";
            this.CB_DPTO.Size = new System.Drawing.Size(216, 24);
            this.CB_DPTO.TabIndex = 35;
            this.CB_DPTO.SelectedIndexChanged += new System.EventHandler(this.CB_DPTO_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 16);
            this.label13.TabIndex = 36;
            this.label13.Text = "Departamento:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 439);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 16);
            this.label15.TabIndex = 37;
            this.label15.Text = "Domicilio:";
            // 
            // TB_APMAT
            // 
            this.TB_APMAT.Location = new System.Drawing.Point(30, 102);
            this.TB_APMAT.Name = "TB_APMAT";
            this.TB_APMAT.Size = new System.Drawing.Size(216, 22);
            this.TB_APMAT.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 16);
            this.label16.TabIndex = 38;
            this.label16.Text = "Apellido materno:";
            // 
            // TB_APPAT
            // 
            this.TB_APPAT.Location = new System.Drawing.Point(30, 146);
            this.TB_APPAT.Name = "TB_APPAT";
            this.TB_APPAT.Size = new System.Drawing.Size(216, 22);
            this.TB_APPAT.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 16);
            this.label17.TabIndex = 40;
            this.label17.Text = "Apellido paterno:";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 781);
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
            this.Controls.Add(this.TB_NUMEMP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_BUSCAR);
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
        private System.Windows.Forms.TextBox TB_BUSCAR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_NUMEMP;
        private System.Windows.Forms.Label label6;
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
    }
}