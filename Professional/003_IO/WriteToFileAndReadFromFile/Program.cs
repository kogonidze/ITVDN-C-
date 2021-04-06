using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteToFileAndReadFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var pathToExampleFolder = AppDomain.CurrentDomain.BaseDirectory;
            var inputFileName = ConfigurationManager.AppSettings["InputFileName"];
            var pathToFile = Path.Combine(pathToExampleFolder, inputFileName);

            using (FileStream fs = new FileStream(pathToFile, FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(Constants.FileText);
                }
            }

            FileStream fs2 = new FileStream(pathToFile, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs2);

            string input;

            while(!string.IsNullOrEmpty(input = sr.ReadLine()))
            {
                Console.WriteLine(input);
            }    

            sr.Close();
            fs2.Close();
            
            Console.ReadKey();
        }
    }
}
