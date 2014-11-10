using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: 31337\nOutput: "+DigitalRoot("31337"));
            Console.WriteLine("Input: 45734\nOutput: "+DigitalRoot("45734"));

            // Keep the console open
            Console.ReadLine();
        }
        static int DigitalRoot(string rootThis)
        {
            if (int.Parse(rootThis) < 10){ return int.Parse(rootThis);} // We got to the singular digit
            else { return DigitalRoot(rootThis.Sum(x=>int.Parse(x.ToString())).ToString());} // Add up each individual character in the string and call recursivly
        }
    }
}
