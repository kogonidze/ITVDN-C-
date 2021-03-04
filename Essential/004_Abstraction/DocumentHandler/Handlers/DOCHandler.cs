using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentHandler.Handlers
{
    class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("DOC file has changed!");
        }

        public override void Create()
        {
            Console.WriteLine("DOC file has created!");
        }

        public override void Open()
        {
            Console.WriteLine("DOC file has opened!");
        }

        public override void Save()
        {
            Console.WriteLine("DOC file has saved!");
        }
    }
}
