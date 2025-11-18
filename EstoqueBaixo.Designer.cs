namespace SistemaCadastroDeUsuario
{
    partial class EstoqueBaixo
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
            pnlEstoqueBaixo = new Panel();
            lstEstoqueProdutos = new ListBox();
            groupBox1 = new GroupBox();
            pnlEstoqueBaixo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlEstoqueBaixo
            // 
            pnlEstoqueBaixo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlEstoqueBaixo.Controls.Add(groupBox1);
            pnlEstoqueBaixo.Controls.Add(lstEstoqueProdutos);
            pnlEstoqueBaixo.Location = new Point(12, 12);
            pnlEstoqueBaixo.Name = "pnlEstoqueBaixo";
            pnlEstoqueBaixo.Size = new Size(518, 398);
            pnlEstoqueBaixo.TabIndex = 0;
            // 
            // lstEstoqueProdutos
            // 
            lstEstoqueProdutos.FormattingEnabled = true;
            lstEstoqueProdutos.ItemHeight = 15;
            lstEstoqueProdutos.Location = new Point(23, 9);
            lstEstoqueProdutos.Name = "lstEstoqueProdutos";
            lstEstoqueProdutos.Size = new Size(258, 364);
            lstEstoqueProdutos.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(308, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(186, 244);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // EstoqueBaixo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 422);
            Controls.Add(pnlEstoqueBaixo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EstoqueBaixo";
            Text = "EstoqueBaixo";
            pnlEstoqueBaixo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEstoqueBaixo;
        private ListBox lstEstoqueProdutos;
        private GroupBox groupBox1;
    }
}