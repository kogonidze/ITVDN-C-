using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class GoodPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("Good pupil reads almost the whole program");
        }

        public override void Relax()
        {
            Console.WriteLine("Good pupil rarely relaxes");
        }

        public override void Study()
        {
            Console.WriteLine("Good pupil studies bona fide");
        }

        public override void Write()
        {
            Console.WriteLine("Good pupil writes diligently");
        }
    }
}
