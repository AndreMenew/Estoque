using Estoque.Domain.MVC.Controls;
using Estoque.Domain.MVC.Model;
using Estoque.Domain.Views;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Estoque
{
	public partial class FrmMain : MaterialForm
	{
		int? CurrentIdSelectedProduto { get;set; }
		List<ModelProdutos> Produtos { get; set; }

		public FrmMain()
		{
			InitializeComponent();

			var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.EnforceBackcolorOnAllComponents = true;
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
			
			Produtos = new List<ModelProdutos>();
			CurrentIdSelectedProduto = null;
		}

		private async void BtInserir_Click(object sender, EventArgs e)
		{
			//var model = new ModelProdutos()
			//{
			//	NomeProduto = TxNomeProduto.Text,
			//	Descricao = TxDescricao.Text,
			//	PrecoCusto = Convert.ToDecimal(TxPrecoCusto.Text),
			//	PrecoVenda = Convert.ToDecimal(TxPrecoVenda.Text)
			//};

			//await ControlProdutos.InserirProduto(model);

			//Produtos.Add(model);
			//Grid.DataSource = new { };
			//Grid.DataSource = Produtos;

			//ClearTextBox();
		}
		

		private async void FrmMain_Load(object sender, EventArgs e)
		{
			var view = new ViewProdutos()
			{
				Dock = DockStyle.Fill,
			};



			PageProdutos.Controls.Add(view);
		}

		private async void BtAtualizar_Click(object sender, EventArgs e)
		{
		}

		private void Grid_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			//this.CurrentIdSelectedProduto = Convert.ToInt32(Grid[0, e.RowIndex].Value);

			//TxNomeProduto.Text = Grid["NomeProduto", e.RowIndex].Value.ToString();
			//TxDescricao.Text = Grid["Descricao", e.RowIndex].Value.ToString();
			//TxPrecoCusto.Text = Grid["PrecoCusto", e.RowIndex].Value.ToString();
			//TxPrecoVenda.Text = Grid["PrecoVenda", e.RowIndex].Value.ToString();
		}
	}
}