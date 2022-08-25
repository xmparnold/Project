using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Blight.Models;
using Blight.Engine;

namespace Blight.Controllers;

public class BlightController : Controller
{

    private int? uid
    {
        get
        {
            return HttpContext.Session.GetInt32("UUID");
        }
    }

    private bool loggedIn
    {
        get
        {
            return uid != null;
        }
    }

    [HttpGet("/playblight")]
    public IActionResult PlayBlight()
    {
        if (!loggedIn)
        {
            return RedirectToAction("Index", "User");
        }

        

        Game newGame = new Game();

        return View("PlayBlight");
    }






}