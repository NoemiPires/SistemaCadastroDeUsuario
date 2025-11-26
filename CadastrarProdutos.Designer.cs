namespace SistemaCadastroDeUsuario
{
    partial class CadastrarProdutos
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
            lblaprodutoCadastrado = new Label();
            btnCadastrar = new Button();
            ckhAtivo = new CheckBox();
            cmdCatergoria = new ComboBox();
            txtEstoque = new TextBox();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            lblPreco = new Label();
            lblEstoque = new Label();
            lblCategoria = new Label();
            lblNome = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblaprodutoCadastrado);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(ckhAtivo);
            panel1.Controls.Add(cmdCatergoria);
            panel1.Controls.Add(txtEstoque);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(txtPreco);
            panel1.Controls.Add(lblPreco);
            panel1.Controls.Add(lblEstoque);
            panel1.Controls.Add(lblCategoria);
            panel1.Controls.Add(lblNome);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 232);
            panel1.TabIndex = 0;
            // 
            // lblaprodutoCadastrado
            // 
            lblaprodutoCadastrado.AutoSize = true;
            lblaprodutoCadastrado.BackColor = Color.FromArgb(192, 192, 255);
            lblaprodutoCadastrado.Location = new Point(77, 202);
            lblaprodutoCadastrado.Name = "lblaprodutoCadastrado";
            lblaprodutoCadastrado.Size = new Size(113, 15);
            lblaprodutoCadastrado.TabIndex = 12;
            lblaprodutoCadastrado.Text = "Produto Cadastrado";
            lblaprodutoCadastrado.Visible = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(255, 191);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(92, 29);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // ckhAtivo
            // 
            ckhAtivo.AutoSize = true;
            ckhAtivo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckhAtivo.Location = new Point(15, 199);
            ckhAtivo.Name = "ckhAtivo";
            ckhAtivo.Size = new Size(56, 21);
            ckhAtivo.TabIndex = 10;
            ckhAtivo.Text = "Ativo";
            ckhAtivo.UseVisualStyleBackColor = true;
            // 
            // cmdCatergoria
            // 
            cmdCatergoria.Font = new Font("Segoe UI", 9.75F);
            cmdCatergoria.FormattingEnabled = true;
            cmdCatergoria.Location = new Point(77, 158);
            cmdCatergoria.Name = "cmdCatergoria";
            cmdCatergoria.Size = new Size(270, 25);
            cmdCatergoria.TabIndex = 9;
            cmdCatergoria.SelectedIndexChanged += cmbCatergoria_SelectedIndexChanged;
            // 
            // txtEstoque
            // 
            txtEstoque.Font = new Font("Segoe UI", 9.75F);
            txtEstoque.Location = new Point(77, 110);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(270, 25);
            txtEstoque.TabIndex = 8;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 9.75F);
            txtNome.Location = new Point(77, 13);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(270, 25);
            txtNome.TabIndex = 7;
            txtNome.KeyUp += txtNome_KeyUp;
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Segoe UI", 9.75F);
            txtPreco.Location = new Point(77, 59);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(270, 25);
            txtPreco.TabIndex = 6;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 9.75F);
            lblPreco.Location = new Point(30, 62);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(41, 17);
            lblPreco.TabIndex = 4;
            lblPreco.Text = "Preco";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Segoe UI", 9.75F);
            lblEstoque.Location = new Point(16, 113);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(55, 17);
            lblEstoque.TabIndex = 3;
            lblEstoque.Text = "Estoque";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9.75F);
            lblCategoria.Location = new Point(6, 161);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(65, 17);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9.75F);
            lblNome.Location = new Point(30, 16);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(44, 17);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // CadastrarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 256);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastrarProdutos";
            Text = "CadastrarProdutos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblNome;
        private Label lblPreco;
        private Label lblEstoque;
        private Label lblCategoria;
        private TextBox txtEstoque;
        private TextBox txtNome;
        private TextBox txtPreco;
        private Button btnCadastrar;
        private CheckBox ckhAtivo;
        private ComboBox cmdCatergoria;
        private Label lblaprodutoCadastrado;
    }
}