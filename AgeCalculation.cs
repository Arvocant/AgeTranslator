using System;
using System.Collections.Generic;
using System.Text;

namespace AgeTranslator
{
    class AgeCalculation
    {
        static public TimeSpan berekening(int Dag, int Maand, int Jaar)
        {
            DateTime geboorte = new DateTime(Jaar, Maand, Dag);
            DateTime huidigetijd = DateTime.Now;
            TimeSpan leeftijd = huidigetijd - geboorte;
            //int leeftijd = geboorte.Year - huidigetijd.Year;

            return leeftijd;
        }
    }
}
