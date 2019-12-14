using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TIWP_APS_NET_FRAMEWORK_CORE.Controllers
{
    public class StartController : Controller
	{
		public IActionResult Start()
		{
			return View();
		}
		public IActionResult Plan()
		{
			return View();
		}
	}
}