global using static Estoque.Domain.Tools.Utils;
using Estoque.Domain.MVC.Dao;

namespace Estoque
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			DaoConnection.ConnectionString = @$"{Environment.CurrentDirectory}\DataBase.db";
			using var dao = new DaoConnection();

			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new FrmMain());
		}
	}
}