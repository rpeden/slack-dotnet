using System;
using System.Threading.Tasks;

namespace Slack_App
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = "your-token-goes-here";
            var writer = new SlackMessageWriter(token);
            Task.WaitAll(writer.WriteMessage("Hello from C#!"));
        }
    }
}
