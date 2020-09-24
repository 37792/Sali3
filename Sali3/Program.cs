using System;


namespace Sali3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testataan Henkilo-olion luontia");

           /*------------------------------------
             | TESTAUS ALKAA TÄSTÄ              |
             ------------------------------------*/


            // Testataan Jäsen-olion muodostimen toiminta

            Jasen jasen = new Jasen("Mika", "Vainio", "Yläneentie 146", "23100", "Mynämäki", "12345", "Mies", "26.6.1962");

            // Testataan Punnitus-olion toimintaa

            Punnitus punnitus = new Punnitus("20.4.2020", "71,5", "1,71");

            // Katsotaan olioiden ominaisuuksia

            Console.WriteLine("Testin jäsenen muodostimelle");
            jasen.naytaJasen();
            Console.WriteLine("Testi punnituksen muodostimelle");
            punnitus.naytaPunnitus();

            // Testi iän laskennan toimimisesta
            int vuotta = Rasvaprosentti.Ika("26.6.1962");
            Console.WriteLine("Olet " + vuotta + " vuotta vanha");

            // Testi BMI:n laskemiseksi
            float bmi = Rasvaprosentti.BMI("1,71", "71,5");
            Console.WriteLine("Painoindeksi on " + bmi);

            // Testi Rasvaprosentin laskennasta
            float rasvaprosentti = Rasvaprosentti.laskeRasva(bmi, vuotta, "Mies");
            Console.WriteLine("Rasvaprosentti on " + rasvaprosentti);

            // Testataan iän laskenta jäsen oliosta

            Console.WriteLine ("Ikä oliolla jäsen on " + Rasvaprosentti.Ika(jasen.Syntymäaika));

            // Integraatiotesti 1. rasvaprosentin laskenta - jäsen ja punnitus olioista

            int jika = Rasvaprosentti.Ika(jasen.Syntymäaika);            
            float jbmi = Rasvaprosentti.BMI(punnitus.Pituus, punnitus.Paino);
            float jrprosentti = Rasvaprosentti.laskeRasva(jbmi, jika, jasen.Sukupuoli);

            Console.WriteLine("Jäsenen ikä on " + jika + ", bmi on " + jbmi + " ja rasvaprosentti on " + jrprosentti);

            // Jako nollalla testi

            string nollapituus = "0";
            string paino = "71,5";
            float bmikaatuu = Rasvaprosentti.BMI(nollapituus, paino);
            Console.WriteLine("BMI on " + bmikaatuu);


         
                       
        }
    }
}
