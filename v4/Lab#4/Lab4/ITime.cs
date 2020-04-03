using System;

namespace Lab4
{
    interface ITime
    {
        DateTime DateTime { get; set; }
        DateTime GetCurrentTime();
        void SetCurrentTime();
    }
}
