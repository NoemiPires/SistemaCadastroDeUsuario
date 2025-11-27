namespace SistemaCadastroDeUsuario
{
    partial class CadastroUsuario
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
            pnlCadastroUsuario = new Panel();
            mskTelefone = new MaskedTextBox();
            btnSalvar = new Button();
            lblCamposObrigatorios = new Label();
            lblUsuarioEmUso = new Label();
            lblCadastroEfetuado = new Label();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            lblSenha = new Label();
            lblUsuario = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            lblNome = new Label();
            pnlCadastroUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCadastroUsuario
            // 
            pnlCadastroUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCadastroUsuario.Controls.Add(mskTelefone);
            pnlCadastroUsuario.Controls.Add(btnSalvar);
            pnlCadastroUsuario.Controls.Add(lblCamposObrigatorios);
            pnlCadastroUsuario.Controls.Add(lblUsuarioEmUso);
            pnlCadastroUsuario.Controls.Add(lblCadastroEfetuado);
            pnlCadastroUsuario.Controls.Add(txtSenha);
            pnlCadastroUsuario.Controls.Add(txtUsuario);
            pnlCadastroUsuario.Controls.Add(txtEmail);
            pnlCadastroUsuario.Controls.Add(txtNome);
            pnlCadastroUsuario.Controls.Add(lblSenha);
            pnlCadastroUsuario.Controls.Add(lblUsuario);
            pnlCadastroUsuario.Controls.Add(lblTelefone);
            pnlCadastroUsuario.Controls.Add(lblEmail);
            pnlCadastroUsuario.Controls.Add(lblNome);
            pnlCadastroUsuario.Location = new Point(12, 12);
            pnlCadastroUsuario.Name = "pnlCadastroUsuario";
            pnlCadastroUsuario.Size = new Size(258, 277);
            pnlCadastroUsuario.TabIndex = 0;
            // 
            // mskTelefone
            // 
            mskTelefone.Location = new Point(78, 69);
            mskTelefone.Mask = "(00) 00000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(100, 23);
            mskTelefone.TabIndex = 15;
            mskTelefone.MaskChanged += mskTelefone_MaskChanged;
            mskTelefone.KeyUp += mskTelefone_KeyUp;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(13, 241);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblCamposObrigatorios
            // 
            lblCamposObrigatorios.AutoSize = true;
            lblCamposObrigatorios.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCamposObrigatorios.ForeColor = Color.IndianRed;
            lblCamposObrigatorios.Location = new Point(13, 165);
            lblCamposObrigatorios.Name = "lblCamposObrigatorios";
            lblCamposObrigatorios.Size = new Size(208, 12);
            lblCamposObrigatorios.TabIndex = 13;
            lblCamposObrigatorios.Text = "Obrigatorio preenchimento dos campos acima.";
            // 
            // lblUsuarioEmUso
            // 
            lblUsuarioEmUso.AutoSize = true;
            lblUsuarioEmUso.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioEmUso.ForeColor = Color.IndianRed;
            lblUsuarioEmUso.Location = new Point(13, 124);
            lblUsuarioEmUso.Name = "lblUsuarioEmUso";
            lblUsuarioEmUso.Size = new Size(186, 12);
            lblUsuarioEmUso.TabIndex = 12;
            lblUsuarioEmUso.Text = "O nome de úsuario já esta sendo utilizado.";
            // 
            // lblCadastroEfetuado
            // 
            lblCadastroEfetuado.AutoSize = true;
            lblCadastroEfetuado.BackColor = Color.Olive;
            lblCadastroEfetuado.ForeColor = SystemColors.ActiveCaptionText;
            lblCadastroEfetuado.Location = new Point(117, 241);
            lblCadastroEfetuado.Name = "lblCadastroEfetuado";
            lblCadastroEfetuado.Size = new Size(104, 15);
            lblCadastroEfetuado.TabIndex = 11;
            lblCadastroEfetuado.Text = "Cadastro Efetuado";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(77, 142);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '•';
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 10;
            txtSenha.TextChanged += txtSenha_TextChanged;
            txtSenha.KeyUp += txtSenha_KeyUp;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(78, 98);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(167, 23);
            txtUsuario.TabIndex = 9;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            txtUsuario.KeyUp += txtUsuario_KeyUp;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(78, 40);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(167, 23);
            txtEmail.TabIndex = 7;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.KeyUp += txtEmail_KeyUp;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(78, 11);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(166, 23);
            txtNome.TabIndex = 6;
            txtNome.TextChanged += txtNome_TextChanged;
            txtNome.KeyUp += txtNome_KeyUp;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(13, 150);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(13, 106);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(13, 77);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(13, 48);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-Mail:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(13, 19);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 301);
            Controls.Add(pnlCadastroUsuario);
            Name = "CadastroUsuario";
            Text = "CadastroUsuario";
            pnlCadastroUsuario.ResumeLayout(false);
            pnlCadastroUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCadastroUsuario;
        private Label lblEmail;
        private Label lblNome;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Label lblSenha;
        private Label lblUsuario;
        private Label lblTelefone;
        private Label lblCadastroEfetuado;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label lblCamposObrigatorios;
        private Label lblUsuarioEmUso;
        private Button btnSalvar;
        private MaskedTextBox mskTelefone;
    }
}