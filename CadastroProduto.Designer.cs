namespace SistemaCadastroDeUsuario
{
    partial class CadastroProduto
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
            pnlCadastroProduto = new Panel();
            txtEstoqueMinimo = new TextBox();
            txtValor = new TextBox();
            txtQuantidade = new TextBox();
            txtDescricao = new TextBox();
            btnAcao = new Button();
            chkEstado = new CheckBox();
            lblEstado = new Label();
            btnCategoria = new Button();
            grpCategoria = new GroupBox();
            cboCategoria = new ComboBox();
            lblEstoqueMinimo = new Label();
            lblPrecoUnidade = new Label();
            lblQuantidade = new Label();
            lblDescricao = new Label();
            lblAlertaSucesso = new Label();
            lblAlertaProduto = new Label();
            lblAlertaVazio = new Label();
            lblAvisoEstoqueMinimo = new Label();
            lblAlertaValor = new Label();
            pnlCadastroProduto.SuspendLayout();
            grpCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCadastroProduto
            // 
            pnlCadastroProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCadastroProduto.Controls.Add(lblAlertaValor);
            pnlCadastroProduto.Controls.Add(lblAvisoEstoqueMinimo);
            pnlCadastroProduto.Controls.Add(lblAlertaVazio);
            pnlCadastroProduto.Controls.Add(lblAlertaProduto);
            pnlCadastroProduto.Controls.Add(lblAlertaSucesso);
            pnlCadastroProduto.Controls.Add(txtEstoqueMinimo);
            pnlCadastroProduto.Controls.Add(txtValor);
            pnlCadastroProduto.Controls.Add(txtQuantidade);
            pnlCadastroProduto.Controls.Add(txtDescricao);
            pnlCadastroProduto.Controls.Add(btnAcao);
            pnlCadastroProduto.Controls.Add(chkEstado);
            pnlCadastroProduto.Controls.Add(lblEstado);
            pnlCadastroProduto.Controls.Add(btnCategoria);
            pnlCadastroProduto.Controls.Add(grpCategoria);
            pnlCadastroProduto.Controls.Add(lblEstoqueMinimo);
            pnlCadastroProduto.Controls.Add(lblPrecoUnidade);
            pnlCadastroProduto.Controls.Add(lblQuantidade);
            pnlCadastroProduto.Controls.Add(lblDescricao);
            pnlCadastroProduto.Location = new Point(12, 12);
            pnlCadastroProduto.Name = "pnlCadastroProduto";
            pnlCadastroProduto.Size = new Size(328, 300);
            pnlCadastroProduto.TabIndex = 0;
            // 
            // txtEstoqueMinimo
            // 
            txtEstoqueMinimo.Location = new Point(116, 114);
            txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            txtEstoqueMinimo.Size = new Size(83, 23);
            txtEstoqueMinimo.TabIndex = 12;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(113, 79);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(86, 23);
            txtValor.TabIndex = 11;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(91, 43);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(65, 23);
            txtQuantidade.TabIndex = 10;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(96, 7);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(206, 23);
            txtDescricao.TabIndex = 9;
            // 
            // btnAcao
            // 
            btnAcao.BackColor = Color.FromArgb(128, 255, 128);
            btnAcao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcao.Location = new Point(239, 260);
            btnAcao.Name = "btnAcao";
            btnAcao.Size = new Size(75, 23);
            btnAcao.TabIndex = 8;
            btnAcao.Text = "Salvar";
            btnAcao.UseVisualStyleBackColor = false;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(30, 264);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(54, 19);
            chkEstado.TabIndex = 7;
            chkEstado.Text = "Ativo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(23, 246);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado:";
            // 
            // btnCategoria
            // 
            btnCategoria.BackColor = Color.FromArgb(128, 255, 128);
            btnCategoria.Location = new Point(163, 156);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(139, 23);
            btnCategoria.TabIndex = 5;
            btnCategoria.Text = "Criar nova categoria";
            btnCategoria.UseVisualStyleBackColor = false;
            // 
            // grpCategoria
            // 
            grpCategoria.Controls.Add(cboCategoria);
            grpCategoria.Location = new Point(13, 174);
            grpCategoria.Name = "grpCategoria";
            grpCategoria.Size = new Size(273, 53);
            grpCategoria.TabIndex = 4;
            grpCategoria.TabStop = false;
            grpCategoria.Text = "CATEGORIA:";
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(17, 22);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(243, 23);
            cboCategoria.TabIndex = 0;
            // 
            // lblEstoqueMinimo
            // 
            lblEstoqueMinimo.AutoSize = true;
            lblEstoqueMinimo.Location = new Point(13, 122);
            lblEstoqueMinimo.Name = "lblEstoqueMinimo";
            lblEstoqueMinimo.Size = new Size(97, 15);
            lblEstoqueMinimo.TabIndex = 3;
            lblEstoqueMinimo.Text = "Estoque mínimo:";
            // 
            // lblPrecoUnidade
            // 
            lblPrecoUnidade.AutoSize = true;
            lblPrecoUnidade.Location = new Point(13, 87);
            lblPrecoUnidade.Name = "lblPrecoUnidade";
            lblPrecoUnidade.Size = new Size(94, 15);
            lblPrecoUnidade.TabIndex = 2;
            lblPrecoUnidade.Text = "Preço (unidade):";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(13, 51);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(72, 15);
            lblQuantidade.TabIndex = 1;
            lblQuantidade.Text = "Quantidade:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(13, 10);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 0;
            lblDescricao.Text = "Descrição:";
            // 
            // lblAlertaSucesso
            // 
            lblAlertaSucesso.AutoSize = true;
            lblAlertaSucesso.BackColor = Color.FromArgb(128, 255, 128);
            lblAlertaSucesso.Location = new Point(113, 285);
            lblAlertaSucesso.Name = "lblAlertaSucesso";
            lblAlertaSucesso.Size = new Size(104, 15);
            lblAlertaSucesso.TabIndex = 13;
            lblAlertaSucesso.Text = "Cadastro efetuado";
            // 
            // lblAlertaProduto
            // 
            lblAlertaProduto.AutoSize = true;
            lblAlertaProduto.BackColor = Color.FromArgb(255, 128, 255);
            lblAlertaProduto.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlertaProduto.Location = new Point(231, 33);
            lblAlertaProduto.Name = "lblAlertaProduto";
            lblAlertaProduto.Size = new Size(83, 12);
            lblAlertaProduto.TabIndex = 14;
            lblAlertaProduto.Text = "Produto já existente";
            // 
            // lblAlertaVazio
            // 
            lblAlertaVazio.AutoSize = true;
            lblAlertaVazio.BackColor = Color.FromArgb(255, 128, 255);
            lblAlertaVazio.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlertaVazio.Location = new Point(13, 140);
            lblAlertaVazio.Name = "lblAlertaVazio";
            lblAlertaVazio.Size = new Size(194, 12);
            lblAlertaVazio.TabIndex = 15;
            lblAlertaVazio.Text = "Obrigatório o preenchimento dos campos acima";
            // 
            // lblAvisoEstoqueMinimo
            // 
            lblAvisoEstoqueMinimo.AutoSize = true;
            lblAvisoEstoqueMinimo.BackColor = Color.FromArgb(255, 128, 255);
            lblAvisoEstoqueMinimo.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvisoEstoqueMinimo.Location = new Point(215, 101);
            lblAvisoEstoqueMinimo.Name = "lblAvisoEstoqueMinimo";
            lblAvisoEstoqueMinimo.Size = new Size(110, 36);
            lblAvisoEstoqueMinimo.TabIndex = 16;
            lblAvisoEstoqueMinimo.Text = "Obrigatóriamente estoque\r\n mínimo deve ser menor\r\nque o Estoque";
            // 
            // lblAlertaValor
            // 
            lblAlertaValor.AutoSize = true;
            lblAlertaValor.BackColor = Color.FromArgb(255, 128, 255);
            lblAlertaValor.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblAlertaValor.Location = new Point(238, 68);
            lblAlertaValor.Name = "lblAlertaValor";
            lblAlertaValor.Size = new Size(92, 26);
            lblAlertaValor.TabIndex = 17;
            lblAlertaValor.Text = "Obrigatóriamente\r\npreço maior que 0";
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 324);
            Controls.Add(pnlCadastroProduto);
            Name = "CadastroProduto";
            Text = "CadastroProduto";
            pnlCadastroProduto.ResumeLayout(false);
            pnlCadastroProduto.PerformLayout();
            grpCategoria.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCadastroProduto;
        private Label lblDescricao;
        private GroupBox grpCategoria;
        private Label lblEstoqueMinimo;
        private Label lblPrecoUnidade;
        private Label lblQuantidade;
        private Button btnCategoria;
        private ComboBox cboCategoria;
        private TextBox txtValor;
        private TextBox txtQuantidade;
        private TextBox txtDescricao;
        private Button btnAcao;
        private CheckBox chkEstado;
        private Label lblEstado;
        private TextBox txtEstoqueMinimo;
        private Label lblAlertaVazio;
        private Label lblAlertaProduto;
        private Label lblAlertaSucesso;
        private Label lblAlertaValor;
        private Label lblAvisoEstoqueMinimo;
    }
}