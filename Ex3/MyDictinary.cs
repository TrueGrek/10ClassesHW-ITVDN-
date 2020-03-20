using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3
{
    class MyDictionary<TKey,TValue>
    {
        private readonly TKey[] key;
        private readonly TValue[] value;
        private readonly int length;

        public int Lenght
        {
            get { return length; }
        }
        public MyDictionary(int n)
        {
            key = new TKey[n];
            value = new TValue[n];
            length = n;
        }

        public string this[int index]
        {
            get
            {
                if(index>=0 && index <= length)
                {
                    return key[index] + " - " + value[index];
                }
                return "Куда ты лезишь, друг?";
            }
        }

        public void Add(int i, TKey key, TValue value)
        {
            this.key[i] = key;
            this.value[i] = value;
        }
    }
}
