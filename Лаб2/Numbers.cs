using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб2
{
    public abstract class Numbers : IENter
    {
        public virtual int Enter()
        {
            Console.WriteLine("Enter Number B:");
            return Int32.Parse(Console.ReadLine());
        }
        ~Numbers()
        {
            Console.WriteLine("Finaliaing");
        }
    }
}
