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
            KatalogBücher.Add(buch);
            Console.WriteLine(KatalogBücher[KatalogBücher.Count-1].Autor + KatalogBücher[KatalogBücher.Count-1].Land + KatalogBücher[KatalogBücher.Count-1].Bildlink +  KatalogBücher[KatalogBücher.Count-1].Sprache + KatalogBücher[KatalogBücher.Count-1].Link + KatalogBücher[KatalogBücher.Count-1].Seiten + KatalogBücher[KatalogBücher.Count-1].Titel + KatalogBücher[KatalogBücher.Count-1].Erscheinungsjahr);        //muss dann noch entfernt werden oder Bestätigung der Eingabe
            Inventar.AutoExemplarHinzufügen(buch);
            Inventar.AutoExemplarHinzufügen(buch);
        }


        public void Lesen()
        {
            for(int i = 0; i < KatalogBücher.Count; i++)
            {

                Console.WriteLine(i + "    " + KatalogBücher[i].Autor + "    " +KatalogBücher[i].Land + "    " +KatalogBücher[i].Bildlink +"    " +  KatalogBücher[i].Sprache +"    " + KatalogBücher[i].Link +"    " + KatalogBücher[i].Seiten +"    " + KatalogBücher[i].Titel +"    " + KatalogBücher[i].Erscheinungsjahr /*und noch der Rest*/);
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
            Console.WriteLine("Bitte Land eingeben, wenn Land geändert werden soll\nLeerlassen, wenn Land nicht verändert wird");
            string Landdesautoren = Console.ReadLine();
            if (Landdesautoren != "")
            {
                KatalogBücher[i].Land = Landdesautoren;
            }
            Console.WriteLine("Bitte Bildlink eingeben, wenn Bildlink geändert werden soll\nLeerlassen, wenn Bildlink nicht verändert wird");
            string Bildlink = Console.ReadLine();
            if (Bildlink != "")
            {
                KatalogBücher[i].Bildlink = Bildlink;
            }
            Console.WriteLine("Bitte Sprache eingeben, wenn Sprache geändert werden soll\nLeerlassen, wenn Sprache nicht verändert wird");
            string Sprache = Console.ReadLine();
            if (Sprache != "")
            {
                KatalogBücher[i].Sprache = Sprache;
            }
            Console.WriteLine("Bitte Link eingeben, wenn Link geändert werden soll\nLeerlassen, wenn Link nicht verändert wird");
            string Link = Console.ReadLine();
            if (Link != "")
            {
                KatalogBücher[i].Link = Link;
            }
            Console.WriteLine("Bitte Seitenzahl eingeben, wenn Seitenzahl geändert werden soll\nLeerlassen, wenn Seitenzahl nicht verändert wird");
            
            string Seiten = Console.ReadLine();
            if (Seiten != "")
            {
                KatalogBücher[i].Seiten = Convert.ToInt32(Seiten);
            }
            Console.WriteLine("Bitte Titel eingeben, wenn Titel geändert werden soll\nLeerlassen, wenn Titel nicht verändert wird");
            string Titel = Console.ReadLine();
            if (Titel != "")
            {
                KatalogBücher[i].Titel = Titel;
            }
            Console.WriteLine("Bitte Erscheinungsjahr eingeben, wenn Erscheinungsjahr geändert werden soll\nLeerlassen, wenn Erscheinungsjahr nicht verändert wird");
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
