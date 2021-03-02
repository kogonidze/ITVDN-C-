using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Access is open");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Document edition is available in Pro version");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Document saving is available in Pro version");
        }
    }
}
