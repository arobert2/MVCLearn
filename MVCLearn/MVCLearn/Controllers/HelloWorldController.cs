using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCLearn.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public string Welcome(string name, int numTimes = 1)
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            for (int i = 0; i < numTimes; i++)
                sb.Append($"Hello {name}, Print Number: {i}");

            return HtmlEncoder.Default.Encode(sb.ToString());
        }
    }
}
