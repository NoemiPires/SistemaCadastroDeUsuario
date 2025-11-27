namespace SistemaCadastroDeUsuario
{
    partial class Itens
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
            cmdCatergoria = new ComboBox();
            txtPreco = new TextBox();
            txtQuantidade = new TextBox();
            lblQuantidade = new Label();
            lblPreco = new Label();
            lblProduto = new Label();
            txtDesconto = new TextBox();
            lblDesconto = new Label();
            btnAdicionar = new Button();
            SuspendLayout();
            // 
            // cmdCatergoria
            // 
            cmdCatergoria.Font = new Font("Segoe UI", 9.75F);
            cmdCatergoria.FormattingEnabled = true;
            cmdCatergoria.Location = new Point(75, 161);
            cmdCatergoria.Name = "cmdCatergoria";
            cmdCatergoria.Size = new Size(160, 25);
            cmdCatergoria.TabIndex = 15;
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Segoe UI", 9.75F);
            txtPreco.Location = new Point(75, 63);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(160, 25);
            txtPreco.TabIndex = 14;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Segoe UI", 9.75F);
            txtQuantidade.Location = new Point(107, 17);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(128, 25);
            txtQuantidade.TabIndex = 13;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI", 9.75F);
            lblQuantidade.Location = new Point(13, 20);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(79, 17);
            lblQuantidade.TabIndex = 12;
            lblQuantidade.Text = "Quantidade:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 9.75F);
            lblPreco.Location = new Point(13, 66);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(44, 17);
            lblPreco.TabIndex = 11;
            lblPreco.Text = "Preco:";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI", 9.75F);
            lblProduto.Location = new Point(12, 164);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(55, 17);
            lblProduto.TabIndex = 10;
            lblProduto.Text = "Produto";
            // 
            // txtDesconto
            // 
            txtDesconto.Font = new Font("Segoe UI", 9.75F);
            txtDesconto.Location = new Point(95, 112);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(140, 25);
            txtDesconto.TabIndex = 17;
            // 
            // lblDesconto
            // 
            lblDesconto.AutoSize = true;
            lblDesconto.Font = new Font("Segoe UI", 9.75F);
            lblDesconto.Location = new Point(12, 115);
            lblDesconto.Name = "lblDesconto";
            lblDesconto.Size = new Size(66, 17);
            lblDesconto.TabIndex = 16;
            lblDesconto.Text = "Desconto:";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(160, 213);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 18;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // Itens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 247);
            Controls.Add(btnAdicionar);
            Controls.Add(txtDesconto);
            Controls.Add(lblDesconto);
            Controls.Add(cmdCatergoria);
            Controls.Add(txtPreco);
            Controls.Add(txtQuantidade);
            Controls.Add(lblQuantidade);
            Controls.Add(lblPreco);
            Controls.Add(lblProduto);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Itens";
            Text = "Itens";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmdCatergoria;
        private TextBox txtPreco;
        private TextBox txtQuantidade;
        private Label lblQuantidade;
        private Label lblPreco;
        private Label lblProduto;
        private TextBox txtDesconto;
        private Label lblDesconto;
        private Button btnAdicionar;
    }
}