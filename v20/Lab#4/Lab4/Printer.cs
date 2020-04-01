using System;

namespace Lab4
{
    class Printer<T> : IInfo, IDocumentInfo<T>
    {
        public string Name { get; set; }
        public string Firm { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public T SendingBy { get; set; }
        public T SendingTo { get; set; }
        public string DocumentFilling { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Firm} - {Type} - {Price}";
        }
    }
}
