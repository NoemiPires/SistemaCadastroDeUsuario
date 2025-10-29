namespace SistemaCadastroDeUsuario
{
    partial class CadastrarNovosUsuarios
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
            pnlPrincipal = new Panel();
            lblNome = new Label();
            lblSenha = new Label();
            lblUsuario = new Label();
            lblRepetirSenha = new Label();
            txtNome = new TextBox();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            txtRepetirSenha = new TextBox();
            chkGerente = new CheckBox();
            btnSalvar = new Button();
            pnlPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipal.Controls.Add(btnSalvar);
            pnlPrincipal.Controls.Add(chkGerente);
            pnlPrincipal.Controls.Add(txtRepetirSenha);
            pnlPrincipal.Controls.Add(txtSenha);
            pnlPrincipal.Controls.Add(txtUsuario);
            pnlPrincipal.Controls.Add(txtNome);
            pnlPrincipal.Controls.Add(lblRepetirSenha);
            pnlPrincipal.Controls.Add(lblUsuario);
            pnlPrincipal.Controls.Add(lblSenha);
            pnlPrincipal.Controls.Add(lblNome);
            pnlPrincipal.Location = new Point(12, 12);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(565, 210);
            pnlPrincipal.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(68, 16);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 21);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(68, 102);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(53, 21);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(57, 61);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(64, 21);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // lblRepetirSenha
            // 
            lblRepetirSenha.AutoSize = true;
            lblRepetirSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRepetirSenha.Location = new Point(14, 144);
            lblRepetirSenha.Name = "lblRepetirSenha";
            lblRepetirSenha.Size = new Size(107, 21);
            lblRepetirSenha.TabIndex = 3;
            lblRepetirSenha.Text = "Repetir Senha";
            lblRepetirSenha.Click += label3_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(127, 13);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(353, 29);
            txtNome.TabIndex = 4;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(127, 58);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(239, 29);
            txtUsuario.TabIndex = 5;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(127, 99);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(239, 29);
            txtSenha.TabIndex = 6;
            // 
            // txtRepetirSenha
            // 
            txtRepetirSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRepetirSenha.Location = new Point(127, 141);
            txtRepetirSenha.Name = "txtRepetirSenha";
            txtRepetirSenha.Size = new Size(239, 29);
            txtRepetirSenha.TabIndex = 7;
            // 
            // chkGerente
            // 
            chkGerente.AutoSize = true;
            chkGerente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkGerente.Location = new Point(127, 176);
            chkGerente.Name = "chkGerente";
            chkGerente.Size = new Size(84, 25);
            chkGerente.TabIndex = 8;
            chkGerente.Text = "Gerente";
            chkGerente.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.GradientActiveCaption;
            btnSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = SystemColors.ActiveCaptionText;
            btnSalvar.Location = new Point(461, 169);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(87, 32);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // CadastrarNovosUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 234);
            Controls.Add(pnlPrincipal);
            Name = "CadastrarNovosUsuarios";
            Text = "CadastrarNovosUsuarios";
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private Label lblRepetirSenha;
        private Label lblUsuario;
        private Label lblSenha;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtRepetirSenha;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Button btnSalvar;
        private CheckBox chkGerente;
    }
}