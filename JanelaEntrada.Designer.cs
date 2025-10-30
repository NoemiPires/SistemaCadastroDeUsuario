namespace SistemaCadastroDeUsuario
{
    partial class JanelaEntrada
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblAlerta = new Label();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            lblSenha = new Label();
            lblNome = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblAlerta);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(lblSenha);
            panel1.Controls.Add(lblNome);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 118);
            panel1.TabIndex = 0;
            // 
            // lblAlerta
            // 
            lblAlerta.AutoSize = true;
            lblAlerta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlerta.ForeColor = Color.Red;
            lblAlerta.Location = new Point(22, 87);
            lblAlerta.Name = "lblAlerta";
            lblAlerta.Size = new Size(157, 17);
            lblAlerta.TabIndex = 6;
            lblAlerta.Text = "Falha na Autentificação!";
            lblAlerta.Visible = false;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(201, 201, 235);
            btnEntrar.Location = new Point(278, 80);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(64, 44);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '•';
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(64, 6);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(289, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += txbNome_TextChanged;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(15, 52);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha:";
            lblSenha.Click += label1_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(15, 14);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(50, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Usuário:";
            // 
            // JanelaEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(392, 142);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "JanelaEntrada";
            Text = "Janela de Entrada";
            FormClosed += JanelaEntrada_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblNome;
        private Label lblSenha;
        private Button btnEntrar;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label lblAlerta;
    }
}
