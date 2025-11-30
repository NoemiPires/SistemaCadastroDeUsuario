namespace SistemaCadastroDeUsuario
{
    partial class GerenteAutorizacao
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
            btnAutorizar = new Button();
            lsvProdutos = new ListView();
            lblAlertaInválido = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblAlertaInválido);
            panel1.Controls.Add(btnAutorizar);
            panel1.Controls.Add(lsvProdutos);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 222);
            panel1.TabIndex = 0;
            // 
            // btnAutorizar
            // 
            btnAutorizar.BackColor = Color.FromArgb(128, 255, 128);
            btnAutorizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutorizar.Location = new Point(113, 181);
            btnAutorizar.Name = "btnAutorizar";
            btnAutorizar.Size = new Size(75, 23);
            btnAutorizar.TabIndex = 1;
            btnAutorizar.Text = "Autorizar";
            btnAutorizar.UseVisualStyleBackColor = false;
            // 
            // lsvProdutos
            // 
            lsvProdutos.Location = new Point(3, 3);
            lsvProdutos.Name = "lsvProdutos";
            lsvProdutos.Size = new Size(285, 172);
            lsvProdutos.TabIndex = 0;
            lsvProdutos.UseCompatibleStateImageBehavior = false;
            lsvProdutos.ColumnWidthChanged += lsvProdutos_ColumnWidthChanged;
            // 
            // lblAlertaInválido
            // 
            lblAlertaInválido.AutoSize = true;
            lblAlertaInválido.BackColor = Color.FromArgb(255, 128, 255);
            lblAlertaInválido.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlertaInválido.Location = new Point(194, 192);
            lblAlertaInválido.Name = "lblAlertaInválido";
            lblAlertaInválido.Size = new Size(86, 12);
            lblAlertaInválido.TabIndex = 2;
            lblAlertaInválido.Text = "Falha na autorização";
            // 
            // GerenteAutorizacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 246);
            Controls.Add(panel1);
            Name = "GerenteAutorizacao";
            Text = "GerenteAutorizacao";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAutorizar;
        private ListView lsvProdutos;
        private Label lblAlertaInválido;
    }
}