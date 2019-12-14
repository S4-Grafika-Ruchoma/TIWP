using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TIWP_APS_NET_FRAMEWORK_CORE.Models;

namespace TIWP_APS_NET_FRAMEWORK_CORE.Controllers
{
    public class RazorController : Controller
	{
		public IActionResult Intro()
		{
			return View();
		}
		public IActionResult Intro2()
		{
			return View();
		}
		public IActionResult Intro3()
		{
			return View();
		}

		public IActionResult Dane()
		{
			return View();
		}
		public IActionResult Dane2()
		{
			return View();
		}

		public IActionResult Modele()
		{
			var model = new Auto()
			{
				Marka = "Volvo",
				Model = "V40"
			};
			
			//var model = new List<Auto>(){
			//	new Auto()
			//	{
			//		Marka = "Volvo",
			//		Model = "V40"
			//	},
			//	new Auto()
			//	{
			//		Marka = "Volvo 2 ",
			//		Model = "V4022"
			//	}
			//};

			return View(model);
		}
	}
}