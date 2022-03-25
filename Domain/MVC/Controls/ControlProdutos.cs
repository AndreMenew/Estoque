using Estoque.Domain.MVC.Model;

namespace Estoque.Domain.MVC.Controls
{
	internal static class ControlProdutos
	{
		public static async Task InserirProduto(ModelProdutos produtos)
		{
			using (var dao = new Dao.DaoConnection())
			{
				await dao.Connection.InsertAsync(produtos);
			}
		}

		public static async Task<List<ModelProdutos>> PegarTodosProdutos()
		{
			var lista = new List<ModelProdutos>();
			using (var dao = new Dao.DaoConnection())
			{
				lista = await dao.Connection.QueryAsync<ModelProdutos>("SELECT * FROM Produtos");
			}

			return lista;
		}

		public static async Task AtualizarProduto(ModelProdutos produtos)
		{
			using (var dao = new Dao.DaoConnection())
			{
				await dao.Connection.UpdateAsync(produtos);
			}
		}

		internal async static Task<ModelProdutos?> PegarProduto(int idProduto)
		{
			var lista = new List<ModelProdutos>();
			using (var dao = new Dao.DaoConnection())
			{
				lista = await dao.Connection.QueryAsync<ModelProdutos>("SELECT * FROM Produtos WHERE Id = ?", idProduto);
			}

			return lista.FirstOrDefault();
		}
	}
}
