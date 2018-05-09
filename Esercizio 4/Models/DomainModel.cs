using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Esercizio_4.Models
{
	public class DomainModel
	{
		Fasulla fasulla = new Fasulla() ;
		public List<Menu> GetLista()
		{
			return fasulla.GetLista();
		}

	}
	public class Menu
	{
		public int Id { get;set;}
		public DateTime Data { get;set;}
		public string Pasto { get;set;}
		public string Giorno { get;set;}

	}
	public class Fasulla
	{
		public List<Menu> GetLista()
		{
			return new List<Menu> {
				new Menu { Id=1,Data=DateTime.Now,Pasto="Pranzo",Giorno="Giovedi"} ,
				new Menu { Id=2,Data=DateTime.Now.AddDays(1),Pasto="Pranzo",Giorno="Venerdi"},
				new Menu { Id=3,Data=DateTime.Now.AddDays(1),Pasto="Cena",Giorno="Venerdi"},
				new Menu { Id=4,Data=DateTime.Now.AddDays(2),Pasto="Pranzo",Giorno="Sabato"},
				new Menu { Id=5,Data=DateTime.Now.AddDays(3),Pasto="Cena",Giorno="Sabato"},
				};
		}
	}
}