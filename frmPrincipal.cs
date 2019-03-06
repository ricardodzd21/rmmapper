using RMMapperApp.Dominio;
using RMMapperApp.Repositorio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BemMapperApp
{
	public partial class frmPrincipal : Form
	{
		#region ---- propriedades privadas ----
		private List<Coluna> Dados { get { return dgTabela.DataSource as List<Coluna>; } }
		private Tabela TabelaSelecionada { get { return cbTabelas.SelectedItem as Tabela; } }
		#endregion

		public frmPrincipal()
		{
			InitializeComponent();

			txtSenha.Text = Servidor.Senha;
			txtServidor.Text = Servidor.NomeServidor;
			txtCatalogo.Text = Servidor.Catalogo;
			txtUsuario.Text = Servidor.Usuario;
		}

		private void btnConectar_Click(object sender, EventArgs e)
		{
			SalvarConfigurações();
			cbTabelas.DataSource = new RepositorioTabela().GetAll();
			SalvarConfigurações();
		}

		private void cbTabelas_SelectedIndexChanged(object sender, EventArgs e)
		{
			var tabela = cbTabelas.SelectedItem as Tabela;
			dgTabela.DataSource = new RepositorioColuna().GetAll(tabela);
		}

		private void btnGerar_Click(object sender, EventArgs e)
		{
			CriarClasse();
			CriarSQLConsulta();
			CriarSQLInsert();
			CriarSQLUpdate();
			CriarSQLDelete();
			Process.Start("explorer.exe", @"c:\temp");
		}

		private void CriarClasse()
		{
			string dominio = string.Format(@"
namespace Dominio.{0}
[
	public class {1}Dominio
	[
		{2}
	]
]

", txtNameSpace.Text, txtNomeDominio.Text, CriarPropriedades());

			CriarAquivo(txtNomeDominio.Text, dominio.Replace("[", "{").Replace("]", "}"), "cs");
		}

		private string CriarPropriedades()
		{
			string propriedades = string.Empty;

			foreach (var item in Dados)
			{
				propriedades += string.Format(@"
		public {0} {1} [ get; set; ]
", item.TipoDominio, item.NomeDominio);
			}

			return propriedades;
		}

		private void CriarSQLConsulta()
		{
			StringBuilder retorno = new StringBuilder();

			foreach (var item in Dados)
			{
				if (string.IsNullOrEmpty(retorno.ToString()))
					retorno.Append("Select ");
				else
					retorno.Append(", ");
				retorno.Append(Environment.NewLine);
				retorno.Append(item.Nome);
				retorno.Append(" as ");
				retorno.Append(item.NomeDominio);
			}

			retorno.Append(Environment.NewLine);
			retorno.Append("From ");
			retorno.Append(Environment.NewLine);
			retorno.Append(TabelaSelecionada.Nome);
			CriarAquivo("Consulta", retorno.ToString(), "sql");
		}

		private void CriarSQLInsert()
		{
			StringBuilder retorno = new StringBuilder();
			retorno.Append("insert into ");
			retorno.Append(Environment.NewLine);
			retorno.Append(TabelaSelecionada.Nome);
			retorno.Append("(");
			retorno.Append(string.Join(",", Dados.Select(x => x.Nome)));
			retorno.Append(")");
			retorno.Append(Environment.NewLine);
			retorno.Append(" values ");
			retorno.Append("(");
			retorno.Append(string.Join(",", Dados.Select(x => x.NomeDominio)));
			retorno.Append(")");
			CriarAquivo("Insert", retorno.ToString(), "sql");
		}

		private void CriarSQLDelete()
		{
			StringBuilder retorno = new StringBuilder();
			retorno.Append("Delete ");
			retorno.Append(TabelaSelecionada.Nome);
			retorno.Append(" where ID = Id");
			CriarAquivo("Delete", retorno.ToString(), "sql");
		}

		private void CriarSQLUpdate()
		{
			StringBuilder retorno = new StringBuilder();

			foreach (var item in Dados)
			{
				if (string.IsNullOrEmpty(retorno.ToString()))
				{
					retorno.Append("Update ");
					retorno.Append(TabelaSelecionada.Nome);
					retorno.Append(" set ");
				}
				else
					retorno.Append(", ");
				retorno.Append(item.Nome);
				retorno.Append(" = ");
				retorno.Append(item.NomeDominio);
			}
			retorno.Append(Environment.NewLine);
			retorno.Append(" where ID = Id");
			CriarAquivo("Update", retorno.ToString(), "sql");
		}

		private void CriarAquivo(string nome, string retorno, string ext)
		{
			string file = "c:\\Temp\\" + nome + txtNomeDominio.Text + "." + ext;
			System.IO.File.Create(file).Close();
			StreamWriter streamWriter = new StreamWriter(file);
			streamWriter.Write(retorno);
			streamWriter.Dispose();
		}

		private void SalvarConfigurações()
		{
			Servidor.Catalogo = txtCatalogo.Text;
			Servidor.NomeServidor = txtServidor.Text;
			Servidor.Senha = txtSenha.Text;
			Servidor.Usuario = txtUsuario.Text;
		}
	}
}
