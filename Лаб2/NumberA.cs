using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб2
{
    public class Numberb : Numbers
    {
        public override int Enter()
        {
            Console.WriteLine("Enter Number A:");
            return Int32.Parse(Console.ReadLine());
        }
    }
}
