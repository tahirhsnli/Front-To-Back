﻿using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Contact()
		{
			return View();
		}
		public IActionResult ShopCategory()
		{
			return View();
		}
		public IActionResult Login()
		{
			return View();
		}
	}
}
