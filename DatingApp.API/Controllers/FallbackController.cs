using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    public class FallbackController : Controller
    {
        private readonly IHostingEnvironment _env;
        public FallbackController(IHostingEnvironment env)
        {
            _env = env;
        }
        public IActionResult Index()
        {
            return PhysicalFile(Path.Combine(_env.WebRootPath, "index.html"), "text/HTML");
        }
    }
}