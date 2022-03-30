using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Horse:Animal
    {
        public string Sort { get; set; }
        public static int TotalCount { get =>_totalCount;}
        static int _totalCount;
        public Horse()
        {
            _totalCount++;
        }
    }
}
