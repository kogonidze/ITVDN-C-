using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Method Study() from base class");
        }

        public virtual void Read()
        {
            Console.WriteLine("Method Read() from base class");
        }

        public virtual void Write()
        {
            Console.WriteLine("Method Write() from base class");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Method Relax() from base class");
        }
    }
}
