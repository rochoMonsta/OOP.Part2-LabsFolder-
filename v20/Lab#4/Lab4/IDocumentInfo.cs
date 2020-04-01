using System;

namespace Lab4
{
    interface IDocumentInfo<T>
    {
        T SendingBy { get; set; }
        T SendingTo { get; set; }
        string DocumentFilling { get; set; }
    }
}
