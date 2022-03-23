using SQLite;

namespace Estoque.Domain.MVC.Model
{
	[Table("Fornecedores")]
	internal class ModelFornecedor
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public string Nome { get; set; }
	}
}
