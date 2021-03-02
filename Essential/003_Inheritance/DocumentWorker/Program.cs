using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyPro = "PRO";
            var keyExpert = "EXPERT";

            Console.WriteLine("Enter register key: ");
            var answerFromUser = Console.ReadLine();
            DocumentWorker worker = null;
            if (answerFromUser == keyPro)
            {
                worker = new ProDocumentWorker();
            }
            else if(answerFromUser == keyExpert)
            {
                worker = new ExpertDocumentWorker();
            }
            else
            {
                worker = new DocumentWorker();
            }

            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();

            Console.ReadKey();
        }
    }
}
