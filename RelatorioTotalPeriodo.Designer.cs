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
            cmbPeriodo = new ComboBox();
            gpbTotalPeriodo = new GroupBox();
            lblTotal = new Label();
            pnlPrincipal.SuspendLayout();
            gpbTotalPeriodo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipal.Controls.Add(gpbTotalPeriodo);
            pnlPrincipal.Controls.Add(cmbPeriodo);
            pnlPrincipal.Location = new Point(12, 12);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(374, 137);
            pnlPrincipal.TabIndex = 0;
            // 
            // cmbPeriodo
            // 
            cmbPeriodo.FormattingEnabled = true;
            cmbPeriodo.Location = new Point(14, 15);
            cmbPeriodo.Name = "cmbPeriodo";
            cmbPeriodo.Size = new Size(163, 23);
            cmbPeriodo.TabIndex = 0;
            // 
            // gpbTotalPeriodo
            // 
            gpbTotalPeriodo.Controls.Add(lblTotal);
            gpbTotalPeriodo.Location = new Point(194, 15);
            gpbTotalPeriodo.Name = "gpbTotalPeriodo";
            gpbTotalPeriodo.Size = new Size(165, 100);
            gpbTotalPeriodo.TabIndex = 1;
            gpbTotalPeriodo.TabStop = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(6, 19);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total";
            // 
            // RelatorioTotalPeriodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 161);
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
        private ComboBox cmbPeriodo;
        private GroupBox gpbTotalPeriodo;
        private Label lblTotal;
    }
}