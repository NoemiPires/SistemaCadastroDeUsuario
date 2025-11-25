namespace SistemaCadastroDeUsuario
{
    partial class RelatorioTotalPeriodo
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
            lstPeriodo = new ListBox();
            gpbTotalPeriodo = new GroupBox();
            lblRespostaTotal = new Label();
            lblTotal = new Label();
            pnlPrincipal.SuspendLayout();
            gpbTotalPeriodo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipal.Controls.Add(lstPeriodo);
            pnlPrincipal.Controls.Add(gpbTotalPeriodo);
            pnlPrincipal.Location = new Point(12, 12);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(374, 114);
            pnlPrincipal.TabIndex = 0;
            // 
            // lstPeriodo
            // 
            lstPeriodo.FormattingEnabled = true;
            lstPeriodo.ItemHeight = 15;
            lstPeriodo.Location = new Point(20, 9);
            lstPeriodo.Name = "lstPeriodo";
            lstPeriodo.Size = new Size(120, 94);
            lstPeriodo.TabIndex = 2;
            lstPeriodo.Click += lstPeriodo_Click;
            // 
            // gpbTotalPeriodo
            // 
            gpbTotalPeriodo.Controls.Add(lblRespostaTotal);
            gpbTotalPeriodo.Controls.Add(lblTotal);
            gpbTotalPeriodo.Location = new Point(183, 3);
            gpbTotalPeriodo.Name = "gpbTotalPeriodo";
            gpbTotalPeriodo.Size = new Size(165, 100);
            gpbTotalPeriodo.TabIndex = 1;
            gpbTotalPeriodo.TabStop = false;
            // 
            // lblRespostaTotal
            // 
            lblRespostaTotal.AutoSize = true;
            lblRespostaTotal.Location = new Point(6, 43);
            lblRespostaTotal.Name = "lblRespostaTotal";
            lblRespostaTotal.Size = new Size(62, 15);
            lblRespostaTotal.TabIndex = 1;
            lblRespostaTotal.Text = "(Resposta)";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(6, 19);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(91, 15);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total de Vendas:";
            // 
            // RelatorioTotalPeriodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 138);
            Controls.Add(pnlPrincipal);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RelatorioTotalPeriodo";
            Text = "RelatorioTotalPeriodo";
            pnlPrincipal.ResumeLayout(false);
            gpbTotalPeriodo.ResumeLayout(false);
            gpbTotalPeriodo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private GroupBox gpbTotalPeriodo;
        private Label lblTotal;
        private Label lblRespostaTotal;
        private ListBox lstPeriodo;
    }
}