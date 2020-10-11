using System;
using System.Collections.Generic;
using System.Linq;

namespace Testar
{
    class Program
    {
        public static List<int> _klockor = new List<int>();

        static void Main(string[] args)
        {
            int lager = 5;

            _klockor.Add(lager);
            _klockor.Add(5);

            _klockor.Insert(1, 22);
            for (int i = 0; i < _klockor.Count; i++)
            {
                if (_klockor.Contains(lager))
                {
                    if (_klockor[1] < 30)
                    {
                        Console.WriteLine("HEJ");
                    }

                }
            }
            }
        }
    }

