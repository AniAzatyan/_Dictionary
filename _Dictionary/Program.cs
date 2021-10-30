using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _Dictionary;

namespace _Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            _Dictionary<int, string> myDict = new _Dictionary<int, string>;
            myDict.Add(1, "Anna");
            myDict.Add(2, "Liana");
            myDict.Remove(2);
            myDict.Add(24, "Mariam");
        }
    }
}