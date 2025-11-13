namespace SistemaCadastroDeUsuario
{
    partial class VendasCadastradas
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
            grpDadosVendasCdastradas = new GroupBox();
            lblPagamento = new Label();
            lstVendasCadastradas = new ListBox();
            lblPagamentoPendente = new Label();
            lblPagamentoEfetuado = new Label();
            panel1.SuspendLayout();
            grpDadosVendasCdastradas.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(grpDadosVendasCdastradas);
            panel1.Controls.Add(lstVendasCadastradas);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 265);
            panel1.TabIndex = 0;
            // 
            // grpDadosVendasCdastradas
            // 
            grpDadosVendasCdastradas.Controls.Add(lblPagamentoEfetuado);
            grpDadosVendasCdastradas.Controls.Add(lblPagamentoPendente);
            grpDadosVendasCdastradas.Controls.Add(lblPagamento);
            grpDadosVendasCdastradas.Location = new Point(276, 3);
            grpDadosVendasCdastradas.Name = "grpDadosVendasCdastradas";
            grpDadosVendasCdastradas.Size = new Size(185, 259);
            grpDadosVendasCdastradas.TabIndex = 1;
            grpDadosVendasCdastradas.TabStop = false;
            grpDadosVendasCdastradas.Text = "groupBox1";
            // 
            // lblPagamento
            // 
            lblPagamento.AutoSize = true;
            lblPagamento.Location = new Point(18, 28);
            lblPagamento.Name = "lblPagamento";
            lblPagamento.Size = new Size(123, 15);
            lblPagamento.TabIndex = 0;
            lblPagamento.Text = "Status do Pagamento:";
            // 
            // lstVendasCadastradas
            // 
            lstVendasCadastradas.FormattingEnabled = true;
            lstVendasCadastradas.ItemHeight = 15;
            lstVendasCadastradas.Location = new Point(3, 3);
            lstVendasCadastradas.Name = "lstVendasCadastradas";
            lstVendasCadastradas.Size = new Size(258, 259);
            lstVendasCadastradas.TabIndex = 0;
            // 
            // lblPagamentoPendente
            // 
            lblPagamentoPendente.AutoSize = true;
            lblPagamentoPendente.BackColor = Color.FromArgb(192, 0, 0);
            lblPagamentoPendente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPagamentoPendente.ForeColor = Color.FromArgb(255, 255, 128);
            lblPagamentoPendente.Location = new Point(17, 43);
            lblPagamentoPendente.Name = "lblPagamentoPendente";
            lblPagamentoPendente.Size = new Size(144, 17);
            lblPagamentoPendente.TabIndex = 1;
            lblPagamentoPendente.Text = "Pagamento Pendente!";
            // 
            // lblPagamentoEfetuado
            // 
            lblPagamentoEfetuado.AutoSize = true;
            lblPagamentoEfetuado.BackColor = Color.FromArgb(128, 128, 255);
            lblPagamentoEfetuado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPagamentoEfetuado.ForeColor = Color.White;
            lblPagamentoEfetuado.Location = new Point(17, 43);
            lblPagamentoEfetuado.Name = "lblPagamentoEfetuado";
            lblPagamentoEfetuado.Size = new Size(141, 17);
            lblPagamentoEfetuado.TabIndex = 2;
            lblPagamentoEfetuado.Text = "Pagamento Efetuado!";
            // 
            // VendasCadastradas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 289);
            Controls.Add(panel1);
            Name = "VendasCadastradas";
            Text = "Vendas Cadastradas";
            panel1.ResumeLayout(false);
            grpDadosVendasCdastradas.ResumeLayout(false);
            grpDadosVendasCdastradas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox lstVendasCadastradas;
        private GroupBox grpDadosVendasCdastradas;
        private Label lblPagamento;
        private Label lblPagamentoEfetuado;
        private Label lblPagamentoPendente;
    }
}