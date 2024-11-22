namespace PROYECTO_MAD.PANTALLAS
{
    partial class STRIPMENU
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.percepcionesYDeduccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nóminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nóminaGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nóminaPorDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nóminaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.percepcionesYDeduccionesToolStripMenuItem,
            this.nóminaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puestosToolStripMenuItem});
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            this.departamentosToolStripMenuItem.Click += new System.EventHandler(this.departamentosToolStripMenuItem_Click);
            // 
            // puestosToolStripMenuItem
            // 
            this.puestosToolStripMenuItem.Name = "puestosToolStripMenuItem";
            this.puestosToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.puestosToolStripMenuItem.Text = "Puestos";
            // 
            // percepcionesYDeduccionesToolStripMenuItem
            // 
            this.percepcionesYDeduccionesToolStripMenuItem.Name = "percepcionesYDeduccionesToolStripMenuItem";
            this.percepcionesYDeduccionesToolStripMenuItem.Size = new System.Drawing.Size(209, 24);
            this.percepcionesYDeduccionesToolStripMenuItem.Text = "Percepciones y Deducciones";
            // 
            // nóminaToolStripMenuItem
            // 
            this.nóminaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nóminaGeneralToolStripMenuItem,
            this.nóminaPorDepartamentoToolStripMenuItem,
            this.nóminaToolStripMenuItem1});
            this.nóminaToolStripMenuItem.Name = "nóminaToolStripMenuItem";
            this.nóminaToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.nóminaToolStripMenuItem.Text = "Reportes";
            // 
            // nóminaGeneralToolStripMenuItem
            // 
            this.nóminaGeneralToolStripMenuItem.Name = "nóminaGeneralToolStripMenuItem";
            this.nóminaGeneralToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.nóminaGeneralToolStripMenuItem.Text = "Nómina general";
            // 
            // nóminaPorDepartamentoToolStripMenuItem
            // 
            this.nóminaPorDepartamentoToolStripMenuItem.Name = "nóminaPorDepartamentoToolStripMenuItem";
            this.nóminaPorDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.nóminaPorDepartamentoToolStripMenuItem.Text = "Nómina por departamento";
            // 
            // nóminaToolStripMenuItem1
            // 
            this.nóminaToolStripMenuItem1.Name = "nóminaToolStripMenuItem1";
            this.nóminaToolStripMenuItem1.Size = new System.Drawing.Size(271, 26);
            this.nóminaToolStripMenuItem1.Text = "Nómina";
            // 
            // STRIPMENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "STRIPMENU";
            this.Text = "STRIPMENU";
            this.Load += new System.EventHandler(this.STRIPMENU_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem percepcionesYDeduccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nóminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nóminaGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nóminaPorDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nóminaToolStripMenuItem1;
    }
}