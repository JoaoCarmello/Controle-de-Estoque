using System.Windows.Forms;
using controleEstoque.Controllers;
using controleEstoque.Models;

namespace controleEstoque
{
    public partial class frmControleEstoque : Form
    {
        private readonly MovimentacaoController _controller;
        private bool movimentacaoRegistrada = false;
        public frmControleEstoque()
        {
            InitializeComponent();
            _controller = new MovimentacaoController();

            ConfigurarFormulario();
            ConfigurarEventos();
            CarregarProdutos();
        }
        private void ConfigurarFormulario()
        {
            Text = "Controle de Estoque";
            StartPosition = FormStartPosition.CenterScreen;

            // Configuração dos produtos.
            cboProdutos.DropDownStyle = ComboBoxStyle.DropDownList;

            cboProdutos.DisplayMember = nameof(Produto.DescricaoProduto);

            cboProdutos.ValueMember = nameof(Produto.CodigoProduto);

            // Configuração do tipo de movimentação.
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;

            cboTipo.DataSource = Enum.GetValues(typeof(TipoMovimentacao));

            // Configuração da quantidade.
            nudQuantidade.Minimum = 1;
            nudQuantidade.Maximum = int.MaxValue;
            nudQuantidade.Value = 1;

            // Resultados iniciais.
            lblIDMovimentacao.Text = "-";
            lblEstoqueFinal.Text = "-";
        }

        private void ConfigurarEventos()
        {
            btnRegistrar.Click += btnRegistrar_Click;
            btnLimpar.Click += btnLimpar_Click;
        }

        private void CarregarProdutos()
        {
            try
            {
                cboProdutos.DataSource = _controller.ListarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar os produtos.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LimparCampos()
        {
            if (cboProdutos.Items.Count > 0)
                cboProdutos.SelectedIndex = 0;

            cboTipo.SelectedIndex = 0;
            nudQuantidade.Value = 1;

            lblIDMovimentacao.Text = "-";
            lblEstoqueFinal.Text = "-";

        }
        public void btnRegistrar_Click(object sender, EventArgs e)
        {

            try
            {
                if (cboProdutos.SelectedValue == null)
                {
                    MessageBox.Show("Selecione um produto.");
                    return;
                }

                if (cboTipo.SelectedItem == null)
                {
                    MessageBox.Show("Selecione o tipo de movimentação.");
                    return;
                }

                int codigoProduto = Convert.ToInt32(cboProdutos.SelectedValue);

                TipoMovimentacao tipo = (TipoMovimentacao)cboTipo.SelectedItem;

                int quantidade = Convert.ToInt32(nudQuantidade.Value);

                Movimentacao movimentacao = _controller.RegistrarMovimentacao(codigoProduto, tipo, quantidade);

                // Exibe os resultados da operação.
                lblIDMovimentacao.Text = movimentacao.Id.ToString();

                lblEstoqueFinal.Text = movimentacao.EstoqueFinal.ToString();

                MessageBox.Show($"Movimentação registrada com sucesso!\n\n" +
                    $"Identificador: {movimentacao.Id}\n" +
                    $"Produto: {movimentacao.DescricaoProduto}\n" +
                    $"Tipo: {movimentacao.DescricaoTipo}\n" +
                    $"Quantidade: {movimentacao.Quantidade}\n" +
                    $"Estoque final: {movimentacao.EstoqueFinal}",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                if (movimentacaoRegistrada)
                {
                    LimparCampos();
                    movimentacaoRegistrada = false;
                    return;
                }
                movimentacaoRegistrada = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Não foi possível registrar a movimentação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
