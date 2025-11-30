namespace SistemaCadastroDeUsuario
{
    partial class CadastrarCliente
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
            lblAlertaCpfInvalido = new Label();
            mskCpf = new MaskedTextBox();
            lblAlertaCamposObrigatorios = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblAlertaEmailInvalido = new Label();
            lblAlertaClienteCadastrado = new Label();
            btnCadastrar = new Button();
            txtNome = new TextBox();
            lblCpf = new Label();
            lblNome = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblAlertaCpfInvalido);
            panel1.Controls.Add(mskCpf);
            panel1.Controls.Add(lblAlertaCamposObrigatorios);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblAlertaEmailInvalido);
            panel1.Controls.Add(lblAlertaClienteCadastrado);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(lblCpf);
            panel1.Controls.Add(lblNome);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 215);
            panel1.TabIndex = 0;
            // 
            // lblAlertaCpfInvalido
            // 
            lblAlertaCpfInvalido.AutoSize = true;
            lblAlertaCpfInvalido.BackColor = Color.FromArgb(255, 128, 255);
            lblAlertaCpfInvalido.Location = new Point(195, 131);
            lblAlertaCpfInvalido.Name = "lblAlertaCpfInvalido";
            lblAlertaCpfInvalido.Size = new Size(71, 15);
            lblAlertaCpfInvalido.TabIndex = 40;
            lblAlertaCpfInvalido.Text = "Cpf inválido";
            // 
            // mskCpf
            // 
            mskCpf.Location = new Point(77, 123);
            mskCpf.Mask = "000\\.000\\.000-00";
            mskCpf.Name = "mskCpf";
            mskCpf.Size = new Size(100, 23);
            mskCpf.TabIndex = 39;
            mskCpf.TextChanged += mskCpf_TextChanged;
            mskCpf.KeyUp += mskCpf_KeyUp;
            // 
            // lblAlertaCamposObrigatorios
            // 
            lblAlertaCamposObrigatorios.AutoSize = true;
            lblAlertaCamposObrigatorios.BackColor = Color.FromArgb(255, 128, 255);
            lblAlertaCamposObrigatorios.Location = new Point(13, 191);
            lblAlertaCamposObrigatorios.Name = "lblAlertaCamposObrigatorios";
            lblAlertaCamposObrigatorios.Size = new Size(118, 15);
            lblAlertaCamposObrigatorios.TabIndex = 38;
            lblAlertaCamposObrigatorios.Text = "Campos obrigatórios";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(77, 67);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(189, 23);
            txtEmail.TabIndex = 37;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.KeyUp += txtEmail_KeyUp;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 75);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 36;
            lblEmail.Text = "Email:";
            // 
            // lblAlertaEmailInvalido
            // 
            lblAlertaEmailInvalido.AutoSize = true;
            lblAlertaEmailInvalido.BackColor = Color.FromArgb(255, 128, 255);
            lblAlertaEmailInvalido.Location = new Point(272, 75);
            lblAlertaEmailInvalido.Name = "lblAlertaEmailInvalido";
            lblAlertaEmailInvalido.Size = new Size(81, 15);
            lblAlertaEmailInvalido.TabIndex = 35;
            lblAlertaEmailInvalido.Text = "Email inválido";
            // 
            // lblAlertaClienteCadastrado
            // 
            lblAlertaClienteCadastrado.AutoSize = true;
            lblAlertaClienteCadastrado.BackColor = Color.FromArgb(128, 255, 128);
            lblAlertaClienteCadastrado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlertaClienteCadastrado.Location = new Point(12, 189);
            lblAlertaClienteCadastrado.Name = "lblAlertaClienteCadastrado";
            lblAlertaClienteCadastrado.Size = new Size(119, 17);
            lblAlertaClienteCadastrado.TabIndex = 34;
            lblAlertaClienteCadastrado.Text = "Cliente Cadastrado";
            lblAlertaClienteCadastrado.Visible = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(272, 183);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(92, 29);
            btnCadastrar.TabIndex = 33;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 9.75F);
            txtNome.Location = new Point(77, 15);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(270, 25);
            txtNome.TabIndex = 29;
            txtNome.TextChanged += txtNome_TextChanged;
            txtNome.KeyUp += txtNome_KeyUp;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI", 9.75F);
            lblCpf.Location = new Point(12, 129);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(32, 17);
            lblCpf.TabIndex = 27;
            lblCpf.Text = "CPF:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9.75F);
            lblNome.Location = new Point(12, 15);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(47, 17);
            lblNome.TabIndex = 24;
            lblNome.Text = "Nome:";
            // 
            // CadastrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 239);
            Controls.Add(panel1);
            Name = "CadastrarCliente";
            Text = "CadastrarCliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblAlertaClienteCadastrado;
        private Button btnCadastrar;
        private TextBox txtNome;
        private Label lblCpf;
        private Label lblNome;
        private Label lblAlertaEmailInvalido;
        private Label lblEmail;
        private Label lblAlertaCamposObrigatorios;
        private TextBox txtEmail;
        private MaskedTextBox mskCpf;
        private Label lblAlertaCpfInvalido;
    }
}