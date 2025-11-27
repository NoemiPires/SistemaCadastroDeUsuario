namespace SistemaCadastroDeUsuario
{
    partial class NovaVenda
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
            lsbItens = new ListBox();
            lblTotal = new Label();
            lblTotalCompra = new Label();
            lblNomeCliente = new Label();
            btnSalvarCompr = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnSalvarCompr);
            panel1.Controls.Add(lsbItens);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(lblTotalCompra);
            panel1.Controls.Add(lblNomeCliente);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(739, 334);
            panel1.TabIndex = 0;
            // 
            // lsbItens
            // 
            lsbItens.FormattingEnabled = true;
            lsbItens.ItemHeight = 15;
            lsbItens.Location = new Point(14, 53);
            lsbItens.Name = "lsbItens";
            lsbItens.Size = new Size(182, 229);
            lsbItens.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(113, 305);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total";
            // 
            // lblTotalCompra
            // 
            lblTotalCompra.AutoSize = true;
            lblTotalCompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCompra.Location = new Point(14, 305);
            lblTotalCompra.Name = "lblTotalCompra";
            lblTotalCompra.Size = new Size(83, 15);
            lblTotalCompra.TabIndex = 1;
            lblTotalCompra.Text = "Total Compra:";
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNomeCliente.Location = new Point(14, 21);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(52, 15);
            lblNomeCliente.TabIndex = 0;
            lblNomeCliente.Text = "(Cliente)";
            // 
            // btnSalvarCompr
            // 
            btnSalvarCompr.Location = new Point(635, 297);
            btnSalvarCompr.Name = "btnSalvarCompr";
            btnSalvarCompr.Size = new Size(75, 23);
            btnSalvarCompr.TabIndex = 2;
            btnSalvarCompr.Text = "Salvar";
            btnSalvarCompr.UseVisualStyleBackColor = true;
            // 
            // NovaVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 336);
            Controls.Add(panel1);
            Name = "NovaVenda";
            Text = "NovaVenda";
            Load += NovaVenda_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblNomeCliente;
        private Button btnSalvarCompr;
        private ListBox lsbItens;
        private Label lblTotal;
        private Label lblTotalCompra;
    }
}