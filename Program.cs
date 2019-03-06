using RMMapperApp.Dominio;
using System;
using System.Windows.Forms;

namespace BemMapperApp
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			new Servidor();
			Application.Run(new frmPrincipal());
		}
	}
}
