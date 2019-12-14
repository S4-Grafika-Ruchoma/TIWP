using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TIWP_APS_NET_FRAMEWORK_CORE.Controllers
{
	public class FrameworkController : Controller
	{
		public IActionResult Intro()
		{
			return View();
		}

		public IActionResult Pros()
		{
			return View();
		}

		public IActionResult Cons()
		{
			return View();
		}
	}
}