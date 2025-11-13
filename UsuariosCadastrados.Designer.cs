namespace SistemaCadastroDeUsuario
{
    partial class UsuariosCadastrados
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
            pnlLista = new Panel();
            grpCadastros = new GroupBox();
            lblUltimoAcesso = new Label();
            lblUltimoAcessoDado = new Label();
            lblNomeDado = new Label();
            lblPerfilDado = new Label();
            lblNome = new Label();
            lblTelefoneDado = new Label();
            lblUsuarioDado = new Label();
            lblEmailDado = new Label();
            lblNomeUsuario = new Label();
            lblEmail = new Label();
            lblTelefone = new Label();
            lblPerfil = new Label();
            lstUsuarios = new ListBox();
            pnlLista.SuspendLayout();
            grpCadastros.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLista
            // 
            pnlLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLista.Controls.Add(grpCadastros);
            pnlLista.Controls.Add(lstUsuarios);
            pnlLista.Location = new Point(12, 12);
            pnlLista.Name = "pnlLista";
            pnlLista.Size = new Size(443, 328);
            pnlLista.TabIndex = 0;
            // 
            // grpCadastros
            // 
            grpCadastros.Controls.Add(lblUltimoAcesso);
            grpCadastros.Controls.Add(lblUltimoAcessoDado);
            grpCadastros.Controls.Add(lblNomeDado);
            grpCadastros.Controls.Add(lblPerfilDado);
            grpCadastros.Controls.Add(lblNome);
            grpCadastros.Controls.Add(lblTelefoneDado);
            grpCadastros.Controls.Add(lblUsuarioDado);
            grpCadastros.Controls.Add(lblEmailDado);
            grpCadastros.Controls.Add(lblNomeUsuario);
            grpCadastros.Controls.Add(lblEmail);
            grpCadastros.Controls.Add(lblTelefone);
            grpCadastros.Controls.Add(lblPerfil);
            grpCadastros.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCadastros.Location = new Point(188, 3);
            grpCadastros.Name = "grpCadastros";
            grpCadastros.Size = new Size(202, 224);
            grpCadastros.TabIndex = 13;
            grpCadastros.TabStop = false;
            // 
            // lblUltimoAcesso
            // 
            lblUltimoAcesso.AutoSize = true;
            lblUltimoAcesso.Location = new Point(6, 165);
            lblUltimoAcesso.Name = "lblUltimoAcesso";
            lblUltimoAcesso.Size = new Size(86, 15);
            lblUltimoAcesso.TabIndex = 6;
            lblUltimoAcesso.Text = "ÚltimoAcesso:";
            // 
            // lblUltimoAcessoDado
            // 
            lblUltimoAcessoDado.AutoSize = true;
            lblUltimoAcessoDado.Location = new Point(95, 165);
            lblUltimoAcessoDado.Name = "lblUltimoAcessoDado";
            lblUltimoAcessoDado.Size = new Size(40, 15);
            lblUltimoAcessoDado.TabIndex = 12;
            lblUltimoAcessoDado.Text = "label1";
            // 
            // lblNomeDado
            // 
            lblNomeDado.AutoSize = true;
            lblNomeDado.Location = new Point(55, 19);
            lblNomeDado.Name = "lblNomeDado";
            lblNomeDado.Size = new Size(40, 15);
            lblNomeDado.TabIndex = 7;
            lblNomeDado.Text = "label1";
            // 
            // lblPerfilDado
            // 
            lblPerfilDado.AutoSize = true;
            lblPerfilDado.Location = new Point(49, 133);
            lblPerfilDado.Name = "lblPerfilDado";
            lblPerfilDado.Size = new Size(40, 15);
            lblPerfilDado.TabIndex = 11;
            lblPerfilDado.Text = "label1";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(6, 19);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(44, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblTelefoneDado
            // 
            lblTelefoneDado.AutoSize = true;
            lblTelefoneDado.Location = new Point(67, 106);
            lblTelefoneDado.Name = "lblTelefoneDado";
            lblTelefoneDado.Size = new Size(40, 15);
            lblTelefoneDado.TabIndex = 10;
            lblTelefoneDado.Text = "label1";
            // 
            // lblUsuarioDado
            // 
            lblUsuarioDado.AutoSize = true;
            lblUsuarioDado.Location = new Point(114, 48);
            lblUsuarioDado.Name = "lblUsuarioDado";
            lblUsuarioDado.Size = new Size(40, 15);
            lblUsuarioDado.TabIndex = 8;
            lblUsuarioDado.Text = "label1";
            // 
            // lblEmailDado
            // 
            lblEmailDado.AutoSize = true;
            lblEmailDado.Location = new Point(56, 77);
            lblEmailDado.Name = "lblEmailDado";
            lblEmailDado.Size = new Size(40, 15);
            lblEmailDado.TabIndex = 9;
            lblEmailDado.Text = "label1";
            // 
            // lblNomeUsuario
            // 
            lblNomeUsuario.AutoSize = true;
            lblNomeUsuario.Location = new Point(6, 48);
            lblNomeUsuario.Name = "lblNomeUsuario";
            lblNomeUsuario.Size = new Size(106, 15);
            lblNomeUsuario.TabIndex = 4;
            lblNomeUsuario.Text = "Nome de Usuário:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(6, 77);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-Mail:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(6, 106);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(59, 15);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone:";
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Location = new Point(6, 133);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(40, 15);
            lblPerfil.TabIndex = 5;
            lblPerfil.Text = "Perfil:";
            // 
            // lstUsuarios
            // 
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 15;
            lstUsuarios.Location = new Point(3, 3);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(158, 319);
            lstUsuarios.TabIndex = 0;
            lstUsuarios.Click += lstUsuarios_Click;
            // 
            // UsuariosCadastrados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 352);
            Controls.Add(pnlLista);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UsuariosCadastrados";
            Text = "UsuariosCadastrados";
            pnlLista.ResumeLayout(false);
            grpCadastros.ResumeLayout(false);
            grpCadastros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLista;
        private ListBox lstUsuarios;
        private Label lblNome;
        private Label lblUltimoAcesso;
        private Label lblPerfil;
        private Label lblNomeUsuario;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblPerfilDado;
        private Label lblTelefoneDado;
        private Label lblEmailDado;
        private Label lblUsuarioDado;
        private Label lblNomeDado;
        private Label lblUltimoAcessoDado;
        private GroupBox grpCadastros;
    }
}