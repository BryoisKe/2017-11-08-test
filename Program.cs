using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additionneur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Additionneur");
            Console.WriteLine("============" + Environment.NewLine);
            Console.Write("Saisir une valeur numérique réelle: ");
            double dblVal1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valeur saisie : " + dblVal1.ToString());
            Console.Read();
        }
    }
}
