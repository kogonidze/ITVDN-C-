using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class Program
    {
        static void Main(string[] args)
        {
            var classRoom1 = new ClassRoom(new BadPupil(), new GoodPupil(), new BadPupil(), new ExcellentPupil());

            classRoom1.ShowHowPupilsRead();
            Console.WriteLine(new string('-',50));

            classRoom1.ShowHowPupilsRelax();
            Console.WriteLine(new string('-', 50));

            var classRoom2 = new ClassRoom(new ExcellentPupil(), new BadPupil());
            classRoom2.ShowHowPupilsStudy();
            Console.WriteLine(new string('-', 50));
            classRoom2.ShowHowPupilsWrite();

            Console.ReadKey();
        }
    }
}
