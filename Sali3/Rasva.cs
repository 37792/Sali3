using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Sali3
{
    class Rasvaprosentti
    {
        // Staattinen metodi iän laskemiseksi
        static public int Ika(string syntymapaiva)
        {
            CultureInfo cultureInfo = new CultureInfo("fi-FI");
            DateTime vuosinolla = new DateTime(1, 1, 1);
            DateTime spaiva = DateTime.Parse(syntymapaiva, cultureInfo);
            DateTime tanaan = DateTime.Now;
            TimeSpan ero = tanaan - spaiva;
            int ika = (vuosinolla + ero).Year - 1;
            return ika;
        }
        
        // Staattinen metodi painoindeksin laskemiseksi
        static public float BMI(string pituus, string paino)
        {
            // Muutetaan olion merkkijono-ominaisuudet liukuluvuiksi
            float painoKg = float.Parse(paino);
            float pituusM = float.Parse(pituus);

            // Lasketaan painoindeksi ja palautetaan se
            float bmi = painoKg / (pituusM * pituusM);
            return bmi;
        }

        // Staattinen metodi, jolla rasvaprosentti voidaan laskea ilman oliota
        static public float laskeRasva(float bmi , int ika, string sukupuoli)
        {
            float sukupuolikerroin = 0;
            sukupuoli = sukupuoli.ToLower();
            if (sukupuoli == "mies")
            {
                sukupuolikerroin = 1;
            }
            float rasva = (1.2f * bmi) + (0.23f * ika) - (10.8f * sukupuolikerroin) - 5.4f;
            return rasva;
        }
    }
}
