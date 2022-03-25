using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Domain.Tools
{
	internal static class Utils
	{
		public static decimal CalculaMargem(decimal custo, decimal margem)
		{
			return custo + (custo * (margem/100));
		}
	}
}
