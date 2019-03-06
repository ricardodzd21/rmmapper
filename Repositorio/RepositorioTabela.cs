using Dapper;
using RMMapperApp.Base;
using RMMapperApp.Dominio;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace RMMapperApp.Repositorio
{
	public class RepositorioTabela : RepositorioBase
	{

		public List<Tabela> GetAll()
		{
			try
			{
				SqlConnection SqlCon = new SqlConnection("Data Source=" + Servidor.NomeServidor + ";  Initial Catalog=" + Servidor.Catalogo + "; User Id=" + Servidor.Usuario + "; Password=" + Servidor.Senha);
				string query = "select name Nome from sys.tables order by 1 desc";
				return SqlCon.Query<Tabela>(query).ToList();
			}
			catch 
			{
				return null;
			}
		}
	}
}
