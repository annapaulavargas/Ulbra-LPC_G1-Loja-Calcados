﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trabalho_G1
{
    public partial class Form_vendas : Form
    {
        public Form_vendas()
        {
            InitializeComponent();
        }

        private void mostrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (codigoBox.Text == "" || clienteBox.Text == "" || dataVendaBox.Text == "" || totalBox.Text == "")
            {
                MessageBox.Show("Campo em branco, valor inválido...", "Campo Inválido");
            }
            else
            {
                    
            }
        }
    }
}
