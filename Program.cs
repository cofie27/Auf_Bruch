//------------------------------------------------------------------------------------------------------------------------------------
//Dateiname     : Auf_Bruch
//Projekt	    : Auf_Bruch
//Beschreibung  : mit Brüchen rechnen
//Autoren	    : Paul Atuahene
//Erstellung	: 26.01.2021
//letzte Änd.	: 26.01.2021
//Fehler	    : 
//Dokument	    : auf_Bruch
//------------------------------------------------------------------------------------------------------------------------------------

using System;

namespace Auf_Bruch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objekt b1 und b2 werden erzeugt
            Bruch b1 = new Bruch();
            Bruch b2 = new Bruch();
           

            //Tests
            Console.WriteLine("Bitte erstmalig zwei Werte eingeben: ");
            Console.Write("Wert1: ");
            b1.setZaehler(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Wert2: ");
            b1.setNenner(Convert.ToUInt32(Console.ReadLine()));
            Console.WriteLine("Bitte zweitmalig zwei Werte eingeben: ");
            Console.Write("Wert1: ");
            b2.setZaehler(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Wert2: ");
            b2.setNenner(Convert.ToUInt32(Console.ReadLine()));
            Console.Write("Erster Bruch: ");
            Console.WriteLine(b1);
            Console.Write("Zweiter Bruch: ");
            Console.WriteLine(b2);
            Console.Write("gekürzter Bruch1: ");
            Console.WriteLine(b1.Kuerzen());
            Console.Write("gekürzter Bruch2: ");
            Console.WriteLine(b2.Kuerzen());
            Console.Write("Summe der beiden Brüche: ");
            Console.WriteLine(b1.Summe(b1, b2).Kuerzen());
            Console.Write("Gleitkommazahl Bruch1: ");
            Console.WriteLine(b1.ToDouble(b1));
            Console.Write("Gleitkommazahl Bruch2: ");
            Console.WriteLine(b1.ToDouble(b2));
            Console.Write("Kehrwert Bruch1: ");
            Console.WriteLine(b1.Kehrwert());
            Console.Write("Kehrwert Bruch2: ");
            Console.WriteLine(b2.Kehrwert());
            Console.Write("Produkt der beiden Brüche : ");
            Console.WriteLine(b1.Produkt(b1, b2));

            Console.ReadKey();
        }
    }
}

