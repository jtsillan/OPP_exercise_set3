using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_Osa3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tehtävä 2.
            Vehicle audi = new Vehicle("100", "Audi");

            // tehtävä 5.
            audi.Accelerate();

            // tehtävä 6.
            audi.Brake();

            // tehtävä 10.
            Console.WriteLine(audi.Model.ToString());

            Console.WriteLine(audi.Manufactor.ToString());

        }
    }
}
