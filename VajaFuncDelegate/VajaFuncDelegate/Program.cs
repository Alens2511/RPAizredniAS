using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VajaFuncDelegate
{
    internal class Program
    {
        delegate string Spremeni(string s);
        static void Main(string[] args)
        {
            Func<string, string> metoda = x => x.ToUpper();
            string ime = "Barbara";
            Console.WriteLine(metoda(ime));
            Console.ReadLine();
        }

        //private static string VVelike(string s)
        //{
        //    return s.ToUpper();
        //}
    }
}
