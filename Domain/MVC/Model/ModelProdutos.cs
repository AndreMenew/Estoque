using SQLite;

namespace Estoque.Domain.MVC.Model
{
	[Table("Produtos")]
	internal class ModelProdutos
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string NomeProduto { get; set; }
		public string Descricao { get; set; }
		public string Ean { get; set; }
		public decimal PrecoCusto { get; set; }
		public decimal PrecoVenda { get; set; }
		public int IdFornecedor { get; set; }
	}
}
