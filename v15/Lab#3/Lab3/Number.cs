using System;

namespace Lab3
{
    class Number
    {
        public int number { get; set; }
        public int id { get; set; }
        public Number() { }
        public Number(int number, int id)
        {
            if (id < 0)
                throw new ArgumentException(nameof(id), "Wrong id.");
            else
                this.id = id;

            try
            {
                this.number = number;
            }
            catch(Exception)
            {
                Console.WriteLine("Wrong type of number.");
                this.number = 0;
            }
        }
        public override string ToString()
        {
            return $"{number} - {id}";
        }
    }
}
