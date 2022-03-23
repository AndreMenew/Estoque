using Estoque.Domain.MVC.Model;
using SQLite;

namespace Estoque.Domain.MVC.Dao
{
	internal class DaoConnection : IDisposable
	{
		public static string ConnectionString { get; set; }

		public DaoConnection()
		{
			this.Connection = new SQLiteAsyncConnection(ConnectionString);
			this.CreateTables();
		}

		public SQLiteAsyncConnection Connection { get; set; }

		async void CreateTables()
		{
			await this.Connection.CreateTableAsync<ModelProdutos>();
			await this.Connection.CreateTableAsync<ModelFornecedor>();
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}
	}
}
