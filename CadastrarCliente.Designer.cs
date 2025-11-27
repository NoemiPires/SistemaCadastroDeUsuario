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
            lblClienteCadastrado = new Label();
            btnCadastrar = new Button();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            lblCpf = new Label();
            lblNome = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblClienteCadastrado);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(txtCpf);
            panel1.Controls.Add(lblCpf);
            panel1.Controls.Add(lblNome);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 135);
            panel1.TabIndex = 0;
            // 
            // lblClienteCadastrado
            // 
            lblClienteCadastrado.AutoSize = true;
            lblClienteCadastrado.BackColor = Color.FromArgb(192, 192, 255);
            lblClienteCadastrado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClienteCadastrado.Location = new Point(12, 104);
            lblClienteCadastrado.Name = "lblClienteCadastrado";
            lblClienteCadastrado.Size = new Size(119, 17);
            lblClienteCadastrado.TabIndex = 34;
            lblClienteCadastrado.Text = "Cliente Cadastrado";
            lblClienteCadastrado.Visible = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(255, 96);
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
            txtCpf.Location = new Point(77, 61);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(270, 25);
            txtCpf.TabIndex = 28;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI", 9.75F);
            lblCpf.Location = new Point(12, 61);
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
            ClientSize = new Size(388, 159);
            Controls.Add(panel1);
            Name = "CadastrarCliente";
            Text = "CadastrarCliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblClienteCadastrado;
        private Button btnCadastrar;
        private TextBox txtNome;
        private TextBox txtCpf;
        private Label lblCpf;
        private Label lblNome;
    }
}