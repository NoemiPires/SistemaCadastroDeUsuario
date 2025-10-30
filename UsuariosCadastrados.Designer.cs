namespace SistemaCadastroDeUsuario
{
    partial class UsuariosCadastrados
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
            pnlLista = new Panel();
            ListaUsuarios = new ListBox();
            pnlLista.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLista
            // 
            pnlLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLista.Controls.Add(ListaUsuarios);
            pnlLista.Location = new Point(12, 12);
            pnlLista.Name = "pnlLista";
            pnlLista.Size = new Size(776, 426);
            pnlLista.TabIndex = 0;
            // 
            // ListaUsuarios
            // 
            ListaUsuarios.FormattingEnabled = true;
            ListaUsuarios.ItemHeight = 15;
            ListaUsuarios.Location = new Point(13, 12);
            ListaUsuarios.Name = "ListaUsuarios";
            ListaUsuarios.Size = new Size(747, 394);
            ListaUsuarios.TabIndex = 0;
            // 
            // UsuariosCadastrados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlLista);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UsuariosCadastrados";
            Text = "UsuariosCadastrados";
            pnlLista.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLista;
        private ListBox ListaUsuarios;
    }
}