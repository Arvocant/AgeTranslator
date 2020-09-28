using System;
using System.Collections.Generic;
using System.Text;

namespace AgeTranslator
{
    class Input
    {
        static public void getInput()
        {
            int jaar = 1900;
            int maand = 12;
            int dag = 27;
            Console.WriteLine("In welk jaar ben je geboren?");
            jaar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In welke maand ben je geboren?");
            maand = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Op welke dag ben je geboren?");
            dag = Convert.ToInt32(Console.ReadLine());
            AgeCalculation.berekening(dag, maand, jaar);
        }
    }
}
