using Nancy;
using System.Threading.Tasks;

namespace SimpleNancyExample
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get("/", x => "Hello World!");

            Get("/hello/async/{name:alpha}", GetHelloNameAsync);

            Get("/hello/sync/{name:alpha}", parameters => $"Hello {parameters.name}!");
        }
        
        // Simulate async function
        private async Task<object> GetHelloNameAsync(dynamic parameters)
        {
            string name = parameters.name;
            string result = "";
            await Task.Run(() => result = $"Hello {name}!");
            return result;
        }
    }
}