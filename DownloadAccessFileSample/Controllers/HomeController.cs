using DownloadAccessFileSample.Utilities;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Mvc;

namespace DownloadAccessFileSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public FileResult DownloadFile()
        {
            string oledbPath = OledbConnectionString.GetOledbConnection();
            //fileContent = GetFile(oledbPath);
            var fs = new FileStream(oledbPath, FileMode.Open);
            return File(fs, "application/octet-stream", "Test.mdb");
        }
    }
}