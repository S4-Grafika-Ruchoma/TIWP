using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
	}
}