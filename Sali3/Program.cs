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

            // Testataan oletusmuodostin

            Henkilo henkilo = new Henkilo();

            // Testataan muodostin kaikilla parametreillä

            Henkilo henkilo1 = new Henkilo("Mika", "Hakala", "Kotikatu 3", "20100", "Turku");

            // Testataan Jäsen-olion muodostimen toiminta

            Jasen jasen = new Jasen("Mika", "Vainio", "Yläneentie 146", "23100", "Mynämäki", "123", "1");

            // Testataan Trainer -olion muodostimen toiminta, huom. nimiavaruus Henkilosto

            Henkilosto.Trainer trainer = new Henkilosto.Trainer("Jakke", "Jäynä", "Kotikatu 2", "21200", "Raisio", "Juoksumatto", "044 705 7425", "jakke@huuhaa.com");

            // Testataan Punnitus-olion toimintaa

            Punnitus punnitus = new Punnitus("10.9.2020", "70,5", "1,71");

            // Katsotaan olioiden ominaisuuksia

            Console.WriteLine("Testi oletusmuodostimelle");
            henkilo.naytaHenkilo();
            Console.WriteLine("Testi muodostimelle kaikilla parametreillä");
            henkilo1.naytaHenkilo();
            Console.WriteLine("Testin jäsenen muodostimelle");
            jasen.naytaJasen();
            Console.WriteLine("Testi personal trainerin muodostimelle");
            trainer.naytaTrainer();
            Console.WriteLine("Testi punnituksen muodostimelle");
            punnitus.naytaPunnitus();
            Console.WriteLine("Painoindeksi (BMI-metodi) on " + punnitus.BMI());
            

           

        }
    }
}
