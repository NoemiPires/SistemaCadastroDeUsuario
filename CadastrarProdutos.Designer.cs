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
            txtQuantidade = new TextBox();
            lblQuantidade = new Label();
            lblEstoque = new Label();
            lblNome = new Label();
            lblPreco = new Label();
            txtPreco = new TextBox();
            btnCategoria = new Button();
            grpCategoria = new GroupBox();
            lblAlertaPreco = new Label();
            panel1.SuspendLayout();
            grpCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblAlertaPreco);
            panel1.Controls.Add(grpCategoria);
            panel1.Controls.Add(btnCategoria);
            panel1.Controls.Add(txtPreco);
            panel1.Controls.Add(lblPreco);
            panel1.Controls.Add(lblaprodutoCadastrado);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(ckhAtivo);
            panel1.Controls.Add(txtEstoque);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(txtQuantidade);
            panel1.Controls.Add(lblQuantidade);
            panel1.Controls.Add(lblEstoque);
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
            lblaprodutoCadastrado.Location = new Point(91, 207);
            lblaprodutoCadastrado.Name = "lblaprodutoCadastrado";
            lblaprodutoCadastrado.Size = new Size(113, 15);
            lblaprodutoCadastrado.TabIndex = 12;
            lblaprodutoCadastrado.Text = "Produto Cadastrado";
            lblaprodutoCadastrado.Visible = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(260, 199);
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
            cmdCatergoria.Location = new Point(8, 15);
            cmdCatergoria.Name = "cmdCatergoria";
            cmdCatergoria.Size = new Size(270, 25);
            cmdCatergoria.TabIndex = 9;
            cmdCatergoria.SelectedIndexChanged += cmbCatergoria_SelectedIndexChanged;
            // 
            // txtEstoque
            // 
            txtEstoque.Font = new Font("Segoe UI", 9.75F);
            txtEstoque.Location = new Point(257, 41);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(46, 25);
            txtEstoque.TabIndex = 8;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 9.75F);
            txtNome.Location = new Point(69, 5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(270, 25);
            txtNome.TabIndex = 7;
            txtNome.KeyUp += txtNome_KeyUp;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Segoe UI", 9.75F);
            txtQuantidade.Location = new Point(101, 41);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(46, 25);
            txtQuantidade.TabIndex = 6;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI", 9.75F);
            lblQuantidade.Location = new Point(16, 49);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(79, 17);
            lblQuantidade.TabIndex = 4;
            lblQuantidade.Text = "Quantidade:";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Segoe UI", 9.75F);
            lblEstoque.Location = new Point(196, 49);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(55, 17);
            lblEstoque.TabIndex = 3;
            lblEstoque.Text = "Estoque";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9.75F);
            lblNome.Location = new Point(16, 13);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(47, 17);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPreco.Location = new Point(16, 82);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(40, 15);
            lblPreco.TabIndex = 13;
            lblPreco.Text = "Preço:";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(62, 74);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 14;
            // 
            // btnCategoria
            // 
            btnCategoria.Location = new Point(209, 110);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(143, 28);
            btnCategoria.TabIndex = 15;
            btnCategoria.Text = "Adicionar Categoria";
            btnCategoria.UseVisualStyleBackColor = true;
            // 
            // grpCategoria
            // 
            grpCategoria.Controls.Add(cmdCatergoria);
            grpCategoria.Location = new Point(15, 144);
            grpCategoria.Name = "grpCategoria";
            grpCategoria.Size = new Size(284, 49);
            grpCategoria.TabIndex = 16;
            grpCategoria.TabStop = false;
            grpCategoria.Text = "CATEGORIA:";
            // 
            // lblAlertaPreco
            // 
            lblAlertaPreco.AutoSize = true;
            lblAlertaPreco.BackColor = Color.FromArgb(255, 128, 255);
            lblAlertaPreco.Location = new Point(176, 82);
            lblAlertaPreco.Name = "lblAlertaPreco";
            lblAlertaPreco.Size = new Size(117, 15);
            lblAlertaPreco.TabIndex = 17;
            lblAlertaPreco.Text = "Preço não pode ser 0";
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
            grpCategoria.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblNome;
        private Label lblQuantidade;
        private Label lblEstoque;
        private TextBox txtEstoque;
        private TextBox txtNome;
        private TextBox txtQuantidade;
        private Button btnCadastrar;
        private CheckBox ckhAtivo;
        private ComboBox cmdCatergoria;
        private Label lblaprodutoCadastrado;
        private Label lblPreco;
        private Button btnCategoria;
        private TextBox txtPreco;
        private GroupBox grpCategoria;
        private Label lblAlertaPreco;
    }
}