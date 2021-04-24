using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Decoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathToExampleFolder = AppDomain.CurrentDomain.BaseDirectory;
            var inputFileName = ConfigurationManager.AppSettings["InputFileName"];
            var outputFileName = ConfigurationManager.AppSettings["OutputFileName"];

            var text = File.ReadAllText(inputFileName);
            text = Regex.Replace(text, PatternConstants.PrepositionPattern, " ГАВ! ");
            File.WriteAllText(outputFileName, text);

            Console.ReadKey();
        }
    }
}
