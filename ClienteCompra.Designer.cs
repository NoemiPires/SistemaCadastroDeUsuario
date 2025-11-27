namespace SistemaCadastroDeUsuario
{
    partial class ClienteCompra
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
            cmbClientes = new ComboBox();
            btnAvançar = new Button();
            lblAviso = new Label();
            SuspendLayout();
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(22, 25);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(298, 23);
            cmbClientes.TabIndex = 0;
            // 
            // btnAvançar
            // 
            btnAvançar.BackColor = Color.Thistle;
            btnAvançar.Location = new Point(254, 71);
            btnAvançar.Name = "btnAvançar";
            btnAvançar.Size = new Size(75, 23);
            btnAvançar.TabIndex = 1;
            btnAvançar.Text = "Avançar";
            btnAvançar.UseVisualStyleBackColor = false;
            btnAvançar.Click += btnAvançar_Click;
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.BackColor = Color.Thistle;
            lblAviso.Location = new Point(12, 75);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(106, 15);
            lblAviso.TabIndex = 2;
            lblAviso.Text = "Cliente Inadiplente";
            lblAviso.Visible = false;
            // 
            // ClienteCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 118);
            Controls.Add(lblAviso);
            Controls.Add(btnAvançar);
            Controls.Add(cmbClientes);
            Name = "ClienteCompra";
            Text = "ClienteCompra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbClientes;
        private Button btnAvançar;
        private Label lblAviso;
    }
}