using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    public class TreehouseDefenseException : System.Exception
    {
        public TreehouseDefenseException()
        {
        }

        public TreehouseDefenseException(string message) : base(message)
        {
        }
    }

    public class OutOfBoundsException : TreehouseDefenseException
    {
        public OutOfBoundsException()
        {
        }

        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}