using System;
//using System.Collections.Generic;

namespace Day_4__Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Dictionary<int, string> isim = new Dictionary<int, string>();
            Console.WriteLine(isim.Count);
            isim.Add(1, "Fatih Çil");
            Console.WriteLine(isim.Count);*/


            MyDictionary<int,string> plakaSehir= new MyDictionary<int, string>();
            
            plakaSehir.Add(06,"Ankara");
            plakaSehir.Add(16, "Bursa");
            plakaSehir.Add(34, "İstanbul");
            plakaSehir.Add(01, "Adana");


            plakaSehir.Show("PLAKA : ");

        }
    }

    class MyDictionary<TKey,TValue>
    {
        private TKey[] _Tkey;
        private TValue[] _Tvalue;


        private TKey[] _tempKey;
        private TValue[] _tempValue;


        public MyDictionary()
        {
            _Tkey = new TKey[0];
            _Tvalue = new TValue[0];
        }


        public void Add(TKey keyItem,TValue valueItem)
        {
            _tempKey = _Tkey;
            _tempValue = _Tvalue;

            _Tkey = new TKey[_Tkey.Length + 1];
            _Tvalue = new TValue[_Tvalue.Length + 1];



            for (int i = 0; i < _tempKey.Length; i++)
            {
                _Tkey[i] = _tempKey[i];
                _Tvalue[i] = _tempValue[i];
            }

            _Tkey[_Tkey.Length-1]=keyItem;
            _Tvalue[_Tvalue.Length - 1] = valueItem;

        }

        public void Show(string mes="")
        {
            for (int i = 0; i < _Tkey.Length; i++)
            {
                Console.WriteLine($"{mes} {_Tkey[i]} , {_Tvalue[i]}");
            }
        }

    }
}
