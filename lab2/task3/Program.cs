using System;

namespace lab2.Task3
{
    class Program
    {
        static void Main()
        {
            string key = Console.ReadLine();
            DocumentWorker worker = new();
            if (key == "base")
            {
                worker = new DocumentWorker();
            }

            if (key == "pro")
            {
                worker = new ProDocumentWorker();
            }

            if (key == "exp")
            {
                worker = new ExpertDocumentWorker()();
            }
            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();
        }
    }
}