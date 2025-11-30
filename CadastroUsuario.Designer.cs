namespace Trabalho
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
            panel1 = new Panel();
            lblAlertaEmail = new Label();
            grpPerfil = new GroupBox();
            radGerente = new RadioButton();
            radOperadorCaixa = new RadioButton();
            radVendedor = new RadioButton();
            lblAlertaSucesso = new Label();
            lblAlertaVazio = new Label();
            lblAlertaUsuario = new Label();
            mskTelefone = new MaskedTextBox();
            lblTelefone = new Label();
            btnSalvar = new Button();
            lblSenha = new Label();
            lblUsuario = new Label();
            lblEmail = new Label();
            lblNome = new Label();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            panel1.SuspendLayout();
            grpPerfil.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblAlertaEmail);
            panel1.Controls.Add(grpPerfil);
            panel1.Controls.Add(lblAlertaSucesso);
            panel1.Controls.Add(lblAlertaVazio);
            panel1.Controls.Add(lblAlertaUsuario);
            panel1.Controls.Add(mskTelefone);
            panel1.Controls.Add(lblTelefone);
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(lblSenha);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtNome);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 289);
            panel1.TabIndex = 0;
            // 
            // lblAlertaEmail
            // 
            lblAlertaEmail.AutoSize = true;
            lblAlertaEmail.BackColor = Color.FromArgb(255, 255, 128);
            lblAlertaEmail.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAlertaEmail.ForeColor = Color.Red;
            lblAlertaEmail.Location = new Point(5, 258);
            lblAlertaEmail.Name = "lblAlertaEmail";
            lblAlertaEmail.Size = new Size(99, 17);
            lblAlertaEmail.TabIndex = 20;
            lblAlertaEmail.Text = "Email inválido";
            lblAlertaEmail.Visible = false;
            // 
            // grpPerfil
            // 
            grpPerfil.Controls.Add(radGerente);
            grpPerfil.Controls.Add(radOperadorCaixa);
            grpPerfil.Controls.Add(radVendedor);
            grpPerfil.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpPerfil.Location = new Point(11, 178);
            grpPerfil.Name = "grpPerfil";
            grpPerfil.Size = new Size(338, 52);
            grpPerfil.TabIndex = 19;
            grpPerfil.TabStop = false;
            grpPerfil.Text = "Perfil:";
            // 
            // radGerente
            // 
            radGerente.AutoSize = true;
            radGerente.Location = new Point(6, 22);
            radGerente.Name = "radGerente";
            radGerente.Size = new Size(72, 21);
            radGerente.TabIndex = 16;
            radGerente.TabStop = true;
            radGerente.Text = "Gerente";
            radGerente.UseVisualStyleBackColor = true;
            // 
            // radOperadorCaixa
            // 
            radOperadorCaixa.AutoSize = true;
            radOperadorCaixa.Location = new Point(194, 22);
            radOperadorCaixa.Name = "radOperadorCaixa";
            radOperadorCaixa.Size = new Size(138, 21);
            radOperadorCaixa.TabIndex = 18;
            radOperadorCaixa.TabStop = true;
            radOperadorCaixa.Text = "Operador de Caixa";
            radOperadorCaixa.UseVisualStyleBackColor = true;
            // 
            // radVendedor
            // 
            radVendedor.AutoSize = true;
            radVendedor.Location = new Point(99, 22);
            radVendedor.Name = "radVendedor";
            radVendedor.Size = new Size(83, 21);
            radVendedor.TabIndex = 17;
            radVendedor.TabStop = true;
            radVendedor.Text = "Vendedor";
            radVendedor.UseVisualStyleBackColor = true;
            // 
            // lblAlertaSucesso
            // 
            lblAlertaSucesso.AutoSize = true;
            lblAlertaSucesso.BackColor = Color.Blue;
            lblAlertaSucesso.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAlertaSucesso.ForeColor = Color.GreenYellow;
            lblAlertaSucesso.Location = new Point(8, 258);
            lblAlertaSucesso.Name = "lblAlertaSucesso";
            lblAlertaSucesso.Size = new Size(124, 17);
            lblAlertaSucesso.TabIndex = 15;
            lblAlertaSucesso.Text = "Salvo com sucesso";
            lblAlertaSucesso.Visible = false;
            // 
            // lblAlertaVazio
            // 
            lblAlertaVazio.AutoSize = true;
            lblAlertaVazio.BackColor = Color.FromArgb(255, 255, 128);
            lblAlertaVazio.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAlertaVazio.ForeColor = Color.Red;
            lblAlertaVazio.Location = new Point(8, 258);
            lblAlertaVazio.Name = "lblAlertaVazio";
            lblAlertaVazio.Size = new Size(185, 17);
            lblAlertaVazio.TabIndex = 14;
            lblAlertaVazio.Text = "Os campos são obrigatórios";
            lblAlertaVazio.Visible = false;
            // 
            // lblAlertaUsuario
            // 
            lblAlertaUsuario.AutoSize = true;
            lblAlertaUsuario.BackColor = Color.FromArgb(255, 255, 128);
            lblAlertaUsuario.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAlertaUsuario.ForeColor = Color.Red;
            lblAlertaUsuario.Location = new Point(5, 258);
            lblAlertaUsuario.Name = "lblAlertaUsuario";
            lblAlertaUsuario.Size = new Size(166, 17);
            lblAlertaUsuario.TabIndex = 13;
            lblAlertaUsuario.Text = "Nome de usuário em uso";
            lblAlertaUsuario.Visible = false;
            // 
            // mskTelefone
            // 
            mskTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskTelefone.Location = new Point(94, 73);
            mskTelefone.Mask = "(00) 00000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(132, 29);
            mskTelefone.TabIndex = 12;
            mskTelefone.TextChanged += mskTelefone_TextChanged;
            mskTelefone.KeyUp += mskTelefone_KeyUp;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(8, 76);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(70, 21);
            lblTelefone.TabIndex = 11;
            lblTelefone.Text = "Telefone:";
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSize = true;
            btnSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(274, 251);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 31);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(22, 146);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(56, 21);
            lblSenha.TabIndex = 8;
            lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(11, 111);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(67, 21);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "Usuário:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(27, 41);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 21);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(22, 6);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(56, 21);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome:";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(94, 143);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '•';
            txtSenha.Size = new Size(199, 29);
            txtSenha.TabIndex = 1;
            txtSenha.TextChanged += txtSenha_TextChanged;
            txtSenha.KeyUp += txtSenha_KeyUp;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(94, 108);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(199, 29);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            txtUsuario.KeyUp += txtUsuario_KeyUp;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(94, 38);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(256, 29);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.KeyUp += txtEmail_KeyUp;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(94, 3);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(256, 29);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            txtNome.KeyUp += txtNome_KeyUp;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 313);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroUsuario";
            FormClosed += CadastroUsuario_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpPerfil.ResumeLayout(false);
            grpPerfil.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Label lblSenha;
        private Label lblUsuario;
        private Label lblEmail;
        private Label lblNome;
        private Button btnSalvar;
        private Label lblTelefone;
        private MaskedTextBox mskTelefone;
        private Label lblAlertaUsuario;
        private Label lblAlertaVazio;
        private Label lblAlertaSucesso;
        private RadioButton radOperadorCaixa;
        private RadioButton radVendedor;
        private RadioButton radGerente;
        private GroupBox grpPerfil;
        private Label lblAlertaEmail;
    }
}