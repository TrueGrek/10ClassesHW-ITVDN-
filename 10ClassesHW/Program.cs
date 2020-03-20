using System;

namespace _10ClassesHW
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = MyClass<int>.FactoryMethod();
            Console.WriteLine(i.GetType().Name);
            Program p = MyClass<Program>.FactoryMethod();
            Console.WriteLine(p.GetType().Name);
        }
    }
    class MyClass<T> where T : new()// Создание конструктора по умолчанию
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }
}
