namespace SistemaCadastroDeUsuario
{
    partial class CadastroCliente
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
            btnSalvar = new Button();
            lblAlertaCliente = new Label();
            lblAlertaEmail = new Label();
            lblAlertaVazio = new Label();
            lblAlertaSucesso = new Label();
            txtEmail = new TextBox();
            mskCpf = new MaskedTextBox();
            txtNome = new TextBox();
            lblEmailText = new Label();
            lblCpfText = new Label();
            lblNomeText = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnSalvar);
            panel1.Controls.Add(lblAlertaCliente);
            panel1.Controls.Add(lblAlertaEmail);
            panel1.Controls.Add(lblAlertaVazio);
            panel1.Controls.Add(lblAlertaSucesso);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(mskCpf);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(lblEmailText);
            panel1.Controls.Add(lblCpfText);
            panel1.Controls.Add(lblNomeText);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 216);
            panel1.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(128, 255, 128);
            btnSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(151, 163);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Cadastrar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // lblAlertaCliente
            // 
            lblAlertaCliente.AutoSize = true;
            lblAlertaCliente.BackColor = Color.FromArgb(255, 128, 255);
            lblAlertaCliente.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlertaCliente.Location = new Point(159, 97);
            lblAlertaCliente.Name = "lblAlertaCliente";
            lblAlertaCliente.Size = new Size(51, 12);
            lblAlertaCliente.TabIndex = 9;
            lblAlertaCliente.Text = "Cpf inválido";
            // 
            // lblAlertaEmail
            // 
            lblAlertaEmail.AutoSize = true;
            lblAlertaEmail.BackColor = Color.FromArgb(255, 128, 255);
            lblAlertaEmail.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlertaEmail.Location = new Point(167, 55);
            lblAlertaEmail.Name = "lblAlertaEmail";
            lblAlertaEmail.Size = new Size(59, 12);
            lblAlertaEmail.TabIndex = 8;
            lblAlertaEmail.Text = "Email inválido";
            // 
            // lblAlertaVazio
            // 
            lblAlertaVazio.AutoSize = true;
            lblAlertaVazio.BackColor = Color.FromArgb(255, 128, 255);
            lblAlertaVazio.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlertaVazio.Location = new Point(19, 126);
            lblAlertaVazio.Name = "lblAlertaVazio";
            lblAlertaVazio.Size = new Size(87, 12);
            lblAlertaVazio.TabIndex = 7;
            lblAlertaVazio.Text = "Campos obrigatórios";
            // 
            // lblAlertaSucesso
            // 
            lblAlertaSucesso.AutoSize = true;
            lblAlertaSucesso.BackColor = Color.FromArgb(128, 255, 128);
            lblAlertaSucesso.Location = new Point(19, 191);
            lblAlertaSucesso.Name = "lblAlertaSucesso";
            lblAlertaSucesso.Size = new Size(107, 15);
            lblAlertaSucesso.TabIndex = 6;
            lblAlertaSucesso.Text = "Cliente Cadastrado";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(61, 44);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 5;
            // 
            // mskCpf
            // 
            mskCpf.Location = new Point(53, 87);
            mskCpf.Mask = "000\\.000\\.000-00";
            mskCpf.Name = "mskCpf";
            mskCpf.Size = new Size(100, 23);
            mskCpf.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(65, 3);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 3;
            // 
            // lblEmailText
            // 
            lblEmailText.AutoSize = true;
            lblEmailText.Location = new Point(16, 52);
            lblEmailText.Name = "lblEmailText";
            lblEmailText.Size = new Size(39, 15);
            lblEmailText.TabIndex = 2;
            lblEmailText.Text = "Email:";
            // 
            // lblCpfText
            // 
            lblCpfText.AutoSize = true;
            lblCpfText.Location = new Point(16, 95);
            lblCpfText.Name = "lblCpfText";
            lblCpfText.Size = new Size(31, 15);
            lblCpfText.TabIndex = 1;
            lblCpfText.Text = "CPF:";
            // 
            // lblNomeText
            // 
            lblNomeText.AutoSize = true;
            lblNomeText.Location = new Point(16, 11);
            lblNomeText.Name = "lblNomeText";
            lblNomeText.Size = new Size(43, 15);
            lblNomeText.TabIndex = 0;
            lblNomeText.Text = "Nome:";
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 240);
            Controls.Add(panel1);
            Name = "CadastroCliente";
            Text = "CadastroCliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtNome;
        private Label lblEmailText;
        private Label lblCpfText;
        private Label lblNomeText;
        private TextBox txtEmail;
        private MaskedTextBox mskCpf;
        private Label lblAlertaSucesso;
        private Label lblAlertaVazio;
        private Label lblAlertaEmail;
        private Label lblAlertaCliente;
        private Button btnSalvar;
    }
}