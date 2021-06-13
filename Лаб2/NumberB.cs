using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб2
{
    class NumberB :Numbers
    {
        public new int Enter()
        {
            Console.WriteLine("Enter Number :");
            return Int32.Parse(Console.ReadLine());
        }
    }
}
