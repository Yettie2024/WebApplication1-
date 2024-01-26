using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebApplication1.Controllers;

public class HelloWorldController : Controller
{
    // GET: /HelloWorld

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }

    //public string Index()
    //{
        //return "This is my default action...";
    //}
    
    //
    // GET: /HelloWorld/Welcome/
    // Requires using System.Text.Encodings.Web;
    //public string Welcome(string name, int ID = 1)
    //{
        //return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    //}

}

