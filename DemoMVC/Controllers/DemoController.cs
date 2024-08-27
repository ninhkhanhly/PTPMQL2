namespace DemoMVC.Controllers;
public class DemoController : Controller
{
    public IactionResult Index()
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