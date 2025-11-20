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
            btnCadastrar = new Button();
            ckbAtivo = new CheckBox();
            cmbCatergoria = new ComboBox();
            txtEstoque = new TextBox();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            txtId = new TextBox();
            lblPreco = new Label();
            lblEstoque = new Label();
            lblCategoria = new Label();
            lblNome = new Label();
            lblId = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(ckbAtivo);
            panel1.Controls.Add(cmbCatergoria);
            panel1.Controls.Add(txtEstoque);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(txtPreco);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(lblPreco);
            panel1.Controls.Add(lblEstoque);
            panel1.Controls.Add(lblCategoria);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(lblId);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(361, 274);
            panel1.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(259, 233);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(92, 29);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // ckbAtivo
            // 
            ckbAtivo.AutoSize = true;
            ckbAtivo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckbAtivo.Location = new Point(12, 237);
            ckbAtivo.Name = "ckbAtivo";
            ckbAtivo.Size = new Size(56, 21);
            ckbAtivo.TabIndex = 10;
            ckbAtivo.Text = "Ativo";
            ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // cmbCatergoria
            // 
            cmbCatergoria.Font = new Font("Segoe UI", 9.75F);
            cmbCatergoria.FormattingEnabled = true;
            cmbCatergoria.Location = new Point(81, 200);
            cmbCatergoria.Name = "cmbCatergoria";
            cmbCatergoria.Size = new Size(270, 25);
            cmbCatergoria.TabIndex = 9;
            cmbCatergoria.SelectedIndexChanged += cmbCatergoria_SelectedIndexChanged;
            // 
            // txtEstoque
            // 
            txtEstoque.Font = new Font("Segoe UI", 9.75F);
            txtEstoque.Location = new Point(81, 152);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(270, 25);
            txtEstoque.TabIndex = 8;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 9.75F);
            txtNome.Location = new Point(81, 55);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(270, 25);
            txtNome.TabIndex = 7;
            txtNome.KeyUp += txtNome_KeyUp;
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Segoe UI", 9.75F);
            txtPreco.Location = new Point(81, 101);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(270, 25);
            txtPreco.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 9.75F);
            txtId.Location = new Point(81, 13);
            txtId.Name = "txtId";
            txtId.Size = new Size(270, 25);
            txtId.TabIndex = 5;
            txtId.KeyUp += txtId_KeyUp;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 9.75F);
            lblPreco.Location = new Point(34, 104);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(41, 17);
            lblPreco.TabIndex = 4;
            lblPreco.Text = "Preco";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Segoe UI", 9.75F);
            lblEstoque.Location = new Point(20, 155);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(55, 17);
            lblEstoque.TabIndex = 3;
            lblEstoque.Text = "Estoque";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9.75F);
            lblCategoria.Location = new Point(10, 203);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(65, 17);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9.75F);
            lblNome.Location = new Point(34, 58);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(44, 17);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9.75F);
            lblId.ForeColor = Color.Black;
            lblId.Location = new Point(45, 16);
            lblId.Name = "lblId";
            lblId.Size = new Size(19, 17);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // CadastrarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 298);
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
        private Label lblId;
        private Label lblPreco;
        private Label lblEstoque;
        private Label lblCategoria;
        private TextBox txtEstoque;
        private TextBox txtNome;
        private TextBox txtPreco;
        private TextBox txtId;
        private Button btnCadastrar;
        private CheckBox ckbAtivo;
        private ComboBox cmbCatergoria;
    }
}