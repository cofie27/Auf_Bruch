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
using System.Collections.Generic;
using System.Text;

namespace Auf_Bruch
{
    class Bruch
    {
        private long z;
        private ulong n;
        private string b;
        
        //Standardkonstruktor
        public Bruch()
        {
            z = 1;
            n = 1;
            b = (z+ "/" + n);

        }
        //Überladener Konstruktor
        public Bruch(long z1, ulong n1)
        {
            this.z = z1;
            this.n = n1;

        }
        //Methoden

        //bekommt den Zähler aus dem Objekt
        public void setZaehler(long neuZ)
        //neu eingegebener Wert wird gleich z(Zaehler) gesetzt
        {
            this.z = neuZ;
        }
        //bekommt den Nenner aus dem Objekt
        public void setNenner(ulong neuN)
        //neu eingegebener Wert wird gleich n(Nenner) gesetzt
        {
            this.n = neuN;
        }
        //gibt den Zaehler zurück
        public long getZaehler()
        {
            return z;
        }
        //gibt den Nenner zurück
        public ulong getNenner()
        {
            return n;
        }
        //gibt das Objekt als String zurück
        override public string ToString()
        {
            if (n == 1)
            {
                return (Convert.ToString(z));
            }
            else
            {
                string bruch = "";
                string zwischenspeicherZ = Convert.ToString(z);
                string zwischenspeicherN = Convert.ToString(n);
                bruch = (z + "/" + n);
                return (bruch);
            } 
        }
        
        //kürzt den Bruch
        public Bruch Kuerzen()
        {
        
            long ggt = Convert.ToInt64(this.ToGGT(z, n));
            //Berechnet Zähler und Nenner mit Hilfe des übergebenen Objektes 
            if (ggt!=1)
            {
                this.z = this.z / ggt;
                this.n = this.n / Convert.ToUInt32(ggt);
            }
            return(this);
        }
        //Addiert die beiden Brüche miteinander
        public Bruch Summe(Bruch bruch1, Bruch bruch2)
        {
            // ein Neues Objekt wird erstellt
            Bruch summe = new Bruch();

            //Berechent Nenner und Zähler für das Ergebnis aus den beiden übergegebenen Objekte
            summe.setZaehler(bruch1.getZaehler() * Convert.ToInt64(bruch2.getNenner()) + bruch2.getZaehler() * Convert.ToInt64(bruch1.getNenner()));
            summe.setNenner(bruch1.getNenner() * bruch2.getNenner());

            
            return summe;
        }
        //Wandelt den Bruch in eine Gleitkommazahl um
        public double ToDouble(Bruch bruch)
        {
            //Die Umrechnung wird in einer neuen Variable gespeichert
            double doubleZahl = Convert.ToDouble(bruch.getZaehler()) / Convert.ToDouble(bruch.getNenner());

            return doubleZahl;
        }

        //Gibt den Kehrwert eines Bruches zurück
        public Bruch Kehrwert()
        {
            ulong cacheN;
            long cacheZ;
            //Erstellt ein neues Objekt
            Bruch kehrwert = new Bruch();

            if (getZaehler() < 0)
            {
                cacheN = Convert.ToUInt32(Convert.ToUInt32(getZaehler()* -1));
                cacheZ = Convert.ToInt32(getNenner()) * -1;
            }
            else
            {
                cacheN = Convert.ToUInt32(getZaehler());
                cacheZ = Convert.ToInt32(getNenner());
            }
            //Setzt die Variablen für das Ergebnis
            kehrwert.setNenner(cacheN);
            kehrwert.setZaehler(cacheZ);

            return kehrwert;
        }

        // Gibt das Produkt zurück
        public Bruch Produkt(Bruch bruch1, Bruch bruch2)
        {
            //Erstellt ein neues Objekt
            Bruch produkt = new Bruch();

            //Berechnet  Zähler und Negner für das Ergebnis Objekt
            produkt.setZaehler(bruch1.getZaehler() * bruch2.getZaehler());
            produkt.setNenner(bruch1.getNenner() * bruch2.getNenner());

            return produkt;
        }

        //Größter gemeinsamer Teiler wird zurück gegeben
        public long ToGGT(long zaehler, ulong nenner)
        {
            //Deklaration und Initialisierung von A und B
            long A = Convert.ToInt64(nenner);
            long B = Convert.ToInt64(zaehler);

            //Deklaration und Initialsierung t und g
            byte t = 2;
            byte g = 1;

            do
            {
                if (A % t == 0) //ist T ein Teiler von A
                {
                    if (B % t == 0) //ist T ein Teiler von B
                    {
                        g = t; //setze G = T
                    }
                }
                t++; //Erhöhe T um 1
            }
            while (t <= A && t <= B); // Solange t <= A && t <= B

            return g; //Gibt den GGT zurück

        }
    }
}
