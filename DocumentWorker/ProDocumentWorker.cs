using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    class ProDocumentWorker:DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document is edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document is saved in old format, saving in other formats is available in Expert version");
        }
    }
}
