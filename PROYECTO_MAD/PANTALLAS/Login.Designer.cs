namespace PROYECTO_MAD.PANTALLAS
{
    partial class Login
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
            this.TB_USER = new System.Windows.Forms.TextBox();
            this.TB_PSW = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_TIPO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_INICSES = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_USER
            // 
            this.TB_USER.Location = new System.Drawing.Point(114, 106);
            this.TB_USER.Name = "TB_USER";
            this.TB_USER.Size = new System.Drawing.Size(207, 22);
            this.TB_USER.TabIndex = 0;
            // 
            // TB_PSW
            // 
            this.TB_PSW.Location = new System.Drawing.Point(114, 162);
            this.TB_PSW.Name = "TB_PSW";
            this.TB_PSW.PasswordChar = '*';
            this.TB_PSW.Size = new System.Drawing.Size(207, 22);
            this.TB_PSW.TabIndex = 1;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(51, 112);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(57, 16);
            this.Usuario.TabIndex = 2;
            this.Usuario.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // CB_TIPO
            // 
            this.CB_TIPO.FormattingEnabled = true;
            this.CB_TIPO.Location = new System.Drawing.Point(114, 48);
            this.CB_TIPO.Name = "CB_TIPO";
            this.CB_TIPO.Size = new System.Drawing.Size(111, 24);
            this.CB_TIPO.TabIndex = 4;
            this.CB_TIPO.SelectedIndexChanged += new System.EventHandler(this.CB_TIPO_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo:";
            // 
            // BTN_INICSES
            // 
            this.BTN_INICSES.Location = new System.Drawing.Point(114, 206);
            this.BTN_INICSES.Name = "BTN_INICSES";
            this.BTN_INICSES.Size = new System.Drawing.Size(77, 30);
            this.BTN_INICSES.TabIndex = 6;
            this.BTN_INICSES.Text = "Ingresar";
            this.BTN_INICSES.UseVisualStyleBackColor = true;
            this.BTN_INICSES.Click += new System.EventHandler(this.BTN_INICSES_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 274);
            this.Controls.Add(this.BTN_INICSES);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_TIPO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.TB_PSW);
            this.Controls.Add(this.TB_USER);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_USER;
        private System.Windows.Forms.TextBox TB_PSW;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_TIPO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_INICSES;
    }
}