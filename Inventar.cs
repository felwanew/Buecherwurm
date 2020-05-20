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
            /*exemplar1.ExemplarBuch.Autor = bücherkatalog.KatalogBücher[i].Autor;
            exemplar1.ExemplarBuch.Land = bücherkatalog.KatalogBücher[i].Land;
            exemplar1.ExemplarBuch.Bildlink = bücherkatalog.KatalogBücher[i].Bildlink;
            exemplar1.ExemplarBuch.Sprache = bücherkatalog.KatalogBücher[i].Sprache;
            exemplar1.ExemplarBuch.Link = bücherkatalog.KatalogBücher[i].Link;
            exemplar1.ExemplarBuch.Seiten = bücherkatalog.KatalogBücher[i].Seiten;
            exemplar1.ExemplarBuch.Titel = bücherkatalog.KatalogBücher[i].Titel;
            exemplar1.ExemplarBuch.Erscheinungsjahr = bücherkatalog.KatalogBücher[i].Erscheinungsjahr;*/
            InventarExemplare.Add(exemplar1);
            Console.WriteLine(InventarExemplare[0].ExemplarBuch.Autor);
            Console.WriteLine(exemplar1.ExemplarID);
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
