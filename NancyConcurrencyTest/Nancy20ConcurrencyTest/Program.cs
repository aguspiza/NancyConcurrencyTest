using System;
using System.Threading.Tasks;
using Nancy;

namespace Nancy20ConcurrencyTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Nancy 2.0!");
			var nancyhost = new Nancy.Hosting.Self.NancyHost(new Uri("http://localhost:3333"));
			nancyhost.Start();
            Console.ReadLine();
        }
    }
}

public class NancyConcurrencyTestModule : NancyModule {
    public NancyConcurrencyTestModule()
    {
        //ping
        Get("/async", async (t, ct) => {
            await Task.Delay(5000);
            return "Hello world!";
        });
    }
}