using System.Web.Mvc;
using UIKit.Services;


namespace UIKit.Controllers
{
    public class HomeController : Controller
    {
        private DeviceService DeviceService = new DeviceService();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Devices()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult GetDeviceInfo(int deviceId = 1)
        {
            return PartialView(DeviceService.GetDevice(deviceId));
        }
    }
}