using System;

namespace Lab4
{
    class PrintByUsing<T> where T: IDocumentInfo<Person>, IInfo
    {
        public void PrintDocument(T printer)
        {
            Console.WriteLine("-----PRINTING DOCUMENT-----");
            Console.WriteLine($"Document sending by\n\t{printer.SendingBy}");
            Console.WriteLine($"Document sending to\n\t{printer.SendingTo}\n");
            Console.WriteLine($"Text\n\t{printer.DocumentFilling}");
            Console.WriteLine($"\nDocument printed by\n\t{printer}");
        }
    }
}
