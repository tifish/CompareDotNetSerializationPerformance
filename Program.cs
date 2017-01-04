using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareYamlAndToml
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var stopwatch = Stopwatch.StartNew();
                using (var fs = new Newtonsoft.Json.JsonTextReader(new StreamReader("sample1.json")))
                {
                    var serializer = new Newtonsoft.Json.JsonSerializer();
                    serializer.Deserialize(fs);
                }
                stopwatch.Stop();
                Console.WriteLine("Read Json using {0} ms", stopwatch.ElapsedMilliseconds);
            }

            {
                var stopwatch = Stopwatch.StartNew();
                using (var fs = new StreamReader("sample1.yaml"))
                {
                    var stream = new YamlDotNet.RepresentationModel.YamlStream();
                    stream.Load(fs);
                }
                stopwatch.Stop();
                Console.WriteLine("Read Yaml using {0} ms", stopwatch.ElapsedMilliseconds);
            }

            {
                var stopwatch = Stopwatch.StartNew();
                Nett.Toml.ReadFile("sample1.toml");
                stopwatch.Stop();
                Console.WriteLine("Read Toml using {0} ms", stopwatch.ElapsedMilliseconds);
            }

        }
    }
}
