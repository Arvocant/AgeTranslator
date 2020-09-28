using System;
using System.Collections.Generic;
using System.Text;

namespace AgeTranslator
{
    class AgeCalculation
    {
        public int Dag { get; set; }
        public int Maand { get; set; }
        public int Jaar { get; set; }

        static void berekening(int Dag, int Maand, int Jaar)
        {
            DateTime huidigetijd = new DateTime(Jaar, Maand, Dag);
            
        }
    }
}
