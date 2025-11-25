namespace SistemaCadastroDeUsuario
{
    partial class RelatorioComissaoPeriodo
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
            lstVendedores = new ListBox();
            lstPeriodo = new ListBox();
            lblComissao = new Label();
            SuspendLayout();
            // 
            // lstVendedores
            // 
            lstVendedores.FormattingEnabled = true;
            lstVendedores.ItemHeight = 15;
            lstVendedores.Location = new Point(12, 12);
            lstVendedores.Name = "lstVendedores";
            lstVendedores.Size = new Size(119, 139);
            lstVendedores.TabIndex = 0;
            lstVendedores.Click += lstVendedores_Click;
            // 
            // lstPeriodo
            // 
            lstPeriodo.FormattingEnabled = true;
            lstPeriodo.ItemHeight = 15;
            lstPeriodo.Location = new Point(136, 13);
            lstPeriodo.Name = "lstPeriodo";
            lstPeriodo.Size = new Size(119, 139);
            lstPeriodo.TabIndex = 1;
            // 
            // lblComissao
            // 
            lblComissao.AutoSize = true;
            lblComissao.Location = new Point(274, 13);
            lblComissao.Name = "lblComissao";
            lblComissao.Size = new Size(59, 15);
            lblComissao.TabIndex = 2;
            lblComissao.Text = "Comissao";
            // 
            // RelatorioComissaoPeriodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 164);
            Controls.Add(lblComissao);
            Controls.Add(lstPeriodo);
            Controls.Add(lstVendedores);
            Name = "RelatorioComissaoPeriodo";
            Text = "RelatorioComissaoPeriodo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstVendedores;
        private ListBox lstPeriodo;
        private Label lblComissao;
    }
}