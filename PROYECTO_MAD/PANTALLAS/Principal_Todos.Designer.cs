namespace PROYECTO_MAD.PANTALLAS
{
    partial class Principal_Todos
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
            this.BTN_GESDEP = new System.Windows.Forms.Button();
            this.BTN_GESEMPL = new System.Windows.Forms.Button();
            this.BTN_PUES = new System.Windows.Forms.Button();
            this.BTN_NOM = new System.Windows.Forms.Button();
            this.BTN_NOMGEN = new System.Windows.Forms.Button();
            this.BTN_GESPUES = new System.Windows.Forms.Button();
            this.BTN_EMP = new System.Windows.Forms.Button();
            this.BTN_PERC = new System.Windows.Forms.Button();
            this.BTN_GESEMPR = new System.Windows.Forms.Button();
            this.BTN_LOGOUT = new System.Windows.Forms.Button();
            this.LB_NOMBRE = new System.Windows.Forms.Label();
            this.LB_PUESTO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_GESDEP
            // 
            this.BTN_GESDEP.Location = new System.Drawing.Point(68, 107);
            this.BTN_GESDEP.Name = "BTN_GESDEP";
            this.BTN_GESDEP.Size = new System.Drawing.Size(130, 42);
            this.BTN_GESDEP.TabIndex = 0;
            this.BTN_GESDEP.Text = "Gestión de departamentos";
            this.BTN_GESDEP.UseVisualStyleBackColor = true;
            this.BTN_GESDEP.Click += new System.EventHandler(this.BTN_GESDEP_Click);
            // 
            // BTN_GESEMPL
            // 
            this.BTN_GESEMPL.Location = new System.Drawing.Point(68, 155);
            this.BTN_GESEMPL.Name = "BTN_GESEMPL";
            this.BTN_GESEMPL.Size = new System.Drawing.Size(130, 42);
            this.BTN_GESEMPL.TabIndex = 1;
            this.BTN_GESEMPL.Text = "Gestión de empleados";
            this.BTN_GESEMPL.UseVisualStyleBackColor = true;
            this.BTN_GESEMPL.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_PUES
            // 
            this.BTN_PUES.Location = new System.Drawing.Point(226, 155);
            this.BTN_PUES.Name = "BTN_PUES";
            this.BTN_PUES.Size = new System.Drawing.Size(130, 42);
            this.BTN_PUES.TabIndex = 4;
            this.BTN_PUES.Text = "Reportes por puestos";
            this.BTN_PUES.UseVisualStyleBackColor = true;
            this.BTN_PUES.Click += new System.EventHandler(this.BTN_PUES_Click);
            // 
            // BTN_NOM
            // 
            this.BTN_NOM.Location = new System.Drawing.Point(226, 107);
            this.BTN_NOM.Name = "BTN_NOM";
            this.BTN_NOM.Size = new System.Drawing.Size(130, 42);
            this.BTN_NOM.TabIndex = 5;
            this.BTN_NOM.Text = "Nómina";
            this.BTN_NOM.UseVisualStyleBackColor = true;
            this.BTN_NOM.Click += new System.EventHandler(this.BTN_NOM_Click);
            // 
            // BTN_NOMGEN
            // 
            this.BTN_NOMGEN.Location = new System.Drawing.Point(226, 251);
            this.BTN_NOMGEN.Name = "BTN_NOMGEN";
            this.BTN_NOMGEN.Size = new System.Drawing.Size(130, 42);
            this.BTN_NOMGEN.TabIndex = 6;
            this.BTN_NOMGEN.Text = "Reporte General de nómina";
            this.BTN_NOMGEN.UseVisualStyleBackColor = true;
            this.BTN_NOMGEN.Click += new System.EventHandler(this.BTN_NOMGEN_Click);
            // 
            // BTN_GESPUES
            // 
            this.BTN_GESPUES.Location = new System.Drawing.Point(226, 203);
            this.BTN_GESPUES.Name = "BTN_GESPUES";
            this.BTN_GESPUES.Size = new System.Drawing.Size(130, 42);
            this.BTN_GESPUES.TabIndex = 7;
            this.BTN_GESPUES.Text = "Gestión de puestos";
            this.BTN_GESPUES.UseVisualStyleBackColor = true;
            this.BTN_GESPUES.Click += new System.EventHandler(this.BTN_GESPUES_Click);
            // 
            // BTN_EMP
            // 
            this.BTN_EMP.Location = new System.Drawing.Point(146, 349);
            this.BTN_EMP.Name = "BTN_EMP";
            this.BTN_EMP.Size = new System.Drawing.Size(130, 42);
            this.BTN_EMP.TabIndex = 8;
            this.BTN_EMP.Text = "Empleados";
            this.BTN_EMP.UseVisualStyleBackColor = true;
            this.BTN_EMP.Click += new System.EventHandler(this.BTN_EMP_Click);
            // 
            // BTN_PERC
            // 
            this.BTN_PERC.Location = new System.Drawing.Point(68, 251);
            this.BTN_PERC.Name = "BTN_PERC";
            this.BTN_PERC.Size = new System.Drawing.Size(130, 42);
            this.BTN_PERC.TabIndex = 9;
            this.BTN_PERC.Text = "Percepciones y deducciones";
            this.BTN_PERC.UseVisualStyleBackColor = true;
            this.BTN_PERC.Click += new System.EventHandler(this.BTN_PERC_Click);
            // 
            // BTN_GESEMPR
            // 
            this.BTN_GESEMPR.Location = new System.Drawing.Point(68, 203);
            this.BTN_GESEMPR.Name = "BTN_GESEMPR";
            this.BTN_GESEMPR.Size = new System.Drawing.Size(130, 42);
            this.BTN_GESEMPR.TabIndex = 10;
            this.BTN_GESEMPR.Text = "Gestión de empresa";
            this.BTN_GESEMPR.UseVisualStyleBackColor = true;
            this.BTN_GESEMPR.Click += new System.EventHandler(this.BTN_GESEMPR_Click);
            // 
            // BTN_LOGOUT
            // 
            this.BTN_LOGOUT.Location = new System.Drawing.Point(146, 408);
            this.BTN_LOGOUT.Name = "BTN_LOGOUT";
            this.BTN_LOGOUT.Size = new System.Drawing.Size(130, 42);
            this.BTN_LOGOUT.TabIndex = 11;
            this.BTN_LOGOUT.Text = "Cerrar sesión";
            this.BTN_LOGOUT.UseVisualStyleBackColor = true;
            this.BTN_LOGOUT.Click += new System.EventHandler(this.BTN_LOGOUT_Click);
            // 
            // LB_NOMBRE
            // 
            this.LB_NOMBRE.AutoSize = true;
            this.LB_NOMBRE.Location = new System.Drawing.Point(31, 13);
            this.LB_NOMBRE.Name = "LB_NOMBRE";
            this.LB_NOMBRE.Size = new System.Drawing.Size(27, 16);
            this.LB_NOMBRE.TabIndex = 12;
            this.LB_NOMBRE.Text = "****";
            this.LB_NOMBRE.Click += new System.EventHandler(this.LB_NOMBRE_Click);
            // 
            // LB_PUESTO
            // 
            this.LB_PUESTO.AutoSize = true;
            this.LB_PUESTO.Location = new System.Drawing.Point(31, 29);
            this.LB_PUESTO.Name = "LB_PUESTO";
            this.LB_PUESTO.Size = new System.Drawing.Size(44, 16);
            this.LB_PUESTO.TabIndex = 13;
            this.LB_PUESTO.Text = "label1";
            // 
            // Principal_Todos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 508);
            this.Controls.Add(this.LB_PUESTO);
            this.Controls.Add(this.LB_NOMBRE);
            this.Controls.Add(this.BTN_LOGOUT);
            this.Controls.Add(this.BTN_GESEMPR);
            this.Controls.Add(this.BTN_PERC);
            this.Controls.Add(this.BTN_EMP);
            this.Controls.Add(this.BTN_GESPUES);
            this.Controls.Add(this.BTN_NOMGEN);
            this.Controls.Add(this.BTN_NOM);
            this.Controls.Add(this.BTN_PUES);
            this.Controls.Add(this.BTN_GESEMPL);
            this.Controls.Add(this.BTN_GESDEP);
            this.Name = "Principal_Todos";
            this.Text = "Principal_Gerente";
            this.Load += new System.EventHandler(this.Principal_Todos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_GESDEP;
        private System.Windows.Forms.Button BTN_GESEMPL;
        private System.Windows.Forms.Button BTN_PUES;
        private System.Windows.Forms.Button BTN_NOM;
        private System.Windows.Forms.Button BTN_NOMGEN;
        private System.Windows.Forms.Button BTN_GESPUES;
        private System.Windows.Forms.Button BTN_EMP;
        private System.Windows.Forms.Button BTN_PERC;
        private System.Windows.Forms.Button BTN_GESEMPR;
        private System.Windows.Forms.Button BTN_LOGOUT;
        private System.Windows.Forms.Label LB_NOMBRE;
        private System.Windows.Forms.Label LB_PUESTO;
    }
}