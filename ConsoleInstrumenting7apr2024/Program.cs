using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.Configuration;

using static System.Console;

namespace ConsoleInstrumenting7apr2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/markjprice/cs9dotnet5
            WriteLine("C# 9 and .NET 5 - Modern Cross-Platform Development by Mark J. Price");
            WriteLine("Chapter 4");
            WriteLine();

            // write to a text file in the project folder
            Trace.Listeners.Add(new TextWriterTraceListener(
              File.CreateText("log.txt")));

            // text writer is buffered, so this option calls
            // Flush() on all listeners after writing
            Trace.AutoFlush = true;

            Debug.WriteLine("Debug says, I am watching!");
            Trace.WriteLine("Trace says, I am watching!");

            //var builder = new ConfigurationBuilder()
            //  .SetBasePath(Directory.GetCurrentDirectory())
            //  .AddJsonFile("appsettings.json",
            //    optional: true, reloadOnChange: true);

            //IConfigurationRoot configuration = builder.Build();

            var ts = new TraceSwitch(
              displayName: "PacktSwitch",
              description: "This switch is set via a JSON config.");

            //configuration.GetSection("PacktSwitch").Bind(ts);

            Trace.WriteLineIf(ts.TraceError, "Trace error");
            Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
            Trace.WriteLineIf(ts.TraceInfo, "Trace information");
            Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");

            ReadKey();
        }
    }
}
