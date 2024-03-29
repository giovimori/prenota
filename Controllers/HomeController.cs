﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using prenota.Models;
using prenota_5h.Models;

namespace prenota_5h.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;


    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Prenota()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Prenotato( Utente u )
    {
        Database db = new ();
        db.Utenti.Add(u);
        db.SaveChanges();
        return View(db);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
