using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
namespace DemoMVC.Controllers;

public class DemoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Demo dm)
    {
        string strResult = "Hello" + dm.Fullname;
        ViewBag.thongbao = strResult;
        return View();
    }
}