using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document is opened");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Document editing is available in Pro version");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Document saving is available in Pro version");
        }
    }
}
