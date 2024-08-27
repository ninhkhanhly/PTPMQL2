using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers;

public class HomeController : Controller
{

    public IActionResult Demo()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Demo(string FullName)
    {
        string str0utput = "tên sinh viên là " + FullName;
        ViewBag.thongbao = str0utput;
        return View();
    }

}
