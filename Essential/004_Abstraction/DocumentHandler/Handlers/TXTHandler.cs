using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentHandler.Handlers
{
    class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("TXT file has changed");
        }

        public override void Create()
        {
            Console.WriteLine("TXT file has created");
        }

        public override void Open()
        {
            Console.WriteLine("TXT file has opened");
        }

        public override void Save()
        {
            Console.WriteLine("TXT file has saved");
        }
    }
}
