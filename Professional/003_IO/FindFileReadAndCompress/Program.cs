using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFileReadAndCompress
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFilePath = ConfigurationManager.AppSettings["InputFilePath"];
            var compressedFilePath = ConfigurationManager.AppSettings["CompressedFilePath"];

            if (CheckIfFileExists(inputFilePath))
            {
                OpenFileInNotepad(inputFilePath);

                Console.WriteLine(Constants.AskIfCompress);

                var answer = Console.ReadLine();

                if (answer == Constants.Yes)
                {
                    CompressFile(inputFilePath, compressedFilePath);
                }
            }

            Console.WriteLine(Constants.FinishedMsg);

            Console.ReadKey();
        }

        static void OpenFileInNotepad(string inputFilePath)
        {
            var process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                FileName = inputFilePath
            };

            process.Start();
            process.WaitForExit();
        }

        static bool CheckIfFileExists(string inputFilePath)
        {
            try
            {
                using (var fs = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
                {
                    return true;
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(Constants.FileNotFoundMsg);
            }

            return false;
        }

        static void CompressFile(string inputFilePath, string compressedFilePath)
        {
            using (var sourceStream = new FileStream(inputFilePath, FileMode.OpenOrCreate))
            {
                using (var destinationStream = new FileStream(compressedFilePath, FileMode.Create))
                {
                    using (var compressionStream = new GZipStream(destinationStream, CompressionMode.Compress))
                    {
                        sourceStream.CopyTo(compressionStream);
                    }
                }
            }
        }
    }
}
