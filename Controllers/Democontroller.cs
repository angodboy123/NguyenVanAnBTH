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
        StringProcess strPro = new StringProcess();
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
        
        public IActionResult Xulychuoi()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Xulychuoi(string strInput)
        {
            string strResult = strPro.khoangtrang(strInput);
            ViewBag.thongbao=strResult;
            return View();
        }
    }
}