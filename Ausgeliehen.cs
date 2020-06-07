using System;
using System.Collections.Generic;
using System.Text;

namespace Bücherwurmneu
{
    public class Ausgeliehen
    {
        public List<Ausleihe> AusleiheListe = new List<Ausleihe>();
        public void AusleiheHinzufügen(Inventar inventar)
        {

            Ausleihe ausleihe1 = new Ausleihe();
            Console.WriteLine("Bitte Index des Exemplars eingeben");
            int ExemplarID = Convert.ToInt32(Console.ReadLine());
            ausleihe1.AnfangAusleih = DateTime.now;
            ausleihe1.Exemplar = inventar.InventarExemplare.Find(x => x.ExemplarID == ExemplarID);
            //Key schon vergeben
            if (inventar.InventarExemplare[ExemplarID].EndeAusleih < DateTime.Now)
                inventar.InventarExemplare[ExemplarID].Ausleihe = false;
            if (inventar.InventarExemplare[ExemplarID].IstVerliehen == false)
            {
                inventar.InventarExemplare[ExemplarID].IstVerliehen = true;
                Console.WriteLine("Bitte Anfangsdatum der Ausleihe eingeben");
                ausleihe1.EndeAusleih = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Bitte Kunde eingeben");
                ausleihe1.Kunde = Console.ReadLine();
                AusleiheListe.Add(ausleihe1);
            }
            else
                Console.WriteLine("Exemplar ist schon verliehen");
        }
        public void Lesen()
        {
            for (int i = 0; i < AusleiheListe.Count; i++)
            {

                Console.WriteLine(i + " " + AusleiheListe[i].AnfangAusleih + " " + AusleiheListe[i].EndeAusleih + AusleiheListe[i].Kunde);
            }
        }
        public void Bearbeiten()
        {
            Console.WriteLine("Bitte Index eingeben");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte Autor eingeben, wenn Autor geändert werden soll\nLeerlassen, wenn Autor nicht verändert wird");
            string ExemplarID = Console.ReadLine();
            if (ExemplarID != "")
            {
                AusleiheListe[i].Exemplar.ExemplarID = Convert.ToInt32(ExemplarID);
            }
            Console.WriteLine("Bitte Anfang der Ausleihe eingeben, wenn Anfang der Ausleihe geändert werden soll\nLeerlassen, wenn Anfang der Ausleihe nicht verändert wird");
            string AnfangAusleih = Console.ReadLine();
            if (AnfangAusleih != "")
            {
                AusleiheListe[i].AnfangAusleih = Convert.ToDateTime(AnfangAusleih);
            }
            Console.WriteLine("Bitte Ende der Ausleihe eingeben, wenn Ende der Ausleihe geändert werden soll\nLeerlassen, wenn Ende der Ausleihe nicht verändert wird");
            string EndeAusleih = Console.ReadLine();
            if (EndeAusleih != "")
            {
                AusleiheListe[i].EndeAusleih = Convert.ToDateTime(EndeAusleih);
            }
            Console.WriteLine("Bitte Kunden eingeben, wenn Kunden geändert werden soll\nLeerlassen, wenn Kunden nicht verändert wird");
            string Kunde = Console.ReadLine();
            if (Kunde != "")
            {
                AusleiheListe[i].Kunde = Kunde;
            }
        }
        public void Löschen()
        {
            Console.WriteLine("Bitte Index eingeben");
            int i = Convert.ToInt32(Console.ReadLine());
            AusleiheListe.RemoveAt(i);
        }
    }
}
