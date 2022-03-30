using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Sheep:Animal
    {
        public string Type { get; set; }
        public static int TotalCount { get=>_totalCount;}
        static int _totalCount;
        public Sheep()
        {
            _totalCount++;
        }
    }
}
