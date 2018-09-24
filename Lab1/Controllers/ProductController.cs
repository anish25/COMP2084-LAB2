using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        //Get Product/Details
        public ActionResult details(string ProductName)
        {
            ViewBag.ProductName = ProductName;
            return View();
        }
    }

    
 }
