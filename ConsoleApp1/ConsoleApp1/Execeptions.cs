using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class SalaryException : Exception
    {
        public SalaryException(string message) : base(message)
        {
        }
    }
    internal class WorkTimeException : Exception
    {
        public WorkTimeException(string message) : base(message)
        {

        }
    }
    internal class AgeException : Exception
    {
        public AgeException(string message) : base(message)
        {
        }
    }
}
