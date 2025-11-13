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
            lstVendasCadastradas = new ListBox();
            grpDadosVendasCdastradas = new GroupBox();
            panel1.SuspendLayout();
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
            // lstVendasCadastradas
            // 
            lstVendasCadastradas.FormattingEnabled = true;
            lstVendasCadastradas.ItemHeight = 15;
            lstVendasCadastradas.Location = new Point(3, 3);
            lstVendasCadastradas.Name = "lstVendasCadastradas";
            lstVendasCadastradas.Size = new Size(258, 259);
            lstVendasCadastradas.TabIndex = 0;
            // 
            // grpDadosVendasCdastradas
            // 
            grpDadosVendasCdastradas.Location = new Point(276, 3);
            grpDadosVendasCdastradas.Name = "grpDadosVendasCdastradas";
            grpDadosVendasCdastradas.Size = new Size(185, 259);
            grpDadosVendasCdastradas.TabIndex = 1;
            grpDadosVendasCdastradas.TabStop = false;
            grpDadosVendasCdastradas.Text = "groupBox1";
            // 
            // VendasCadastradas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 289);
            Controls.Add(panel1);
            Name = "VendasCadastradas";
            Text = "VendasCadastradas";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox lstVendasCadastradas;
        private GroupBox grpDadosVendasCdastradas;
    }
}