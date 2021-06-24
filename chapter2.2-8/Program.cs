using System;

namespace chapter2._2_8
{
    class GenericCounter<T>
    {
        private static int value; //每个封闭的、已构造类型对应一个字段
           static GenericCounter()
          {
            Console.WriteLine("Initializing counter for {0}", typeof(T));
          }
        public static void Increment()
            {
            value++;
            }
        public static void Display()
        {
            Console.WriteLine("Counter for {0}: {1}", typeof(T), value);
        }
    }
    class GenericCounterDemo
    {
        static void Main()
        {
            GenericCounter<string>.Increment();
            GenericCounter<string>.Increment();
            GenericCounter<string>.Display();
            GenericCounter<int>.Display();
            GenericCounter<int>.Increment();
            GenericCounter<int>.Display();
            Console.ReadKey();
        }
    }
}
