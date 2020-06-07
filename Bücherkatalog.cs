using System;
using System.Collections.Generic;

namespace Bücherwurmneu
{
    public class Bücherkatalog
    {
        public List<Buch> KatalogBücher = new List<Buch>();
        public void BuchHinzufügen(Inventar inventar)      //Das Objekt mit der Liste der Bücher wird am Anfang der Main Methode erzeugt
        {
            Buch buch = new Buch();
            Console.WriteLine("Bitte Autor eingeben");
            buch.Autor = Console.ReadLine();
            Console.WriteLine("Bitte Land eingeben");
            buch.Land = Console.ReadLine();
            Console.WriteLine("Bitte Bildlink eingeben");
            buch.Bildlink = Console.ReadLine();
            Console.WriteLine("Bitte Sprache eingeben");
            buch.Sprache = Console.ReadLine();
            Console.WriteLine("Bitte Link eingeben");
            buch.Link = Console.ReadLine();
            Console.WriteLine("Bitte Seitenzahl eingeben");
            buch.Seiten = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte Titel eingeben");
            buch.Titel = Console.ReadLine();
            Console.WriteLine("Bitte Erscheinungsjahr eingeben");
            buch.Erscheinungsjahr = Convert.ToInt32(Console.ReadLine());
            KatalogBücher.Add(buch1);
            Console.WriteLine(KatalogBücher[KatalogBücher.Count].Autor + KatalogBücher[KatalogBücher.Count].Land + KatalogBücher[KatalogBücher.Count].Bildlink +  KatalogBücher[KatalogBücher.Count].Sprache + KatalogBücher[KatalogBücher.Count].Link + KatalogBücher[KatalogBücher.Count].Seiten + KatalogBücher[KatalogBücher.Count].Titel + KatalogBücher[KatalogBücher.Count].Erscheinungsjahr);        //muss dann noch entfernt werden oder Bestätigung der Eingabe
            AutoExemplarHinzufügen(buch);
            AutoExemplarHinzufügen(buch);
        }


        public void Lesen()
        {
            for(int i = 0; i < KatalogBücher.Count; i++)
            {

                Console.WriteLine(i + " " + KatalogBücher[i].Autor /*und noch der Rest*/);
            }
        }
        public void Bearbeiten()     //Wenn Einträge nicht bearbeitet werden sollen, dann leer lassen
        {
            Console.WriteLine("Bitte Index eingeben");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte Autor eingeben, wenn Autor geändert werden soll\nLeerlassen, wenn Autor nicht verändert wird");
            string Autor = Console.ReadLine();
            if (Autor != "")
            {
                KatalogBücher[i].Autor = Autor;
            }
            Console.WriteLine("Bitte Land eingeben");
            string Landdesautoren = Console.ReadLine();
            if (Landdesautoren != "")
            {
                KatalogBücher[i].Land = Landdesautoren;
            }
            Console.WriteLine("Bitte Bildlink eingeben");
            string Bildlink = Console.ReadLine();
            if (Bildlink != "")
            {
                KatalogBücher[i].Bildlink = Bildlink;
            }
            Console.WriteLine("Bitte Sprache eingeben");
            string Sprache = Console.ReadLine();
            if (Sprache != "")
            {
                KatalogBücher[i].Sprache = Sprache;
            }
            Console.WriteLine("Bitte Link eingeben");
            string Link = Console.ReadLine();
            if (Link != "")
            {
                KatalogBücher[i].Link = Link;
            }
            Console.WriteLine("Bitte Seiten eingeben");
            
            string Seiten = Console.ReadLine();
            if (Seiten != "")
            {
                KatalogBücher[i].Seiten = Convert.ToInt32(Seiten);
            }
            Console.WriteLine("Bitte Titel eingeben");
            string Titel = Console.ReadLine();
            if (Titel != "")
            {
                KatalogBücher[i].Titel = Titel;
            }
            Console.WriteLine("Bitte Erscheinungsjahr eingeben");
            string Erscheinungsjahr = Console.ReadLine();
            if (Erscheinungsjahr != "")
            {
                KatalogBücher[i].Erscheinungsjahr = Convert.ToInt32(Erscheinungsjahr);
            }
        }
        public void Löschen()
        {
            Console.WriteLine("Bitte Index eingeben");
            int i = Convert.ToInt32(Console.ReadLine());
            KatalogBücher.RemoveAt(i);
        }

    }
}
