using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    class ExpertDocumentWorker:ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document is saved in new format");
        }
    }
}
