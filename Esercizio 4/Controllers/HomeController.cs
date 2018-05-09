using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Esercizio_4.Models;

namespace Esercizio_4.Controllers
{
	public class HomeController : Controller
	{
		DomainModel dm = new DomainModel();
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult ListaMenu()
		{
			ViewBag.ListaMenu = dm.GetLista();
			ViewBag.Message = "Your application description page.";
			return View();
		}
		public ActionResult Dettaglio(int id)
		{
			ViewBag.Menu = dm.Search(id);
			return View("DettaglioMenu");
		}
		public ActionResult DettaglioMenu()
		{
			return View();
		}
		public ActionResult AddMenu()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
		[HttpPost]
		public ActionResult AddMenu(DateTime data,
		string pasto,
		string giorno,
		string primo,
		string secondo,
		string contorno,
		string dolce)
		{
			Menu nuovo = new Menu { Data=data,Pasto=pasto,Primo=primo,Secondo=secondo,Giorno=giorno,Contorno=contorno,Dolce=dolce};
			try { 
			dm.Add(nuovo);
			}catch(Exception e) {
				throw e;

			} 
			ViewBag.Message="Menu aggiunto";
			return View("ListaMenu");

		}
	}
}