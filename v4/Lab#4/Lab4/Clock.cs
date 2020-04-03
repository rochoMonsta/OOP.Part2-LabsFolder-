using System;

namespace Lab4
{
    class Clock<T> : ITime, IInfo<T>
    {
        public DateTime DateTime { get; set; }
        public string Name { get; set; }
        public T Owner { get; set; }

        public DateTime GetCurrentTime()
        {
            return DateTime;
        }

        public T GetOwner()
        {
            return Owner;
        }

        public void SetCurrentTime()
        {
            DateTime = DateTime.Now;
        }

        public void SetOwner(T owner)
        {
            Owner = owner;
        }
    }
}
