using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caruppgift
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bil minBil = new Bil("Volvo", 1965);
            Console.WriteLine("Jag har en " + minBil.Marke + " från " + minBil.Arsmodell + ".");
            Console.ReadLine();
        }
    }
}
