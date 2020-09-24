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

            Jasen jasen = new Jasen("Mika", "Vainio", "Yläneentie 146", "23100", "Mynämäki", "123", "1", "20.4.1956");

            // Testataan Punnitus-olion toimintaa

            Punnitus punnitus = new Punnitus("10.9.2020", "70,5", "1,71");

            

            // Katsotaan olioiden ominaisuuksia

            Console.WriteLine("Testin jäsenen muodostimelle");
            jasen.naytaJasen();
            Console.WriteLine("Testi punnituksen muodostimelle");
            punnitus.naytaPunnitus();

            // Testi iän laskennan toimimisesta
            int vuotta = Rasvaprosentti.Ika("20.4.1956");
            Console.WriteLine("Olet " + vuotta + " vuotta vanha");

            // Testi BMI:n laskemiseksi
            float bmi = Rasvaprosentti.BMI("1,71", "71,5");
            Console.WriteLine("Painoindeksi on " + bmi);

            // Testi Rasvaprosentin laskennasta
            float rasvaprosentti = Rasvaprosentti.laskeRasva(bmi, vuotta, "Mies");
            Console.WriteLine("Rasvaprosentti on " + rasvaprosentti);

            // Testataan iän laskenta jäsen oliosta

            Rasvaprosentti.Ika(jasen)
         
                       
        }
    }
}
