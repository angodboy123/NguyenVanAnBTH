using Microsoft.AspNetCore.Mvc;
using NguyenVanAnBTH.Models;
using NguyenVanAnBTH.Models.Process;
namespace NguyenVanAnBTH.Controllers
{
    public class DemoController : Controller
    {
        //Chuyen kieu du lieu
        //string x="100";=> y=int.Parse("100");
        GPT giai = new GPT();
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(string hesoA,string hesoB,string hesoC)
        {
            double a=Convert.ToDouble(hesoA);
            double b=Convert.ToDouble(hesoB);
            double c=Convert.ToDouble(hesoC);
            string mess=giai.ptbh(a,b,c);
            ViewBag.thongbao=mess;
            return View();
        }
    }
    public IActionResult XuLyChuoi ()
{
    return View();
}
[HttpPost]
public IActionResult XulyChuoi(string strInput)
{
        public string RemoveRemainingWhiteSpace (string strInput)
    // Viewbag
    ViewBag.thongTin = strPro.RemoveRemainingWhiteSpace
    
    return View();
}
}

