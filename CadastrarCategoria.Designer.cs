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
            lblCadastroEfetuado = new Label();
            txtCategoriaNome = new TextBox();
            lblCategoriaNome = new Label();
            btnCadastrar = new Button();
            lblNome = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(txtCategoriaNome);
            panel1.Controls.Add(lblCadastroEfetuado);
            panel1.Controls.Add(lblCategoriaNome);
            panel1.Controls.Add(btnCadastrar);
            panel1.Controls.Add(lblNome);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 97);
            panel1.TabIndex = 0;
            // 
            // lblCadastroEfetuado
            // 
            lblCadastroEfetuado.AutoSize = true;
            lblCadastroEfetuado.BackColor = Color.Olive;
            lblCadastroEfetuado.ForeColor = SystemColors.ActiveCaptionText;
            lblCadastroEfetuado.Location = new Point(9, 68);
            lblCadastroEfetuado.Name = "lblCadastroEfetuado";
            lblCadastroEfetuado.Size = new Size(104, 15);
            lblCadastroEfetuado.TabIndex = 12;
            lblCadastroEfetuado.Text = "Cadastro Efetuado";
            lblCadastroEfetuado.Visible = false;
            // 
            // txtCategoriaNome
            // 
            txtCategoriaNome.Font = new Font("Segoe UI", 9.75F);
            txtCategoriaNome.Location = new Point(93, 23);
            txtCategoriaNome.Name = "txtCategoriaNome";
            txtCategoriaNome.Size = new Size(296, 25);
            txtCategoriaNome.TabIndex = 5;
            txtCategoriaNome.KeyUp += txtCategoriaNome_KeyUp;
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
            btnCadastrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(308, 61);
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
            ClientSize = new Size(421, 121);
            Controls.Add(panel1);
            Name = "CadastrarCategoria";
            Text = "CadastrarCategoria";
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
        private Label lblCadastroEfetuado;
    }
}