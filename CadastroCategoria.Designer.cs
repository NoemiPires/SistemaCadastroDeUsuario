namespace SistemaCadastroDeUsuario
{
    partial class CadastroCategoria
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
            pnlCategoria = new Panel();
            grpCategoria = new GroupBox();
            txtCategoria = new TextBox();
            lblAlertaVazio = new Label();
            lblAlertaSucesso = new Label();
            lblAlertaExiste = new Label();
            btnAdicionar = new Button();
            pnlCategoria.SuspendLayout();
            grpCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCategoria
            // 
            pnlCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCategoria.Controls.Add(btnAdicionar);
            pnlCategoria.Controls.Add(lblAlertaExiste);
            pnlCategoria.Controls.Add(lblAlertaSucesso);
            pnlCategoria.Controls.Add(lblAlertaVazio);
            pnlCategoria.Controls.Add(grpCategoria);
            pnlCategoria.Location = new Point(12, 12);
            pnlCategoria.Name = "pnlCategoria";
            pnlCategoria.Size = new Size(273, 103);
            pnlCategoria.TabIndex = 0;
            // 
            // grpCategoria
            // 
            grpCategoria.Controls.Add(txtCategoria);
            grpCategoria.Location = new Point(3, 3);
            grpCategoria.Name = "grpCategoria";
            grpCategoria.Size = new Size(267, 58);
            grpCategoria.TabIndex = 0;
            grpCategoria.TabStop = false;
            grpCategoria.Text = "CATEGORIA:";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(6, 22);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(255, 23);
            txtCategoria.TabIndex = 0;
            // 
            // lblAlertaVazio
            // 
            lblAlertaVazio.AutoSize = true;
            lblAlertaVazio.BackColor = Color.FromArgb(255, 128, 255);
            lblAlertaVazio.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlertaVazio.Location = new Point(9, 64);
            lblAlertaVazio.Name = "lblAlertaVazio";
            lblAlertaVazio.Size = new Size(186, 12);
            lblAlertaVazio.TabIndex = 1;
            lblAlertaVazio.Text = "Obrigatório o preenchimento do campo acima";
            // 
            // lblAlertaSucesso
            // 
            lblAlertaSucesso.AutoSize = true;
            lblAlertaSucesso.BackColor = Color.FromArgb(128, 255, 128);
            lblAlertaSucesso.Location = new Point(9, 88);
            lblAlertaSucesso.Name = "lblAlertaSucesso";
            lblAlertaSucesso.Size = new Size(104, 15);
            lblAlertaSucesso.TabIndex = 2;
            lblAlertaSucesso.Text = "Cadastro efetuado";
            // 
            // lblAlertaExiste
            // 
            lblAlertaExiste.AutoSize = true;
            lblAlertaExiste.BackColor = Color.FromArgb(255, 128, 255);
            lblAlertaExiste.Location = new Point(9, 88);
            lblAlertaExiste.Name = "lblAlertaExiste";
            lblAlertaExiste.Size = new Size(119, 15);
            lblAlertaExiste.TabIndex = 3;
            lblAlertaExiste.Text = "Categoria já existente";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(128, 255, 128);
            btnAdicionar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(198, 77);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Cadastrar";
            btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // CadastroCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 127);
            Controls.Add(pnlCategoria);
            Name = "CadastroCategoria";
            Text = "CadastroCategoria";
            pnlCategoria.ResumeLayout(false);
            pnlCategoria.PerformLayout();
            grpCategoria.ResumeLayout(false);
            grpCategoria.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCategoria;
        private Label lblAlertaVazio;
        private GroupBox grpCategoria;
        private TextBox txtCategoria;
        private Button btnAdicionar;
        private Label lblAlertaExiste;
        private Label lblAlertaSucesso;
    }
}