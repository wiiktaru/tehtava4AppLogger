// See https://aka.ms/new-console-template for more information
using AppLogger;
using Humanizer;

namespace App;

    internal class Programm
    {
        static void Main(string[] args)
        {
            Logger.Log("Erkki Esimerkki"); 

            string text = "Erkillä _oli _esimerkki_";
            Console.WriteLine(text.Humanize()); 
        }
    }






