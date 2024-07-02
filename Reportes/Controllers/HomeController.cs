using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidad;
using CapaNegocio;

namespace Reportes.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
		public ActionResult Usuarios()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
		[HttpGet]
		public JsonResult ListarUsuarios()
		{
			List<USUARIO> oLista = new CN_Usuario().Listar();

			// Verificar si la lista tiene datos
			System.Diagnostics.Debug.WriteLine($"Total de usuarios: {oLista.Count}");

			return Json(new { data = oLista }, JsonRequestBehavior.AllowGet);
		}

	}
}