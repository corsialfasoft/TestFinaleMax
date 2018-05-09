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
		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}