namespace SistemaCadastroDeUsuario
{
    partial class CadastrarCategoria
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
            lblAlertaCategoriaJaExistente = new Label();
            lblAlertaCampoVazio = new Label();
            txtCategoriaNome = new TextBox();
            lblAlertaCadastroEfetuado = new Label();
            lblCategoriaNome = new Label();
            btnCadastrar = new Button();
            lblNome = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblAlertaCategoriaJaExistente);
            panel1.Controls.Add(lblAlertaCampoVazio);
            panel1.Controls.Add(txtCategoriaNome);
            panel1.Controls.Add(lblAlertaCadastroEfetuado);
            panel1.Controls.Add(lblCategoriaNome);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(lblNome);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 126);
            panel1.TabIndex = 0;
            // 
            // lblAlertaCategoriaJaExistente
            // 
            lblAlertaCategoriaJaExistente.AutoSize = true;
            lblAlertaCategoriaJaExistente.BackColor = Color.FromArgb(255, 128, 255);
            lblAlertaCategoriaJaExistente.Location = new Point(201, 68);
            lblAlertaCategoriaJaExistente.Name = "lblAlertaCategoriaJaExistente";
            lblAlertaCategoriaJaExistente.Size = new Size(102, 15);
            lblAlertaCategoriaJaExistente.TabIndex = 14;
            lblAlertaCategoriaJaExistente.Text = "Categoria já existe";
            // 
            // lblAlertaCampoVazio
            // 
            lblAlertaCampoVazio.AutoSize = true;
            lblAlertaCampoVazio.BackColor = Color.FromArgb(255, 128, 255);
            lblAlertaCampoVazio.Location = new Point(119, 68);
            lblAlertaCampoVazio.Name = "lblAlertaCampoVazio";
            lblAlertaCampoVazio.Size = new Size(76, 15);
            lblAlertaCampoVazio.TabIndex = 13;
            lblAlertaCampoVazio.Text = "Campo Vazio";
            // 
            // txtCategoriaNome
            // 
            txtCategoriaNome.Font = new Font("Segoe UI", 9.75F);
            txtCategoriaNome.Location = new Point(93, 23);
            txtCategoriaNome.Name = "txtCategoriaNome";
            txtCategoriaNome.Size = new Size(296, 25);
            txtCategoriaNome.TabIndex = 5;
            txtCategoriaNome.TextChanged += txtCategoriaNome_TextChanged;
            txtCategoriaNome.KeyUp += txtCategoriaNome_KeyUp;
            // 
            // lblAlertaCadastroEfetuado
            // 
            lblAlertaCadastroEfetuado.AutoSize = true;
            lblAlertaCadastroEfetuado.BackColor = Color.FromArgb(128, 255, 128);
            lblAlertaCadastroEfetuado.ForeColor = SystemColors.ActiveCaptionText;
            lblAlertaCadastroEfetuado.Location = new Point(9, 68);
            lblAlertaCadastroEfetuado.Name = "lblAlertaCadastroEfetuado";
            lblAlertaCadastroEfetuado.Size = new Size(104, 15);
            lblAlertaCadastroEfetuado.TabIndex = 12;
            lblAlertaCadastroEfetuado.Text = "Cadastro Efetuado";
            lblAlertaCadastroEfetuado.Visible = false;
            // 
            // lblCategoriaNome
            // 
            lblCategoriaNome.AutoSize = true;
            lblCategoriaNome.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoriaNome.Location = new Point(8, 24);
            lblCategoriaNome.Name = "lblCategoriaNome";
            lblCategoriaNome.Size = new Size(79, 20);
            lblCategoriaNome.TabIndex = 4;
            lblCategoriaNome.Text = "Categoria:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(315, 97);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(82, 26);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(9, 22);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(79, 20);
            lblNome.TabIndex = 1;
            lblNome.Text = "Categoria:";
            // 
            // CadastrarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 150);
            Controls.Add(panel1);
            Name = "CadastrarCategoria";
            Text = "CadastrarCategoria";
            Click += CadastrarCategoria_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblNome;
        private TextBox txtCategoriaNome;
        private Label lblCategoriaNome;
        private Button btnCadastrar;
        private Label lblAlertaCadastroEfetuado;
        private Label lblAlertaCampoVazio;
        private Label lblAlertaCategoriaJaExistente;
    }
}