using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class ExcellentPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Excellent pupil reads a lot!");
        }

        public override void Relax()
        {
            Console.WriteLine("Excellent pupil almost doesn`t relax!");
        }

        public override void Study()
        {
            Console.WriteLine("Excellent pupil studies hard!");
        }

        public override void Write()
        {
            Console.WriteLine("Excellent pupil writes a lot!");
        }
    }
}
