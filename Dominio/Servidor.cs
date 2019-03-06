using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMapperApp.Dominio
{
	public class Servidor
	{
		static Configuration config;
		static AppSettingsSection section;

		public Servidor()
		{
			config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			section = config.GetSection("appSettings") as AppSettingsSection;
		}

		public static string NomeServidor
		{
			get { return section.Settings["NomeServidor"].Value; }
			set
			{
				section.Settings["NomeServidor"].Value = value;
				config.Save();
			}
		}
		public static string Usuario
		{
			get { return section.Settings["Usuario"].Value; }
			set
			{
				section.Settings["Usuario"].Value = value;
				config.Save();
			}
		}
		public static string Senha
		{
			get { return section.Settings["Senha"].Value; }
			set
			{
				section.Settings["Senha"].Value = value;
				config.Save();
			}
		}
		public static string Catalogo
		{
			get { return section.Settings["Catalogo"].Value; }
			set
			{
				section.Settings["Catalogo"].Value = value;
				config.Save();
			}
		}
	}
}
