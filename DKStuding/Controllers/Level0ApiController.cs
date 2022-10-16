using Microsoft.AspNetCore.Mvc;

namespace DKStuding.Controllers
{
    [ApiController]
    [Route("Level0/Api/[action]")]
    public class Level0ApiController : Controller
    {
        [HttpGet]
        public string Index()
        {
            return "Index page";
        }

        [HttpGet]
        public string Hello(string name)
        {
            return "Hello " + name + "!";
        }

        [HttpGet]
        public int Abs(int x)
        {
            return Math.Abs(x);
        }

        [HttpGet]
        public int Summ3(int x, int y, int z)
        {
            return x + y + z;
        }
        
        [HttpGet]
        public int Mult2(int x, int y)
        {
            return x * y;
        }
    }
}
