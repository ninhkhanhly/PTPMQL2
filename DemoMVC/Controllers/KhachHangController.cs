using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
namespace DemoMVC.Controllers;

public class KhachHangController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(KhachHang kh)
    {
        string strResult = "Hello" + kh.KhachHangName;
        ViewBag.thongbao = strResult;
        return View();
    }
}