using System;
using System.Text.RegularExpressions;

namespace Лаб2
{
    class Program
    {
        static int sum = 0;
        static int numba=0;
        static int numbb = 0;
        static void Main(string[] args)
        {

            EnterNumberA();
            EnterNumberB();
            string C = string.Join(";", new object[] { numba.ToString(),numbb.ToString()});
            sum = numba + numbb;
            Console.Write(@"{0} sum= {1}", C, sum);
            Console.ReadKey();
        }


        public static void EnterNumberA()
        {
            Numbers a = new Numberb();
           
            try
            {
                numba = a.Enter();

            }
            catch (Exception)
            {

                Console.WriteLine("Invalid Number");
                EnterNumberA();
            }
      
        }
        public static void EnterNumberB()
        {
            Numbers b = new NumberB();

            try
            {
                numbb = b.Enter();

            }
            catch (Exception)
            {

                var c = "w";
                if (Regex.IsMatch(c, @"\w")){

                    Console.WriteLine("Invalid Number");

                    EnterNumberB();
                }
            
            }

        }




    }
}
