using Dapper;
using RMMapperApp.Base;
using RMMapperApp.Dominio;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace RMMapperApp.Repositorio
{
	public class RepositorioColuna : RepositorioBase
	{
		public List<Coluna> GetAll(Tabela tabela)
		{
			if (tabela == null)
				return null ;
			SqlConnection SqlCon = new SqlConnection("Data Source=" + Servidor.NomeServidor + ";  Initial Catalog=" + Servidor.Catalogo + "; User Id=" + Servidor.Usuario + "; Password=" + Servidor.Senha);
			string query = "SELECT COLUMN_NAME Nome, DATA_TYPE Tipo, CHARACTER_MAXIMUM_LENGTH Tamanho, IS_NULLABLE Nulo, COLUMN_NAME NomeDominio FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tabela.Nome + "'";
			return SqlCon.Query<Coluna>(query).ToList();
		}
	}
}
