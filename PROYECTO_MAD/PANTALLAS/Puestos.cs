﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_MAD.PANTALLAS
{
    public partial class Puestos : Form
    {
        public Puestos()
        {
            InitializeComponent();
        }

        private void Puestos_Load(object sender, EventArgs e)
        {

        }

        private void Puestos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Principal_Todos pantallaPrincipal = new Principal_Todos();
            pantallaPrincipal.ShowDialog();
        }
    }
}
