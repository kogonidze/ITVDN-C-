using Document.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    class Document
    {
        DocumentPart header;
        DocumentPart body;
        DocumentPart footer;

        void InitializeDocument()
        {
            this.header = new Header();
            this.body = new Body();
            this.footer = new Footer();
        }

        public Document(string header)
        {
            InitializeDocument();
            this.header.Content = header;
        }

        public void Show()
        {
            header.Show();
            body.Show();
            footer.Show();
        }

        public string Body
        {
            set
            {
                this.body.Content = value;
            }
        }

        public string Footer
        {
            set
            {
                this.footer.Content = value;
            }
        }
    }
}
