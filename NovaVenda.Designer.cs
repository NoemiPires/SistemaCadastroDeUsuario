namespace SistemaCadastroDeUsuario
{
    partial class NovaVenda
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
            panel1 = new Panel();
            btnSalvarCompr = new Button();
            lsbItens = new ListBox();
            lblTotal = new Label();
            lblTotalCompra = new Label();
            lblNomeCliente = new Label();
            gpbItem = new GroupBox();
            btnAdicionar = new Button();
            txtDesconto = new TextBox();
            lblDesconto = new Label();
            cmdCatergoria = new ComboBox();
            txtPreco = new TextBox();
            txtQuantidade = new TextBox();
            lblQuantidade = new Label();
            lblPreco = new Label();
            lblProduto = new Label();
            panel1.SuspendLayout();
            gpbItem.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(gpbItem);
            panel1.Controls.Add(btnSalvarCompr);
            panel1.Controls.Add(lsbItens);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(lblTotalCompra);
            panel1.Controls.Add(lblNomeCliente);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 337);
            panel1.TabIndex = 0;
            // 
            // btnSalvarCompr
            // 
            btnSalvarCompr.Location = new Point(600, 305);
            btnSalvarCompr.Name = "btnSalvarCompr";
            btnSalvarCompr.Size = new Size(75, 23);
            btnSalvarCompr.TabIndex = 2;
            btnSalvarCompr.Text = "Salvar";
            btnSalvarCompr.UseVisualStyleBackColor = true;
            // 
            // lsbItens
            // 
            lsbItens.FormattingEnabled = true;
            lsbItens.ItemHeight = 15;
            lsbItens.Location = new Point(14, 53);
            lsbItens.Name = "lsbItens";
            lsbItens.Size = new Size(182, 229);
            lsbItens.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(113, 305);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total";
            // 
            // lblTotalCompra
            // 
            lblTotalCompra.AutoSize = true;
            lblTotalCompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCompra.Location = new Point(14, 305);
            lblTotalCompra.Name = "lblTotalCompra";
            lblTotalCompra.Size = new Size(83, 15);
            lblTotalCompra.TabIndex = 1;
            lblTotalCompra.Text = "Total Compra:";
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNomeCliente.Location = new Point(14, 21);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(52, 15);
            lblNomeCliente.TabIndex = 0;
            lblNomeCliente.Text = "(Cliente)";
            // 
            // gpbItem
            // 
            gpbItem.Controls.Add(btnAdicionar);
            gpbItem.Controls.Add(txtDesconto);
            gpbItem.Controls.Add(lblDesconto);
            gpbItem.Controls.Add(cmdCatergoria);
            gpbItem.Controls.Add(txtPreco);
            gpbItem.Controls.Add(txtQuantidade);
            gpbItem.Controls.Add(lblQuantidade);
            gpbItem.Controls.Add(lblPreco);
            gpbItem.Controls.Add(lblProduto);
            gpbItem.Location = new Point(232, 31);
            gpbItem.Name = "gpbItem";
            gpbItem.Size = new Size(246, 251);
            gpbItem.TabIndex = 4;
            gpbItem.TabStop = false;
            gpbItem.Text = "Adicionar item";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(161, 218);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 36;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // txtDesconto
            // 
            txtDesconto.Font = new Font("Segoe UI", 9.75F);
            txtDesconto.Location = new Point(96, 117);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(140, 25);
            txtDesconto.TabIndex = 35;
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Font = new Font("Segoe UI", 9.75F);
            lblDesconto.Location = new Point(13, 120);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(66, 17);
            lblDesconto.TabIndex = 34;
            lblDesconto.Text = "Desconto:";
            // 
            // cmdCatergoria
            // 
            cmdCatergoria.Font = new Font("Segoe UI", 9.75F);
            cmdCatergoria.FormattingEnabled = true;
            cmdCatergoria.Location = new Point(76, 166);
            cmdCatergoria.Name = "cmdCatergoria";
            cmdCatergoria.Size = new Size(160, 25);
            cmdCatergoria.TabIndex = 33;
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Segoe UI", 9.75F);
            txtPreco.Location = new Point(76, 68);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(160, 25);
            txtPreco.TabIndex = 32;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Segoe UI", 9.75F);
            txtQuantidade.Location = new Point(108, 22);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(128, 25);
            txtQuantidade.TabIndex = 31;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI", 9.75F);
            lblQuantidade.Location = new Point(14, 25);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(79, 17);
            lblQuantidade.TabIndex = 30;
            lblQuantidade.Text = "Quantidade:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 9.75F);
            lblPreco.Location = new Point(14, 71);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(44, 17);
            lblPreco.TabIndex = 29;
            lblPreco.Text = "Preco:";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI", 9.75F);
            lblProduto.Location = new Point(13, 169);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(55, 17);
            lblProduto.TabIndex = 28;
            lblProduto.Text = "Produto";
            // 
            // NovaVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 339);
            Controls.Add(panel1);
            Name = "NovaVenda";
            Text = "NovaVenda";
            Load += NovaVenda_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gpbItem.ResumeLayout(false);
            gpbItem.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblNomeCliente;
        private Button btnSalvarCompr;
        private ListBox lsbItens;
        private Label lblTotal;
        private Label lblTotalCompra;
        private GroupBox gpbItem;
        private Button btnAdicionar;
        private TextBox txtDesconto;
        private Label lblDesconto;
        private ComboBox cmdCatergoria;
        private TextBox txtPreco;
        private TextBox txtQuantidade;
        private Label lblQuantidade;
        private Label lblPreco;
        private Label lblProduto;
    }
}