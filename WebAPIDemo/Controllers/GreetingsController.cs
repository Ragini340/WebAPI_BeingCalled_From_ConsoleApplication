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

/*
 namespace CSharp_Practice.Asynchronous_Programming.Task_Class
 {
    //Calling Web API HTTP request from Console Application
    public class ReturnValueFromTask
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main method started......");
            Console.WriteLine("Enter the name: ");
            string Name = Console.ReadLine();
            Print(Name);
            Console.WriteLine("Main method end");
            Console.ReadKey();
        }

        public async static void Print(string Name)
        {
            Console.WriteLine("Print method started......");
            var GreetingSMessage = await Greetings(Name);
            Console.WriteLine($"\n{GreetingSMessage}");
            Console.WriteLine("Print method end");
        }

        public static async Task<string> Greetings(string Name)
        {
            string message = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44357/");
                HttpResponseMessage response = await client.GetAsync($"api/greetings/{Name}");
                message = await response.Content.ReadAsStringAsync();
            }
            return message;
        }

    }
}
 */