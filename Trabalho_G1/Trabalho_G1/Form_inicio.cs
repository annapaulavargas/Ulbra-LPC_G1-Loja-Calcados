using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trabalho_G1
{
    public partial class Form_inicio : Form
    {
        public Form_inicio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_cliente cliente = new Form_cliente();
            cliente.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_vendas vendas = new Form_vendas();
            vendas.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_fabricante fabricante = new Form_fabricante();
            fabricante.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_estoque estoque = new Form_estoque();
            estoque.Show();

        }
    }
}
