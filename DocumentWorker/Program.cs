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
            Console.WriteLine("Please enter access key: pro/expert");
            string key = Console.ReadLine();

            switch (key)
            {
                case "pro":
                    {
                        DocumentWorker proVersion1 = new ProDocumentWorker();
                        proVersion1.OpenDocument();
                        proVersion1.EditDocument();
                        proVersion1.SaveDocument();
                        break;
                    }
                case "expert":
                    {
                        DocumentWorker expert1 = new ExpertDocumentWorker();
                        expert1.OpenDocument();
                        expert1.EditDocument();
                        expert1.SaveDocument();
                        break;
                    }
                default:
                    {
                        DocumentWorker basicVersion = new DocumentWorker();
                        basicVersion.OpenDocument();
                        basicVersion.EditDocument();
                        basicVersion.SaveDocument();
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
