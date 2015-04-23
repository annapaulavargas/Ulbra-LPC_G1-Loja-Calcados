namespace Trabalho_G1
{
    partial class Form_inicio
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
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeSapatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_vendas = new System.Windows.Forms.Button();
            this.bt_clientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_estoque = new System.Windows.Forms.Button();
            this.bt_fabricantes = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fabricantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(586, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeSapatosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.itemVendasToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // tipoDeSapatosToolStripMenuItem
            // 
            this.tipoDeSapatosToolStripMenuItem.Name = "tipoDeSapatosToolStripMenuItem";
            this.tipoDeSapatosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tipoDeSapatosToolStripMenuItem.Text = "Tipo de Sapatos";
            // 
            // itemVendasToolStripMenuItem
            // 
            this.itemVendasToolStripMenuItem.Name = "itemVendasToolStripMenuItem";
            this.itemVendasToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.itemVendasToolStripMenuItem.Text = "Item Vendas";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // bt_vendas
            // 
            this.bt_vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_vendas.Location = new System.Drawing.Point(216, 118);
            this.bt_vendas.Name = "bt_vendas";
            this.bt_vendas.Size = new System.Drawing.Size(179, 35);
            this.bt_vendas.TabIndex = 10;
            this.bt_vendas.Text = "Vendas";
            this.bt_vendas.UseVisualStyleBackColor = true;
            this.bt_vendas.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_clientes
            // 
            this.bt_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clientes.Location = new System.Drawing.Point(216, 159);
            this.bt_clientes.Name = "bt_clientes";
            this.bt_clientes.Size = new System.Drawing.Size(179, 35);
            this.bt_clientes.TabIndex = 9;
            this.bt_clientes.Text = "Clientes ";
            this.bt_clientes.UseVisualStyleBackColor = true;
            this.bt_clientes.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Escolha uma opção de cadastro:";
            // 
            // bt_estoque
            // 
            this.bt_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_estoque.Location = new System.Drawing.Point(216, 241);
            this.bt_estoque.Name = "bt_estoque";
            this.bt_estoque.Size = new System.Drawing.Size(179, 35);
            this.bt_estoque.TabIndex = 7;
            this.bt_estoque.Text = "Estoque";
            this.bt_estoque.UseVisualStyleBackColor = true;
            this.bt_estoque.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_fabricantes
            // 
            this.bt_fabricantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_fabricantes.Location = new System.Drawing.Point(216, 200);
            this.bt_fabricantes.Name = "bt_fabricantes";
            this.bt_fabricantes.Size = new System.Drawing.Size(179, 35);
            this.bt_fabricantes.TabIndex = 11;
            this.bt_fabricantes.Text = "Fabricantes";
            this.bt_fabricantes.UseVisualStyleBackColor = true;
            this.bt_fabricantes.Click += new System.EventHandler(this.button4_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.fabricantesToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItem1.Text = "Listar";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // fabricantesToolStripMenuItem
            // 
            this.fabricantesToolStripMenuItem.Name = "fabricantesToolStripMenuItem";
            this.fabricantesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fabricantesToolStripMenuItem.Text = "Fabricantes";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // Form_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 410);
            this.Controls.Add(this.bt_fabricantes);
            this.Controls.Add(this.bt_vendas);
            this.Controls.Add(this.bt_clientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_estoque);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_inicio";
            this.Text = "Loja de Calçados";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeSapatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button bt_vendas;
        private System.Windows.Forms.Button bt_clientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_estoque;
        private System.Windows.Forms.ToolStripMenuItem itemVendasToolStripMenuItem;
        private System.Windows.Forms.Button bt_fabricantes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabricantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
    }
}