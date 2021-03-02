using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in old format, saving in another formats is available in Version Expert");
        }
    }
}
