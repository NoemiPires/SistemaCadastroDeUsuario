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
            lblEmail = new Label();
            lblAlertaEmailInvalido = new Label();
            lblAlertaClienteCadastrado = new Label();
            btnCadastrar = new Button();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            lblCpf = new Label();
            lblNome = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblAlertaEmailInvalido);
            panel1.Controls.Add(lblAlertaClienteCadastrado);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(txtCpf);
            panel1.Controls.Add(lblCpf);
            panel1.Controls.Add(lblNome);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 215);
            panel1.TabIndex = 0;
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
            lblAlertaEmailInvalido.Text = "Email Inválido";
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
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 9.75F);
            txtCpf.Location = new Point(77, 121);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(270, 25);
            txtCpf.TabIndex = 28;
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
            // txtEmail
            // 
            txtEmail.Location = new Point(77, 67);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(135, 23);
            txtEmail.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 158);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 38;
            label1.Text = "label1";
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
        private TextBox txtCpf;
        private Label lblCpf;
        private Label lblNome;
        private Label lblAlertaEmailInvalido;
        private Label lblEmail;
        private Label label1;
        private TextBox txtEmail;
    }
}