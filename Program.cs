using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Bücherwurmneu
{
    
    public class Program
    {


        
        static public void Main(string[] args)
        {
            Buch buch = new Buch();
            Bücherkatalog bücherkatalog = new Bücherkatalog();
            Inventar inventar = new Inventar();
            Ausgeliehen ausgeliehen = new Ausgeliehen();

            bool Beenden = false;
            string Auswahl;
            while (Beenden == false)
            {
                bool OffenUnterprogramm = true;
                string ZuBearbeiteneKategorie;
                Auswahloptionen();
                Auswahl = Console.ReadLine();
                if (Auswahl == "b")
                {
                    ZuBearbeiteneKategorie = "Buch";
                    while (OffenUnterprogramm == true)
                    {
                        Auswahl = AuswahloptionenUnterprogrammCrud(Auswahl, ZuBearbeiteneKategorie);
                        if (Auswahl == "c")
                            bücherkatalog.BuchHinzufügen();
                        else if (Auswahl == "r")
                            bücherkatalog.Lesen();
                        else if (Auswahl == "u")
                            bücherkatalog.Bearbeiten();
                        else if (Auswahl == "d")
                            bücherkatalog.Löschen();
                        else if (Auswahl == "q")
                            OffenUnterprogramm = false;
                        else
                            Console.WriteLine("Eingabe ungültig");
                    }
                }
                else if (Auswahl == "e")
                {
                    ZuBearbeiteneKategorie = "Exemplar";
                    while (OffenUnterprogramm == true)
                    {
                        Auswahl = AuswahloptionenUnterprogrammCrud(Auswahl, ZuBearbeiteneKategorie);
                        if (Auswahl == "c")
                            inventar.ExemplarHinzufügen(bücherkatalog);
                        else if (Auswahl == "r")
                            inventar.Lesen();
                        else if (Auswahl == "u")
                            inventar.Bearbeiten();
                        else if (Auswahl == "d")
                            inventar.Löschen();
                        else if (Auswahl == "q")
                            OffenUnterprogramm = false;
                        else
                            Console.WriteLine("Eingabe ungültig");
                    }
                    
                }
                else if (Auswahl == "a")
                {
                    ZuBearbeiteneKategorie = "Ausleihe";
                    while (OffenUnterprogramm == true)
                    {
                        Auswahl = AuswahloptionenUnterprogrammCrud(Auswahl, ZuBearbeiteneKategorie);
                       if (Auswahl == "c")
                            ausgeliehen.AusleiheHinzufügen(inventar);
                        else if (Auswahl == "r")
                            ausgeliehen.Lesen();
                        else if (Auswahl == "u")
                            ausgeliehen.Bearbeiten();
                        else if (Auswahl == "d")
                            ausgeliehen.Löschen();
                        else if (Auswahl == "q")
                            OffenUnterprogramm = false;
                        else
                            Console.WriteLine("Eingabe ungültig");
                    }
                }
                else if (Auswahl == "q")
                {
                    Beenden = true;
                }
                else
                {
                    Console.Write("\nungültige Eingabe\nBitte nochmal versuchen");
                }
            }

            string AuswahloptionenUnterprogrammCrud(string Auswahl, string ZuBearbeiteneKategorie)
            {
                Console.Write("Für das Anlegen eines neuen " + ZuBearbeiteneKategorie + "s 'c' eingeben\n");
                Console.Write("Für das Auslesen aller " + ZuBearbeiteneKategorie + "er 'r' eingeben\n");
                Console.Write("Für das Bearbeiten eines " + ZuBearbeiteneKategorie + "es 'u' eingeben\n");
                Console.Write("Für das Löschen eines " + ZuBearbeiteneKategorie +"es 'd' eingeben\n");
                Console.Write("Für das Beenden des Unterprogramms 'q' eingeben\n");
                return Auswahl = Console.ReadLine();
            }
        }
        static public void Auswahloptionen()
        {

            Console.Write("\nBücherverleih Bücherwurm\n");
            Console.Write("\nFür die Liste der Bücher 'b' eingeben\n");
            Console.Write("Für die Liste der Exemplare 'e' eingeben\n");
            Console.Write("Für die Liste der Ausleihe 'a' eingeben\n");
            Console.Write("Für das Beenden des Programms 'q' eingeben\n");
        }
    }
    /*

    public class Exemplar
    {

        public void Anlegen(Exemplar exemplar, Dictionary<int, Exemplar> Exemplare, Dictionary<int, Buch> Bücher)
        {
            ExemplarID = SetzeExemplarID(ExemplarID);
            int i = Convert.ToInt32(Console.ReadLine());
            exemplar = new Exemplar(BuchID = Bücher[i].BuchID, Autor = Bücher[i].Autor, Landdesautoren = Bücher[i].Landdesautoren, Bildlink = Bücher[i].Bildlink,
                Sprache = Bücher[i].Sprache, Link = Bücher[i].Link, Seiten = Convert.ToInt32(Bücher[i].Seiten),
                Titel = Bücher[i].Titel, Erscheinungsjahr = Convert.ToInt32(Bücher[i].Erscheinungsjahr));
            Exemplare.Add(ExemplarID, exemplar);

        }
        static int SetzeExemplarID(int ExemplarIncrement)
        {
            return ExemplarIncrement = ExemplarIncrement + 1;
        }
        void Auslesen(Exemplar exemplar1, Dictionary<int, Exemplar> Exemplare, Dictionary<int, Buch> Bücher)
        {
            for (int i = 1; i <= ExemplarID; i++)
            {
                Console.WriteLine(Exemplare[i].BuchID + i + Exemplare[i].Autor + Exemplare[i].Landdesautoren + Exemplare[i].Bildlink +
                    Exemplare[i].Sprache + Exemplare[i].Link + Exemplare[i].Seiten + Exemplare[i].Titel + Exemplare[i].Erscheinungsjahr);
            }
        }
        void Bearbeiten(Exemplar exemplar1, Dictionary<int, Exemplar> Exemplare)
        {
            int i = Convert.ToInt32(Console.ReadLine());
            string Autor = Console.ReadLine();
            if (Autor != "")
            {
                Exemplare[i].Autor = Autor;
            }
            string Landdesautoren = Console.ReadLine();
            if (Landdesautoren != "")
            {
                Exemplare[i].Landdesautoren = Landdesautoren;
            }
            string Bildlink = Console.ReadLine();
            if (Bildlink != "")
            {
                Exemplare[i].Bildlink = Bildlink;
            }
            string Sprache = Console.ReadLine();
            if (Sprache != "")
            {
                Exemplare[i].Sprache = Sprache;
            }
            string Link = Console.ReadLine();
            if (Link != "")
            {
                Exemplare[i].Link = Link;
            }
            int Seiten = Convert.ToInt32(Console.ReadLine());
            if (Seiten != Convert.ToInt32(""))
            {
                Exemplare[i].Seiten = Seiten;
            }
            string Titel = Console.ReadLine();
            if (Titel != "")
            {
                Exemplare[i].Titel = Titel;
            }
            int Erscheinungsjahr = Convert.ToInt32(Console.ReadLine());
            if (Erscheinungsjahr != Convert.ToInt32(""))
            {
                Exemplare[i].Erscheinungsjahr = Erscheinungsjahr;
            }

        }
        void Löschen(Exemplar exemplar1, Dictionary<int, Exemplar> Exemplare)
        {
            int i = Convert.ToInt32(Console.ReadLine());
            Exemplare.Remove(i);
        }
    }

    public class Ausleihe
    {
        
        public void Crud(string Auswahl, Ausleihe ausleihe, Dictionary<int, Ausleihe> Ausleihe, Exemplar exemplar, Dictionary<int, Exemplar> Exemplare)
        {
            
        }
        public void Anlegen(Ausleihe ausleihe, Dictionary<int, Ausleihe> Ausleihe, Exemplar exemplar, Dictionary<int, Exemplar> Exemplare)
        {
            ausleihe = new Ausleihe(AnfangAusleih = Convert.ToDateTime(Console.ReadLine()), EndeAusleih = Convert.ToDateTime(Console.ReadLine()), Kunde = Console.ReadLine());
            AusleihID = SetzeAusleihID(AusleihID);
            Ausleihe.Add(AusleihID, ausleihe);

        }
        static int SetzeAusleihID(int AusleihID)
        {
            return AusleihID = AusleihID + 1;
        }
        void Auslesen(Ausleihe ausleihe, Dictionary<int, Ausleihe> Ausleihe)
        {
            for (int i = 1; i <= AusleihID; i++)
            {
                Console.WriteLine(i + " " + Ausleihe[i].AnfangAusleih + Ausleihe[i].EndeAusleih + Ausleihe[i].Kunde);
            }
        }
        void Bearbeiten(Ausleihe ausleihe, Dictionary<int, Ausleihe> Ausleihe)
        {
            int i = Convert.ToInt32(Console.ReadLine());
            DateTime AnfangAusleih = Convert.ToDateTime(Console.ReadLine());
            if (AnfangAusleih != Convert.ToDateTime(""))
            {
                Ausleihe[i].AnfangAusleih = AnfangAusleih;
            }
            DateTime EndeAusleih = Convert.ToDateTime(Console.ReadLine());
            if (EndeAusleih != Convert.ToDateTime(""))
            {
                Ausleihe[i].EndeAusleih = EndeAusleih;
            }
            string Kunde = Console.ReadLine();
            if (Kunde != "")
            {
                Ausleihe[i].Kunde = Kunde;
            }

        }
        void Löschen(Ausleihe ausleihe, Dictionary<int, Ausleihe> Ausleihe)
        {
            int i = Convert.ToInt32(Console.ReadLine());
            Ausleihe.Remove(i);
        }
        
    }*/
}
