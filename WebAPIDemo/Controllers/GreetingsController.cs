using System.Web.Http;

namespace WebAPIDemo.Controllers
{
    public class GreetingsController : ApiController
    {
        [Route("api/greetings/{name}")]
        [HttpGet]
        public string GetGreetings(string name)
        {
            return $"Hello {name}, Welcome to Web API";
        }
    }
}