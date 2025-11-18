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
            lblClienteDado = new Label();
            lblCliente = new Label();
            lblIdDado = new Label();
            lblId = new Label();
            lblPrecoDado = new Label();
            lblPreco = new Label();
            lblPagamentoEfetuado = new Label();
            lblPagamentoPendente = new Label();
            lblPagamento = new Label();
            lstVendasCadastradas = new ListBox();
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
            grpDadosVendasCdastradas.Controls.Add(lblClienteDado);
            grpDadosVendasCdastradas.Controls.Add(lblCliente);
            grpDadosVendasCdastradas.Controls.Add(lblIdDado);
            grpDadosVendasCdastradas.Controls.Add(lblId);
            grpDadosVendasCdastradas.Controls.Add(lblPrecoDado);
            grpDadosVendasCdastradas.Controls.Add(lblPreco);
            grpDadosVendasCdastradas.Controls.Add(lblPagamentoEfetuado);
            grpDadosVendasCdastradas.Controls.Add(lblPagamentoPendente);
            grpDadosVendasCdastradas.Controls.Add(lblPagamento);
            grpDadosVendasCdastradas.Location = new Point(276, 3);
            grpDadosVendasCdastradas.Name = "grpDadosVendasCdastradas";
            grpDadosVendasCdastradas.Size = new Size(185, 259);
            grpDadosVendasCdastradas.TabIndex = 1;
            grpDadosVendasCdastradas.TabStop = false;
            grpDadosVendasCdastradas.Text = "INFORMAÇÕES";
            // 
            // lblClienteDado
            // 
            lblClienteDado.AutoSize = true;
            lblClienteDado.Location = new Point(59, 65);
            lblClienteDado.Name = "lblClienteDado";
            lblClienteDado.Size = new Size(38, 15);
            lblClienteDado.TabIndex = 8;
            lblClienteDado.Text = "label1";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(6, 65);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 7;
            lblCliente.Text = "Cliente:";
            // 
            // lblIdDado
            // 
            lblIdDado.AutoSize = true;
            lblIdDado.Location = new Point(33, 22);
            lblIdDado.Name = "lblIdDado";
            lblIdDado.Size = new Size(38, 15);
            lblIdDado.TabIndex = 6;
            lblIdDado.Text = "label1";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(6, 22);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 5;
            lblId.Text = "ID:";
            // 
            // lblPrecoDado
            // 
            lblPrecoDado.AutoSize = true;
            lblPrecoDado.Location = new Point(52, 43);
            lblPrecoDado.Name = "lblPrecoDado";
            lblPrecoDado.Size = new Size(38, 15);
            lblPrecoDado.TabIndex = 4;
            lblPrecoDado.Text = "label1";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(6, 43);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(40, 15);
            lblPreco.TabIndex = 3;
            lblPreco.Text = "Preço:";
            // 
            // lblPagamentoEfetuado
            // 
            lblPagamentoEfetuado.AutoSize = true;
            lblPagamentoEfetuado.BackColor = Color.FromArgb(128, 128, 255);
            lblPagamentoEfetuado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPagamentoEfetuado.ForeColor = Color.White;
            lblPagamentoEfetuado.Location = new Point(0, 236);
            lblPagamentoEfetuado.Name = "lblPagamentoEfetuado";
            lblPagamentoEfetuado.Size = new Size(141, 17);
            lblPagamentoEfetuado.TabIndex = 2;
            lblPagamentoEfetuado.Text = "Pagamento Efetuado!";
            // 
            // lblPagamentoPendente
            // 
            lblPagamentoPendente.AutoSize = true;
            lblPagamentoPendente.BackColor = Color.FromArgb(192, 0, 0);
            lblPagamentoPendente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPagamentoPendente.ForeColor = Color.FromArgb(255, 255, 128);
            lblPagamentoPendente.Location = new Point(0, 236);
            lblPagamentoPendente.Name = "lblPagamentoPendente";
            lblPagamentoPendente.Size = new Size(144, 17);
            lblPagamentoPendente.TabIndex = 1;
            lblPagamentoPendente.Text = "Pagamento Pendente!";
            // 
            // lblPagamento
            // 
            lblPagamento.AutoSize = true;
            lblPagamento.Location = new Point(0, 221);
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
            lstVendasCadastradas.Click += lstVendasCadastradas_Click;
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
        private Label lblPreco;
        private Label lblPrecoDado;
        private Label lblCliente;
        private Label lblIdDado;
        private Label lblId;
        private Label lblClienteDado;
    }
}