namespace SistemaCadastroDeUsuario
{
    partial class RelatorioClientesInadimplentes
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
            lstClienteInadiplentes = new ListBox();
            lblNome = new Label();
            lblRespostaNome = new Label();
            lblRespostaCpf = new Label();
            lblCpf = new Label();
            pnlPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipal.Controls.Add(lblRespostaCpf);
            pnlPrincipal.Controls.Add(lblCpf);
            pnlPrincipal.Controls.Add(lblRespostaNome);
            pnlPrincipal.Controls.Add(lblNome);
            pnlPrincipal.Controls.Add(lstClienteInadiplentes);
            pnlPrincipal.Location = new Point(12, 12);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(276, 182);
            pnlPrincipal.TabIndex = 0;
            // 
            // lstClienteInadiplentes
            // 
            lstClienteInadiplentes.FormattingEnabled = true;
            lstClienteInadiplentes.ItemHeight = 15;
            lstClienteInadiplentes.Location = new Point(15, 14);
            lstClienteInadiplentes.Name = "lstClienteInadiplentes";
            lstClienteInadiplentes.Size = new Size(118, 154);
            lstClienteInadiplentes.TabIndex = 0;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(153, 14);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblRespostaNome
            // 
            lblRespostaNome.AutoSize = true;
            lblRespostaNome.Location = new Point(153, 42);
            lblRespostaNome.Name = "lblRespostaNome";
            lblRespostaNome.Size = new Size(62, 15);
            lblRespostaNome.TabIndex = 2;
            lblRespostaNome.Text = "(Resposta)";
            // 
            // lblRespostaCpf
            // 
            lblRespostaCpf.AutoSize = true;
            lblRespostaCpf.Location = new Point(153, 112);
            lblRespostaCpf.Name = "lblRespostaCpf";
            lblRespostaCpf.Size = new Size(62, 15);
            lblRespostaCpf.TabIndex = 4;
            lblRespostaCpf.Text = "(Resposta)";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCpf.Location = new Point(153, 84);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(30, 15);
            lblCpf.TabIndex = 3;
            lblCpf.Text = "CPF:";
            // 
            // RelatorioClientesInadimplentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 206);
            Controls.Add(pnlPrincipal);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RelatorioClientesInadimplentes";
            Text = "RelatorioClientesInadimplentes";
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private ListBox lstClienteInadiplentes;
        private Label lblRespostaNome;
        private Label lblNome;
        private Label lblRespostaCpf;
        private Label lblCpf;
    }
}