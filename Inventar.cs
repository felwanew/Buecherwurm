using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bücherwurmneu
{
    public class Inventar
    {
        
        public List<Exemplar> InventarExemplare = new List<Exemplar>();
        //CRUD-Methoden für Exemplare
        public void ExemplarHinzufügen(Bücherkatalog bücherkatalog)
        {
            Exemplar exemplar1 = new Exemplar();
            exemplar1.ExemplarID = InventarExemplare.Count;
            Console.WriteLine("Bitte Index des Buches eingeben");
            int i = Convert.ToInt32(Console.ReadLine());
            exemplar1.ExemplarBuch = bücherkatalog.KatalogBücher[i];
            InventarExemplare.Add(exemplar1);
            Console.WriteLine(InventarExemplare[0].ExemplarBuch.Autor);
            Console.WriteLine(exemplar1.ExemplarID);
        }
        public static void AutoExemplarHinzufügen(Buch buch)
        {
            Exenplar exemplar1 = new Exemplar();
            exemplar1.ExemplarID = InventarExemplare.Count;
            exemplar1.ExemplarBuch = buch;
        }




        public void Lesen()
        {
            for (int i = 0; i < InventarExemplare.Count; i++)
            {

                Console.WriteLine(i + " " + InventarExemplare[i].ExemplarBuch.Autor /*und noch der Rest*/);
            }
        }
        public void Bearbeiten()
        {
            Console.WriteLine("Bitte Index eingeben");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte Autor eingeben, wenn Autor geändert werden soll\nLeerlassen, wenn Autor nicht verändert wird");
            string Autor = Console.ReadLine();
            if (Autor != "")
            {
                InventarExemplare[i].ExemplarBuch.Autor = Autor;
            }
            Console.WriteLine("Bitte Land eingeben");
            string Landdesautoren = Console.ReadLine();
            if (Landdesautoren != "")
            {
                InventarExemplare[i].ExemplarBuch.Land = Landdesautoren;
            }
            Console.WriteLine("Bitte Bildlink eingeben");
            string Bildlink = Console.ReadLine();
            if (Bildlink != "")
            {
                InventarExemplare[i].ExemplarBuch.Bildlink = Bildlink;
            }
            Console.WriteLine("Bitte Sprache eingeben");
            string Sprache = Console.ReadLine();
            if (Sprache != "")
            {
                InventarExemplare[i].ExemplarBuch.Sprache = Sprache;
            }
            Console.WriteLine("Bitte Link eingeben");
            string Link = Console.ReadLine();
            if (Link != "")
            {
                InventarExemplare[i].ExemplarBuch.Link = Link;
            }
            Console.WriteLine("Bitte Seiten eingeben");

            string Seiten = Console.ReadLine();
            if (Seiten != "")
            {
                InventarExemplare[i].ExemplarBuch.Seiten = Convert.ToInt32(Seiten);
            }
            Console.WriteLine("Bitte Titel eingeben");
            string Titel = Console.ReadLine();
            if (Titel != "")
            {
                InventarExemplare[i].ExemplarBuch.Titel = Titel;
            }
            Console.WriteLine("Bitte Erscheinungsjahr eingeben");
            string Erscheinungsjahr = Console.ReadLine();
            if (Erscheinungsjahr != "")
            {
                InventarExemplare[i].ExemplarBuch.Erscheinungsjahr = Convert.ToInt32(Erscheinungsjahr);
            }
        }
        //entweder manuelle Bearbeitung in der Methode oder Methodenaufruf in der Bücherkatalog.Bearbeiten, 
        //dass jedes mal, wenn ein Buch verändert wird, die Exemplare angepasst werden
    
        public void Löschen()
        {
            Console.WriteLine("Bitte Index eingeben");
            int i = Convert.ToInt32(Console.ReadLine());
            InventarExemplare.RemoveAt(i);
            //foreach zum ändern der ID hinzufügen
        }

    }
}
