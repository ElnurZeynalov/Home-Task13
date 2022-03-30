using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class LimitException:Exception
    {
        public LimitException(string message) : base(message)
        {
        }
    }
}
