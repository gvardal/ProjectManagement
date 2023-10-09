using Serilog;
using Serilog.Sinks.Graylog;


namespace GraylogClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Graylog settings up");
            SetupGraylog();
            Console.WriteLine("Graylog settings completed");

            Log.Error("Test Error Message");

            Console.WriteLine("Logs Completed");
            Console.ReadLine();
        }

        static void SetupGraylog()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Graylog(new GraylogSinkOptions()
                {
                    Facility = "GrayLogClient",
                    HostnameOrAddress = "localhost",
                    Port = 12201,
                    TransportType = Serilog.Sinks.Graylog.Core.Transport.TransportType.Udp
                })
                .CreateLogger();
        }
    }
}