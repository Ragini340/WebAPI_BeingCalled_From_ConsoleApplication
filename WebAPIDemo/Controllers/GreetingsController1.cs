using System.Threading.Tasks;
using System.Web.Http;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace WebAPIDemo.Controllers
{
    public class GreetingsController1 : ApiController
    {
        [Route("api/greetings/{name}")]
        [HttpGet]
        public async Task<string> GetGreetingsAsync(string name)
        {
            await Task.Delay(5000);
            return $"Hello {name}, Welcome to Web API";
        }
    }
}

/*
namespace CSharp_Practice.Asynchronous_Programming.Task_Cancellation.Realtime_Example
{
    public class RealtimeEx_ToUnderstand_Cancellation
    {
        private static async void TestMethod(string Name)
        {
            Console.WriteLine("Test Method Started");
            using (var client = new HttpClient())
            {
                CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(3000); //If the cancellation delay time is 
                                                                                                     //very short, so it will cancel the 
                                                                                                     //operation before hiting endpoint.
                                                                                                     //Hence, we will not get the response
                                                                                                     //message of API.

                //If the cancellation delay time is more than sending then we are getting response for endpoint:
                //CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(10000);

                client.BaseAddress = new Uri("https://localhost:44357/");
                try
                {
                    Console.WriteLine("Test Method Calling Web API");
                    HttpResponseMessage response = await client.GetAsync($"api/greetings/{Name}", cancellationTokenSource.Token);
                    string message = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(message);
                }
                catch (TaskCanceledException ex)
                {
                    Console.WriteLine($"Task Execution Cancelled: {ex.Message}");
                }

                Console.WriteLine("Test Method Completed");
            }
        }

        public static void Main(string[] args)
        {
            string Name = "Ragini";
            TestMethod(Name);
            Console.ReadKey();
        }

    }
}
 */