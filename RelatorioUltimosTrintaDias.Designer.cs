namespace SistemaCadastroDeUsuario
{
    partial class RelatorioUltimosTrintaDias
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
            lsbClientes = new ListBox();
            lsbCompras = new ListBox();
            lblId = new Label();
            lblIdResposta = new Label();
            lblTotalResposta = new Label();
            lblTotal = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblTotalResposta);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(lblIdResposta);
            panel1.Controls.Add(lblId);
            panel1.Controls.Add(lsbCompras);
            panel1.Controls.Add(lsbClientes);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 192);
            panel1.TabIndex = 0;
            // 
            // lsbClientes
            // 
            lsbClientes.FormattingEnabled = true;
            lsbClientes.ItemHeight = 15;
            lsbClientes.Location = new Point(12, 14);
            lsbClientes.Name = "lsbClientes";
            lsbClientes.Size = new Size(148, 169);
            lsbClientes.TabIndex = 0;
            // 
            // lsbCompras
            // 
            lsbCompras.FormattingEnabled = true;
            lsbCompras.ItemHeight = 15;
            lsbCompras.Location = new Point(196, 14);
            lsbCompras.Name = "lsbCompras";
            lsbCompras.Size = new Size(148, 169);
            lsbCompras.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(390, 23);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 2;
            lblId.Text = "Id:";
            // 
            // lblIdResposta
            // 
            lblIdResposta.AutoSize = true;
            lblIdResposta.Location = new Point(390, 50);
            lblIdResposta.Name = "lblIdResposta";
            lblIdResposta.Size = new Size(62, 15);
            lblIdResposta.TabIndex = 3;
            lblIdResposta.Text = "(Resposta)";
            // 
            // lblTotalResposta
            // 
            lblTotalResposta.AutoSize = true;
            lblTotalResposta.Location = new Point(390, 114);
            lblTotalResposta.Name = "lblTotalResposta";
            lblTotalResposta.Size = new Size(62, 15);
            lblTotalResposta.TabIndex = 5;
            lblTotalResposta.Text = "(Resposta)";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(390, 87);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 15);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total:";
            // 
            // RelatorioUltimosTrintaDias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 216);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RelatorioUltimosTrintaDias";
            Text = "RelatorioUltimosTrintaDias";
            Load += RelatorioUltimosTrintaDias_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblIdResposta;
        private Label lblId;
        private ListBox lsbCompras;
        private ListBox lsbClientes;
        private Label lblTotalResposta;
        private Label lblTotal;
    }
}