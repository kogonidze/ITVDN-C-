using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    abstract class DocumentPart
    {
        private string content;

        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                if (value != "")
                {
                    content = value;
                }
                else
                {
                    Console.WriteLine("The part of document can not be null");
                }
            }
        }

        public abstract void Show();
    }
}
