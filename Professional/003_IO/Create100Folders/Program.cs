using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Create100Folders
{
    class Program
    {
        static void Main(string[] args)
        {
            var dirNames = CreateArrayOfDirNames();

            var pathToExampleDir = CreateExampleDirectory();

            CreateDirectories(dirNames, pathToExampleDir);
            Thread.Sleep(10000);
            RemoveDirectories(dirNames, pathToExampleDir);

            Console.WriteLine(Constants.FinishedMsg);

            Console.ReadKey();
        }

        static string[] CreateArrayOfDirNames()
        {
            var dirNamesArr = new string[Constants.CountOfDir];

            for (int i = 0; i < Constants.CountOfDir; i++)
            {
                dirNamesArr[i] = Constants.PermanentPartOfDirName + i;
            }

            return dirNamesArr;
        }

        static string CreateExampleDirectory()
        {
            var pathToExampleDir = Path.Combine(Constants.PathRoot, Constants.ExampleDirName);

            if (!Directory.Exists(pathToExampleDir))
            {
                Directory.CreateDirectory(pathToExampleDir);
            }

            return pathToExampleDir;
        }

        static void CreateDirectories(string[] dirNames, string pathToExampleDir)
        {
            foreach (var dir in dirNames)
            {
                var pathToCurrentDir = Path.Combine(pathToExampleDir, dir);

                if (!Directory.Exists(pathToCurrentDir))
                {
                    Directory.CreateDirectory(pathToCurrentDir);
                }
            }
        }

        static void RemoveDirectories(string[] dirNames, string pathToExampleDir)
        {
            foreach (var dir in dirNames)
            {
                var pathToCurrentDir = Path.Combine(pathToExampleDir, dir);

                if (Directory.Exists(pathToCurrentDir))
                {
                    Directory.Delete(pathToCurrentDir);
                }
            }
        }
    }
}
