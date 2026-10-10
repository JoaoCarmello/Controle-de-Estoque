namespace controleEstoque
{
    partial class frmControleEstoque
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblSubTitulo = new Label();
            gbMovimentacao = new GroupBox();
            btnSair = new Button();
            btnLimpar = new Button();
            gbEstoqueFinal = new GroupBox();
            lblEstoqueFinal = new Label();
            gbIDMovimentacao = new GroupBox();
            lblIDMovimentacao = new Label();
            lblResultado = new Label();
            btnRegistrar = new Button();
            lblQuantidade = new Label();
            nudQuantidade = new NumericUpDown();
            cboTipo = new ComboBox();
            cboProdutos = new ComboBox();
            lblTipoMovimentacao = new Label();
            lblProduto = new Label();
            gbMovimentacao.SuspendLayout();
            gbEstoqueFinal.SuspendLayout();
            gbIDMovimentacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F);
            lblTitulo.Location = new Point(12, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(232, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Controle de Estoque";
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.AutoSize = true;
            lblSubTitulo.Font = new Font("Segoe UI", 10F);
            lblSubTitulo.Location = new Point(17, 46);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(266, 19);
            lblSubTitulo.TabIndex = 1;
            lblSubTitulo.Text = "Registro de entradas e saídas de produtos";
            // 
            // gbMovimentacao
            // 
            gbMovimentacao.Controls.Add(btnSair);
            gbMovimentacao.Controls.Add(btnLimpar);
            gbMovimentacao.Controls.Add(gbEstoqueFinal);
            gbMovimentacao.Controls.Add(gbIDMovimentacao);
            gbMovimentacao.Controls.Add(lblResultado);
            gbMovimentacao.Controls.Add(btnRegistrar);
            gbMovimentacao.Controls.Add(lblQuantidade);
            gbMovimentacao.Controls.Add(nudQuantidade);
            gbMovimentacao.Controls.Add(cboTipo);
            gbMovimentacao.Controls.Add(cboProdutos);
            gbMovimentacao.Controls.Add(lblTipoMovimentacao);
            gbMovimentacao.Controls.Add(lblProduto);
            gbMovimentacao.Location = new Point(12, 85);
            gbMovimentacao.Name = "gbMovimentacao";
            gbMovimentacao.Size = new Size(392, 393);
            gbMovimentacao.TabIndex = 2;
            gbMovimentacao.TabStop = false;
            gbMovimentacao.Text = "Dados da movimentação";
            // 
            // btnSair
            // 
            btnSair.Location = new Point(205, 361);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(174, 25);
            btnSair.TabIndex = 14;
            btnSair.Text = "&Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(204, 201);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(174, 31);
            btnLimpar.TabIndex = 10;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // gbEstoqueFinal
            // 
            gbEstoqueFinal.Controls.Add(lblEstoqueFinal);
            gbEstoqueFinal.Location = new Point(204, 266);
            gbEstoqueFinal.Name = "gbEstoqueFinal";
            gbEstoqueFinal.Size = new Size(174, 89);
            gbEstoqueFinal.TabIndex = 13;
            gbEstoqueFinal.TabStop = false;
            gbEstoqueFinal.Text = "Estoque final";
            // 
            // lblEstoqueFinal
            // 
            lblEstoqueFinal.AutoSize = true;
            lblEstoqueFinal.Font = new Font("Segoe UI", 12F);
            lblEstoqueFinal.Location = new Point(6, 36);
            lblEstoqueFinal.Name = "lblEstoqueFinal";
            lblEstoqueFinal.Size = new Size(0, 21);
            lblEstoqueFinal.TabIndex = 15;
            // 
            // gbIDMovimentacao
            // 
            gbIDMovimentacao.Controls.Add(lblIDMovimentacao);
            gbIDMovimentacao.Location = new Point(15, 266);
            gbIDMovimentacao.Name = "gbIDMovimentacao";
            gbIDMovimentacao.Size = new Size(174, 89);
            gbIDMovimentacao.TabIndex = 12;
            gbIDMovimentacao.TabStop = false;
            gbIDMovimentacao.Text = "ID da movimentação";
            // 
            // lblIDMovimentacao
            // 
            lblIDMovimentacao.AutoSize = true;
            lblIDMovimentacao.Font = new Font("Segoe UI", 12F);
            lblIDMovimentacao.Location = new Point(6, 36);
            lblIDMovimentacao.Name = "lblIDMovimentacao";
            lblIDMovimentacao.Size = new Size(0, 21);
            lblIDMovimentacao.TabIndex = 14;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 9F);
            lblResultado.Location = new Point(11, 248);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 11;
            lblResultado.Text = "Resultado";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(11, 201);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(178, 31);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar movimentação";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Font = new Font("Segoe UI", 9F);
            lblQuantidade.Location = new Point(11, 138);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 7;
            lblQuantidade.Text = "Quantidade";
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(11, 156);
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(120, 23);
            nudQuantidade.TabIndex = 8;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(11, 102);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(215, 23);
            cboTipo.TabIndex = 6;
            // 
            // cboProdutos
            // 
            cboProdutos.FormattingEnabled = true;
            cboProdutos.Location = new Point(11, 49);
            cboProdutos.Name = "cboProdutos";
            cboProdutos.Size = new Size(215, 23);
            cboProdutos.TabIndex = 4;
            // 
            // lblTipoMovimentacao
            // 
            lblTipoMovimentacao.AutoSize = true;
            lblTipoMovimentacao.Font = new Font("Segoe UI", 9F);
            lblTipoMovimentacao.Location = new Point(11, 84);
            lblTipoMovimentacao.Name = "lblTipoMovimentacao";
            lblTipoMovimentacao.Size = new Size(130, 15);
            lblTipoMovimentacao.TabIndex = 5;
            lblTipoMovimentacao.Text = "Tipo de movimentação";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI", 9F);
            lblProduto.Location = new Point(11, 31);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(50, 15);
            lblProduto.TabIndex = 3;
            lblProduto.Text = "Produto";
            // 
            // frmControleEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 489);
            Controls.Add(gbMovimentacao);
            Controls.Add(lblSubTitulo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmControleEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Estoque";
            gbMovimentacao.ResumeLayout(false);
            gbMovimentacao.PerformLayout();
            gbEstoqueFinal.ResumeLayout(false);
            gbEstoqueFinal.PerformLayout();
            gbIDMovimentacao.ResumeLayout(false);
            gbIDMovimentacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubTitulo;
        private GroupBox gbMovimentacao;
        private Label lblTipoMovimentacao;
        private Label lblProduto;
        private ComboBox cboProdutos;
        private GroupBox gbEstoqueFinal;
        private GroupBox gbIDMovimentacao;
        private Label lblResultado;
        private Button btnRegistrar;
        private Label lblQuantidade;
        private NumericUpDown nudQuantidade;
        private ComboBox cboTipo;
        private Button btnLimpar;
        private Label lblEstoqueFinal;
        private Label lblIDMovimentacao;
        private Button btnSair;
    }
}
