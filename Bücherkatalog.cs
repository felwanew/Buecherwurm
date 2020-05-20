using System;
using System.Collections.Generic;

namespace Bücherwurmneu
{
    public class Bücherkatalog
    {
        public List<Buch> KatalogBücher = new List<Buch>();
        public Bücherkatalog() { }
        public void BuchHinzufügen()      //Das Objekt mit der Liste der Bücher wird am Anfang der Main Methode erzeugt
        {
            Buch buch1 = new Buch();
            Console.WriteLine("Bitte Autor eingeben");
            buch1.Autor = Console.ReadLine();
            Console.WriteLine("Bitte Land eingeben");
            buch1.Land = Console.ReadLine();
            Console.WriteLine("Bitte Bildlink eingeben");
            buch1.Bildlink = Console.ReadLine();
            Console.WriteLine("Bitte Sprache eingeben");
            buch1.Sprache = Console.ReadLine();
            Console.WriteLine("Bitte Link eingeben");
            buch1.Link = Console.ReadLine();
            Console.WriteLine("Bitte Seitenzahl eingeben");
            buch1.Seiten = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte Titel eingeben");
            buch1.Titel = Console.ReadLine();
            Console.WriteLine("Bitte Erscheinungsjahr eingeben");
            buch1.Erscheinungsjahr = Convert.ToInt32(Console.ReadLine());

            KatalogBücher.Add(buch1);
            Console.WriteLine(KatalogBücher[0].Autor);        //muss dann noch entfernt werden oder Bestätigung der Eingabe
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
