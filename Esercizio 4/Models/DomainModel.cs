using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Esercizio_4.Models
{
	public class DomainModel
	{
		Fasulla fasulla = new Fasulla();
		public List<Menu> GetLista(string a)
		{
			return fasulla.GetLista(a);
		}

		public Menu Search(int id)
		{
			return fasulla.Search(id);
		}
		public void Add(Menu menu)
		{
			fasulla.Add(menu);
		}
	}
	public class Menu
	{
		public int Id { get; set; }
		public DateTime Data { get; set; }
		public string Pasto { get; set; }
		public string Giorno { get; set; }
		public string Primo { get; set; }
		public string Secondo { get; set; }
		public string Contorno { get; set; }
		public string Dolce { get; set; }

	}
	public class Fasulla
	{
		public List<Menu> GetLista(string a)
		{

			return new List<Menu> {
				new Menu { Id=1,Data=DateTime.Now,Pasto="Pranzo",Giorno="Giovedi"} ,
				new Menu { Id=2,Data=DateTime.Now.AddDays(1),Pasto="Pranzo",Giorno="Venerdi"},
				new Menu { Id=3,Data=DateTime.Now.AddDays(1),Pasto="Cena",Giorno="Venerdi"},
				new Menu { Id=4,Data=DateTime.Now.AddDays(2),Pasto="Pranzo",Giorno="Sabato"},
				new Menu { Id=5,Data=DateTime.Now.AddDays(3),Pasto="Cena",Giorno="Sabato"},
				};
		}

		public Menu Search(int id)
		{
			Menu menu = new Menu();
			SqlConnection con = new SqlConnection(GetConnection());
			try {
				con.Open();
				SqlCommand command = new SqlCommand("Search",con);
				command.CommandType=System.Data.CommandType.StoredProcedure;
				command.Parameters.Add("@id",System.Data.SqlDbType.Int).Value=id;
				SqlDataReader reader= command.ExecuteReader();
				while(reader.Read()) {
					menu.
				}
				return menu;
			}catch(Exception x) { throw x; } finally {
				con.Dispose();
			}
			//return new Menu { Id = 77,Data = DateTime.Now,Pasto = "Pranzo",Giorno = "Mercoledi",Primo = "Orecchiette alle cime di nutria",Secondo = "Stufato di nutria",Contorno = "Patate fritte",Dolce = "Nutria Glassata" };
		}

		public void Add(Menu menu)
		{

		}
		private string GetConnection()
		{
			SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
			builder.DataSource = @"(localdb)\MSSQLLocalDB",
			builder.InitialCatalog = "DaCiccio";
			return builder.ToString();
		}
	}
}