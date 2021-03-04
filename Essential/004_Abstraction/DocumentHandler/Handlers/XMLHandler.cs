using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentHandler.Handlers
{
    class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("XML file has changed!");
        }

        public override void Create()
        {
            Console.WriteLine("XML file has created!");
        }

        public override void Open()
        {
            Console.WriteLine("XML file has opened!");
        }

        public override void Save()
        {
            Console.WriteLine("XML file has saved!");
        }
    }
}
