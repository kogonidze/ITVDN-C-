using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    class ExpertDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in the new format");
        }
    }
}
