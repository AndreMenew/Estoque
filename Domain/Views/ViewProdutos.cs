using Estoque.Domain.MVC.Controls;
using Estoque.Domain.MVC.Model;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Domain.Views
{
	public partial class ViewProdutos : UserControl
	{
		List<ModelProdutos> Produtos = new List<ModelProdutos>();
		int CurrentProdutoSelected { get; set; }

		public ViewProdutos()
		{
			InitializeComponent();
		}

		private void BtNovo_Click(object sender, EventArgs e)
		{
			TabMain.SelectedIndex = 1;
			ClearTextsBox();
		}

		private void BtCancelar_Click(object sender, EventArgs e)
		{
			ClearTextsBox();
			TabMain.SelectedIndex = 0;
		}

		void ClearTextsBox()
		{
			TxNomeProduto.Clear();
			TxDescricao.Clear();
			TxFornecedor.Clear();
			TxMargem.Text = "0";
			TxPrecoCusto.Text = "0,00";
			TxPrecoVenda.Text = "0,00";

			CurrentProdutoSelected = 0;
		}

		private async void ViewProdutos_Load(object sender, EventArgs e)
		{
			this.PageCadastroProdutos.BackColor =
				this.PageListProdutos.BackColor =
					this.BackColor = this.Parent.BackColor;

			LoadGrid();
		}


		async void LoadGrid()
		{
			GridProdutos.DataSource =
					Produtos = await ControlProdutos.PegarTodosProdutos();




			GridProdutos.Columns["Id"].Visible = false;
			GridProdutos.Columns["Ean"].Visible = false;
			GridProdutos.Columns["IdFornecedor"].Visible = false;

			GridProdutos.Columns["PrecoCusto"].ValueType = typeof(decimal);
			GridProdutos.Columns["PrecoVenda"].ValueType = typeof(decimal);
			GridProdutos.Columns["PrecoCusto"].DefaultCellStyle.Format = "c2";
			GridProdutos.Columns["PrecoVenda"].DefaultCellStyle.Format = "c2";


			GridProdutos.Columns["PrecoCusto"].HeaderText = "Preco custo";
			GridProdutos.Columns["PrecoVenda"].HeaderText = "Preco venda";
			GridProdutos.Columns["NomeProduto"].HeaderText = "Nome produto";
			GridProdutos.Columns["Descricao"].HeaderText = "Descrição";
		}

		private async void BtAtualizar_Click(object sender, EventArgs e)
		{

			if (CurrentProdutoSelected > 0)
			{
				var produto = await ControlProdutos.PegarProduto(CurrentProdutoSelected);

				TxNomeProduto.Text = produto.NomeProduto;
				TxDescricao.Text = produto.Descricao;
				TxFornecedor.Text = produto.IdFornecedor.ToString();
				TxPrecoCusto.Text = produto.PrecoCusto.ToString();
				TxPrecoVenda.Text = produto.PrecoVenda.ToString();
				TxMargem.Text = produto.Margem.ToString();

				TabMain.SelectedIndex = 1;
			}

		}

		private void GridProdutos_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			CurrentProdutoSelected = Convert.ToInt32(GridProdutos["Id", e.RowIndex].Value);
		}

		private async void BtSalvar_Click(object sender, EventArgs e)
		{
			var model = new ModelProdutos()
			{
				NomeProduto = TxNomeProduto.Text,
				Descricao = TxDescricao.Text,
				PrecoCusto = Convert.ToDecimal(TxPrecoCusto.Text),
				PrecoVenda = Convert.ToDecimal(TxPrecoVenda.Text),
				Ean = TxEan.Text,
				Margem = Convert.ToDecimal(TxMargem.Text),
			};


			if (CurrentProdutoSelected > 0)
			{
				/***
				 * Atualizar produtos
				 */
				model.Id = CurrentProdutoSelected;


				await ControlProdutos.AtualizarProduto(model);

				GridProdutos.DataSource = new { };
				GridProdutos.DataSource =
					Produtos = await ControlProdutos.PegarTodosProdutos();

				TabMain.SelectedIndex = 0;

				var snack = new MaterialSnackBar("Dados gravados com sucesso!", 2500, true, "Ok", false);
				snack.Show(this.ParentForm);
			}
			else
			{
				/***
				 * Inserir Produto
				 */

				await ControlProdutos.InserirProduto(model);

				GridProdutos.DataSource = new { };
				GridProdutos.DataSource =
					Produtos = await ControlProdutos.PegarTodosProdutos();

				TabMain.SelectedIndex = 0;

				var snack = new MaterialSnackBar("Dados gravados com sucesso!", 2500, true, "Ok", false);
				snack.Show(this.ParentForm);
			}

			LoadGrid();
		}

		private void TxPrecoCusto_TextChanged(object sender, EventArgs e) =>
			CalcularMargem();

		private void TxMargem_TextChanged(object sender, EventArgs e) =>
			CalcularMargem();

		void CalcularMargem()
		{
			if (string.IsNullOrEmpty(TxPrecoCusto.Text) || string.IsNullOrEmpty(TxMargem.Text))
				return;

			TxPrecoVenda.Text = CalculaMargem(
					Convert.ToDecimal(TxPrecoCusto.Text),
					Convert.ToDecimal(TxMargem.Text)
				).ToString();
		}
	}
}
