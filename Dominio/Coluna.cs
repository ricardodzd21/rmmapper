using System.Globalization;

namespace RMMapperApp.Dominio
{
	public class Coluna
	{
		private string _nomeDominio;		

		public string Nome { get; set; }
		public string Tipo { get; set; }
		public string Nulo { get; set; }
		public int? Tamanho { get; set; }
		public string NomeDominio { get { return _nomeDominio != null ? CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_nomeDominio.ToLower()).Replace("_", "") : string.Empty; } set { _nomeDominio = value; } }
		public string NomeDto { get { return _nomeDominio != null ? CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_nomeDominio.ToLower()).Replace("_", "") : string.Empty; } }
		public string TipoDominio
		{
			get
			{
				string nulo = Nulo == "YES" ? "?" : string.Empty;

				if (Tipo.Contains("int"))
					return "int" + nulo;
				else if (Tipo == "varchar")
					return "string";
				else if (Tipo == "datetime")
					return "DateTime" + nulo;
				else if (Tipo == "decimal")
					return "decimal" + nulo;
				else if (Tipo == "char")
					return "char" + nulo;
				return string.Empty;
			}
		}
	}
}
