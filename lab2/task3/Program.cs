using System;

namespace lab2.Task3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Базовая версия ===");
            DocumentWorker worker = new DocumentWorker();
            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();

            Console.WriteLine("\n=== Версия Pro ===");
            worker = new ProDocumentWorker();
            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();

            Console.WriteLine("\n=== Версия Expert ===");
            worker = new ExpertDocumentWorker();
            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();
        }
    }
}